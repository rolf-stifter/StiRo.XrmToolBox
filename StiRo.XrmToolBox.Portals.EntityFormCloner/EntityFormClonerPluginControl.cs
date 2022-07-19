using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;
using System.Windows.Controls;
using XrmToolBox;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using ListViewItem = System.Windows.Forms.ListViewItem;
using StiRo.XrmToolBox.Portals.Factories;
using StiRo.XrmToolBox.Portals.Models;
using XrmToolBox.Extensibility.Interfaces;

namespace StiRo.XrmToolBox.Portals.EntityFormCloner
{
    public partial class EntityFormClonerPluginControl : PluginControlBase
    {
        public EntityFormClonerPluginControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            GetEntityForms();
        }

        private void tsbLoad_Click(object sender, EventArgs e)
        {
            GetEntityForms();
        }

        private void GetEntityForms()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting entity forms",
                Work = (worker, args) =>
                {
                    args.Result = EntityFormFactory.GetActiveEntityForms(Service);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var entityForms = args.Result as List<EntityForm>;

                    if (entityForms == null)
                    {
                        return;
                    }

                    listView_entityForms.Items.Clear();
                    listView_entityForms.Items.AddRange(entityForms.Select(ef=>new ListViewItem {
                        Name = ef.Name,
                        Text = ef.Name,
                        SubItems = {ef.EntityName, ef.FormName, ef.TabName, ef.GetModeLabel()},
                        Tag = ef
                    }).ToArray());

                    columnHeader_name.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                    columnHeader_entity.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                    columnHeader_form.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                    columnHeader_tab.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                    columnHeader_mode.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            });
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Do nothing 
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);
        }

        private void listView_entityForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_entityForms.SelectedItems.Count < 1) {
                return;
            }

            EntityForm ef = listView_entityForms.SelectedItems[0].Tag as EntityForm;
            //Set source text boxes
            textBox_sourceName.Text = ef.Name;
            textBox_sourceEntity.Text = ef.EntityName;
            textBox_sourceFormName.Text = ef.FormName;
            textBox_sourceTabName.Text = ef.TabName;
            textBox_sourceMode.Text = ef.GetModeLabel();

            //Set target text boxes
            textBox_targetName.Text = $"(COPY) {ef.Name}";
            textBox_targetEntity.Text = ef.EntityName;
            textBox_targetFormName.Text = ef.FormName;
            textBox_targetTabName.Text = ef.TabName;
            comboBox_targetMode.SelectedIndex = ((int)ef.Mode) - 100000000;

        }

        private void button_Clone_Click(object sender, EventArgs e)
        {
            if (listView_entityForms.SelectedItems.Count < 1)
            {
                MessageBox.Show("Please select an entity form first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EntityForm sourceEF = listView_entityForms.SelectedItems[0].Tag as EntityForm;
            string targetName = textBox_targetName.Text;
            Mode targetMode = (Mode)(comboBox_targetMode.SelectedIndex + 100000000);

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Cloning Entity Form",

                Work = (worker, args) =>
                {
                    //Create copy
                    Entity targetEntityForm = Service.Retrieve("adx_entityform", sourceEF.Id, new ColumnSet(true));
                    targetEntityForm.Id = Guid.Empty;
                    targetEntityForm.Attributes.Remove("adx_entityformid");
                    targetEntityForm["adx_name"] = targetName;
                    targetEntityForm["adx_mode"] = new OptionSetValue((int)targetMode);
                    targetEntityForm.Id = Service.Create(targetEntityForm);

                    List<EntityFormMetadata> entityFormMetadatas = EntityFormMetadataFactory.GetEntityFormMetadataFromEntityForm(Service, sourceEF);

                    foreach (EntityFormMetadata entityFormMetadata in entityFormMetadatas)
                    {
                        entityFormMetadata.Entity.Id = Guid.Empty;
                        entityFormMetadata.Entity.Attributes.Remove("adx_entityformmetadataid");
                        entityFormMetadata.Entity["adx_entityform"] = new EntityReference("adx_entityform", targetEntityForm.Id);

                        var stateCode = entityFormMetadata.Entity.GetAttributeValue<OptionSetValue>("statecode");
                        var statusCode = entityFormMetadata.Entity.GetAttributeValue<OptionSetValue>("statuscode");

                        entityFormMetadata.Entity.Attributes.Remove("statecode");
                        entityFormMetadata.Entity.Attributes.Remove("statuscode");

                        entityFormMetadata.Entity.Id = Service.Create(entityFormMetadata.Entity);

                        entityFormMetadata.Entity["statecode"] = stateCode;
                        entityFormMetadata.Entity["statuscode"] = statusCode;

                        Service.Update(entityFormMetadata.Entity);
                    }
                },
                PostWorkCallBack = (args) =>
                {
                    //Do nothing
                }
            });
        }
    }
}