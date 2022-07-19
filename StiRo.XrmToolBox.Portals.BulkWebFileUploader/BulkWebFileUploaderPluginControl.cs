using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using StiRo.XrmToolBox.Portals.Factories;
using StiRo.XrmToolBox.Portals.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace StiRo.XrmToolBox.Portals.BulkWebFileUploader
{
    public partial class BulkWebFileUploaderPluginControl : PluginControlBase
    {
        private List<Website> _websites;

        public BulkWebFileUploaderPluginControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            ExecuteMethod(GetParameters);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void GetParameters()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting websites",
                Work = (worker, args) =>
                {
                    List<Website> websites = WebsiteFactory.GetActiveWebsites(Service).Select(w =>
                    {
                        w.WebPages = WebPageFactory.GetActiveWebPagesByWebsite(Service, w);
                        w.PublishingStates = PublishingStateFactory.GetActivePublishingStatesByWebsite(Service, w);
                        return w;
                    }).ToList();

                    args.Result = websites;
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    _websites = args.Result as List<Website>;
                    comboBox_websites.DataSource = _websites;
                }
            });
        }

        private void UploadDocuments()
        {
            List<string> filesToUpload = new List<string>();
            foreach (ListViewItem lvi in listView_files.Items)
            {
                if (lvi.Checked == true)
                    filesToUpload.Add(lvi.Name);
            }

            Website selectedWebsite = (comboBox_websites.SelectedItem as Website);
            WebPage selectedWebPage = (comboBox_webPages.SelectedItem as WebPage);
            PublishingState selectedPublishingState = (comboBox_publishingStates.SelectedItem as PublishingState);

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Checking system settings",
                Work = (worker, args) =>
                {
                    //Checking system settings
                    string[] distenctExtensions = filesToUpload.Select(file => new FileInfo(file).Extension.Replace(".", "")).Distinct().ToArray();
                    long maxFileSize = filesToUpload.Max(file => new FileInfo(file).Length);

                    Organization org = OrganizationFactory.GetOrganization(Service);

                    Entity newOrgSettings = new Entity("organization");
                    newOrgSettings.Id = org.Id;
                    if (distenctExtensions.Intersect(org.BlockedAttachments).Count() > 0)
                    {
                        newOrgSettings["blockedattachments"] = string.Join(";", org.BlockedAttachments.Except(distenctExtensions).ToArray());
                    }
                    if (org.MaxUploadFileSize < maxFileSize)
                        newOrgSettings["maxuploadfilesize"] = maxFileSize;
                    if (newOrgSettings.Attributes.Count > 0)
                        Service.Update(newOrgSettings);



                    //Creating webfiles
                    foreach (string file in filesToUpload)
                    {
                        WebFile webFile = new WebFile()
                        {
                            Name = Path.GetFileName(file),
                            Website = selectedWebsite,
                            ParentPage = selectedWebPage,
                            PublishingState = selectedPublishingState,
                            PartialURL = Path.GetFileName(file)
                        };

                        webFile.Id = WebFileFactory.CreateWebFile(Service, webFile);

                        Annotation note = new Annotation()
                        {
                            Subject = Path.GetFileName(file),
                            FileName = Path.GetFileName(file),
                            DocumentBody = Convert.ToBase64String(File.ReadAllBytes(file)),
                            Regarding = webFile,
                            MimeType = GetMimeTypeFromFileName(file)
                        };

                        note.Id = AnnotationFactory.CreateAnnotation(Service, note);
                    }

                    //Restoring system settings
                    if (newOrgSettings.Attributes.Count > 0)
                    {
                        newOrgSettings["blockedattachments"] = string.Join(";", org.BlockedAttachments);
                        newOrgSettings["maxuploadfilesize"] = org.MaxUploadFileSize;
                        Service.Update(newOrgSettings);
                    }
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            });
        }

        private string GetMimeTypeFromFileName(string file) {
            string mimeType = "application/octet-stream";

            switch (new FileInfo(file).Extension) {
                case ".css": mimeType = "text/css"; break;
                case ".eot": mimeType = "application/vnd.ms-fontobject"; break;
                case ".gif": mimeType = "image/gif"; break;
                case ".htm": mimeType = "text/html"; break;
                case ".html": mimeType = "text/html"; break;
                case ".ico": mimeType = "image/x-icon"; break;
                case ".jpeg": mimeType = "image/jpeg"; break;
                case ".jpg": mimeType = "image/jpeg"; break;
                case ".js": mimeType = "application/javascript"; break;
                case ".json": mimeType = "application/json"; break;
                case ".otf": mimeType = "font/otf"; break;
                case ".png": mimeType = "image/png"; break;
                case ".svg": mimeType = "image/svg+xml"; break;
                case ".ttf": mimeType = "font/ttf"; break;
                case ".woff": mimeType = "font/woff"; break;
            }

            return mimeType;
        }

        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {

        }

        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);
        }

        private void toolStripButton_refreshParameters_Click(object sender, EventArgs e)
        {
            ExecuteMethod(GetParameters);
        }

        private void comboBox_websites_SelectedValueChanged(object sender, EventArgs e)
        {
            Website selectedWebsite = (comboBox_websites.SelectedItem as Website);
            comboBox_webPages.DataSource = selectedWebsite.WebPages;
            comboBox_publishingStates.DataSource = selectedWebsite.PublishingStates;
        }

        private void button_addFiles_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileNames.Length > 0)
                {
                    string directory = Path.GetDirectoryName(openFileDialog.FileNames.FirstOrDefault());
                    ListViewGroup group = listView_files.Groups[directory];
                    if (group == null)
                    {
                        group = new ListViewGroup(directory) { Name = directory };
                        listView_files.Groups.Add(group);
                    }

                    string[] filesToAdd = openFileDialog.FileNames.Where(file => listView_files.Items[file] == null).ToArray();

                    listView_files.Items.AddRange(filesToAdd.Select(file => new ListViewItem()
                    {
                        Name = file,
                        Text = Path.GetFileName(file),
                        Group = group,
                        Checked = true
                    }).ToArray());
                }
            }
        }

        private void checkBox_selectAll_CheckStateChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView_files.Items)
                lvi.Checked = checkBox_selectAll.Checked;
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            ExecuteMethod(UploadDocuments);
        }
    }
}