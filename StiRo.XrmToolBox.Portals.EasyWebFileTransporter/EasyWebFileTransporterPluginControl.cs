using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using StiRo.XrmToolBox.Portals.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace StiRo.XrmToolBox.Portals.EasyWebFileTransporter
{
    public partial class EasyWebFileTransporterPluginControl : MultipleConnectionsPluginControlBase
    {
        private Settings _settings;

        private ConnectionDetail _source;
        private ConnectionDetail _target;

        public EasyWebFileTransporterPluginControl()
        {
            InitializeComponent();
        }

        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);
            if (actionName != "AdditionalOrganization")
            {
                _source = detail;
                GetSettings();
                textBox_sourceEnvironment.Text = $"{_source.ConnectionName} ({_source.OriginalUrl})";
                GetPortalWebFiles();
            }
        }

        private void GetSettings()
        {
            if (_source == null)
            {
                MessageBox.Show("Source environment is required", "Missing environments", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!SettingsManager.Instance.TryLoad(GetType(), out _settings, ConnectionDetail.ConnectionId.ToString()))
            {
                _settings = new Settings();
                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        protected override void ConnectionDetailsUpdated(NotifyCollectionChangedEventArgs e)
        {
            if (e.Action.Equals(NotifyCollectionChangedAction.Add))
            {
                var detail = (ConnectionDetail)e.NewItems[0];
                _target = detail;
                textBox_targetEnvironment.Text = $"{_target.ConnectionName} ({_target.OriginalUrl})";
            }
        }

        private void button_selectTargetEnvironment_Click(object sender, EventArgs e)
        {
            AddAdditionalOrganization();
        }

        private void GetPortalWebFiles()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting portal web files",
                Work = (worker, args) =>
                {
                    args.Result = Service.RetrieveMultiple(new QueryExpression("adx_webfile")
                    {
                        ColumnSet = new ColumnSet("adx_webfileid", "adx_name"),
                        Orders = {
                            new OrderExpression("adx_name", OrderType.Ascending)
                        }
                    }).Entities.Select(e => new WebFile
                    {
                        Entity = e,
                        Id = e.Id,
                        Name = e.GetAttributeValue<string>("adx_name")
                    }).ToList();
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    List<WebFile> webFiles = args.Result as List<WebFile>;
                    treeView_webFiles.Nodes.Clear();
                    webFiles.ForEach(wf => treeView_webFiles.Nodes.Add(new TreeNode()
                    {
                        Text = wf.Name,
                        Tag = wf,
                        Checked = _settings.CheckedWebFiles.Contains(wf.Id)
                    }));
                }
            });
        }

        private void button_saveSelection_Click(object sender, EventArgs e)
        {
            if (_source == null)
            {
                MessageBox.Show("Source environment is required", "Missing environments", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _settings.CheckedWebFiles = GetCheckedWebFiles().Select(cwf => cwf.Id).ToArray();
            SettingsManager.Instance.Save(typeof(Settings), _settings, _source.ConnectionId.ToString());
            MessageBox.Show("Settings saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_transport_Click(object sender, EventArgs e)
        {
            if (_source == null || _target == null)
            {
                MessageBox.Show("Source and target environment are required", "Missing environments", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Starting transport",
                Work = (worker, args) =>
                {
                    //0. Disable blockedattachments
                    Entity organizationE = GetOrganization(_target.GetCrmServiceClient());
                    string originalBlockedAttachements = organizationE.GetAttributeValue<string>("blockedattachments");
                    organizationE["blockedattachments"] = "";
                    _target.GetCrmServiceClient().Update(organizationE);


                    List<WebFile> errorWebFiles = new List<WebFile>();

                    List<WebFile> checkedWebFiles = GetCheckedWebFiles();
                    int progressPerWebFile = 100 / checkedWebFiles.Count();
                    int progressPerStep = progressPerWebFile / 5;
                    for (int i = 0; i < checkedWebFiles.Count; i++)
                    {
                        WebFile wf = checkedWebFiles[i];
                        try
                        {
                            int progress = i * progressPerWebFile;

                            //0. Check if webfile exists in target
                            worker.ReportProgress(progress + (progressPerStep * 0), $"Checking web file '{wf.Name}' in target");
                            Entity webFileInTarget = _target.GetCrmServiceClient().Retrieve("adx_webfile", wf.Id, new ColumnSet("adx_webfileid"));

                            //1. Create webfile in target if needed
                            if (webFileInTarget == null)
                            {
                                worker.ReportProgress(progress + (progressPerStep * 1), "Creating web file '{wf.Name}' in target");
                                Entity webFileInSource = _source.GetCrmServiceClient().Retrieve("adx_webfile", wf.Id, new ColumnSet(true));
                                webFileInSource.Attributes.Remove("owningbusinessunit");
                                webFileInSource.Attributes.Remove("createdby");
                                webFileInSource.Attributes.Remove("ownerid");
                                webFileInSource.Attributes.Remove("owninguser");
                                webFileInSource.Attributes.Remove("modifiedby");
                                _target.GetCrmServiceClient().Create(webFileInSource);
                            }

                            //2. Retrieving notes from webfile in source
                            worker.ReportProgress(progress + (progressPerStep * 2), $"Retrieving notes from web file '{wf.Name}' in source");
                            List<Entity> notesInSource = GetNotes(_source.GetCrmServiceClient(), wf.Id);


                            //3. Deleting notes from webfile in target
                            worker.ReportProgress(progress + (progressPerStep * 3), $"Deleting notes from web file '{wf.Name}' in target");
                            List<Entity> notesToDelete = GetNotes(_target.GetCrmServiceClient(), wf.Id);
                            foreach (Entity note in notesToDelete)
                            {
                                _target.GetCrmServiceClient().Delete("annotation", note.Id);
                            }

                            //4. Creating notes from source in target
                            worker.ReportProgress(progress + (progressPerStep * 4), $"Creating notes on web file '{wf.Name}' in target");
                            foreach (Entity note in notesInSource)
                            {
                                note.Attributes.Remove("owningbusinessunit");
                                note.Attributes.Remove("createdby");
                                note.Attributes.Remove("ownerid");
                                note.Attributes.Remove("owninguser");
                                note.Attributes.Remove("modifiedby");
                                _target.GetCrmServiceClient().Create(note);
                            }
                        }
                        catch (Exception ex)
                        {
                            errorWebFiles.Add(wf);
                            LogError(ex.Message);
                            //MessageBox.Show($"An error occured on web file '{wf.Name}'. An overview will be provided at the end", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    //Enable blockedattachments
                    organizationE["blockedattachments"] = originalBlockedAttachements;
                    _target.GetCrmServiceClient().Update(organizationE);

                    if (errorWebFiles.Any()) {
                        MessageBox.Show($"An error occured on following web files: {Environment.NewLine}{string.Join(Environment.NewLine, errorWebFiles.Select(wf=>wf.Name).ToArray())}{Environment.NewLine} You can run the transporter again for these files.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                },
                ProgressChanged = (progress) =>
                {
                    SetWorkingMessage(progress.UserState.ToString());
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Web files transported", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            });
        }

        private static Entity GetOrganization(IOrganizationService service)
        {
            QueryExpression queryExpression = new QueryExpression("organization")
            {
                ColumnSet = new ColumnSet("organizationid", "blockedattachments")
            };

            return service.RetrieveMultiple(queryExpression).Entities.FirstOrDefault();
        }

        private List<WebFile> GetCheckedWebFiles()
        {
            List<WebFile> checkedWebFiles = new List<WebFile>();

            for (int i = 0; i < treeView_webFiles.Nodes.Count; i++)
            {
                if (treeView_webFiles.Nodes[i].Checked)
                    checkedWebFiles.Add(treeView_webFiles.Nodes[i].Tag as WebFile);
            }

            return checkedWebFiles;
        }

        private List<Entity> GetNotes(IOrganizationService service, Guid webFileGuid)
        {
            var notesQuery = new QueryExpression("annotation")
            {
                Distinct = true,
                ColumnSet = new ColumnSet(true),
                Criteria = {
                    Conditions = {
                        new ConditionExpression("objectid", ConditionOperator.Equal, webFileGuid)
                    }
                }
            };

            return service.RetrieveMultiple(notesQuery).Entities.ToList();
        }
    }
}