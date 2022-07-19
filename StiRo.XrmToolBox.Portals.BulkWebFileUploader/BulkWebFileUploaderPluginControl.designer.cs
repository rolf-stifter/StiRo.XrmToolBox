
namespace StiRo.XrmToolBox.Portals.BulkWebFileUploader
{
    partial class BulkWebFileUploaderPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripButton_refreshParameters = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_websites = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_webPages = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_publishingStates = new System.Windows.Forms.ComboBox();
            this.groupBox_files = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_addFiles = new System.Windows.Forms.Button();
            this.listView_files = new System.Windows.Forms.ListView();
            this.columnHeader_fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_upload = new System.Windows.Forms.Button();
            this.checkBox_selectAll = new System.Windows.Forms.CheckBox();
            this.toolStripMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox_files.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripButton_refreshParameters
            // 
            this.toolStripButton_refreshParameters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_refreshParameters.Name = "toolStripButton_refreshParameters";
            this.toolStripButton_refreshParameters.Size = new System.Drawing.Size(112, 22);
            this.toolStripButton_refreshParameters.Text = "Refresh parameters";
            this.toolStripButton_refreshParameters.Click += new System.EventHandler(this.toolStripButton_refreshParameters_Click);
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_refreshParameters});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(559, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_files, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_upload, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 541);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_websites, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_webPages, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_publishingStates, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(547, 81);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Website:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_websites
            // 
            this.comboBox_websites.DisplayMember = "Name";
            this.comboBox_websites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_websites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_websites.FormattingEnabled = true;
            this.comboBox_websites.Location = new System.Drawing.Point(93, 3);
            this.comboBox_websites.Name = "comboBox_websites";
            this.comboBox_websites.Size = new System.Drawing.Size(451, 21);
            this.comboBox_websites.TabIndex = 1;
            this.comboBox_websites.SelectedValueChanged += new System.EventHandler(this.comboBox_websites_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parent page:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_webPages
            // 
            this.comboBox_webPages.DisplayMember = "Name";
            this.comboBox_webPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_webPages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_webPages.FormattingEnabled = true;
            this.comboBox_webPages.Location = new System.Drawing.Point(93, 30);
            this.comboBox_webPages.Name = "comboBox_webPages";
            this.comboBox_webPages.Size = new System.Drawing.Size(451, 21);
            this.comboBox_webPages.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Publishing state:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_publishingStates
            // 
            this.comboBox_publishingStates.DisplayMember = "Name";
            this.comboBox_publishingStates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_publishingStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_publishingStates.FormattingEnabled = true;
            this.comboBox_publishingStates.Location = new System.Drawing.Point(93, 57);
            this.comboBox_publishingStates.Name = "comboBox_publishingStates";
            this.comboBox_publishingStates.Size = new System.Drawing.Size(451, 21);
            this.comboBox_publishingStates.TabIndex = 5;
            // 
            // groupBox_files
            // 
            this.groupBox_files.Controls.Add(this.tableLayoutPanel3);
            this.groupBox_files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_files.Location = new System.Drawing.Point(3, 109);
            this.groupBox_files.Name = "groupBox_files";
            this.groupBox_files.Size = new System.Drawing.Size(553, 400);
            this.groupBox_files.TabIndex = 1;
            this.groupBox_files.TabStop = false;
            this.groupBox_files.Text = "Files";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button_addFiles, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.listView_files, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.checkBox_selectAll, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(547, 381);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // button_addFiles
            // 
            this.button_addFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_addFiles.Location = new System.Drawing.Point(3, 3);
            this.button_addFiles.Name = "button_addFiles";
            this.button_addFiles.Size = new System.Drawing.Size(267, 23);
            this.button_addFiles.TabIndex = 2;
            this.button_addFiles.Text = "Add files";
            this.button_addFiles.UseVisualStyleBackColor = true;
            this.button_addFiles.Click += new System.EventHandler(this.button_addFiles_Click);
            // 
            // listView_files
            // 
            this.listView_files.CheckBoxes = true;
            this.listView_files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_fileName});
            this.tableLayoutPanel3.SetColumnSpan(this.listView_files, 2);
            this.listView_files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_files.FullRowSelect = true;
            this.listView_files.HideSelection = false;
            this.listView_files.Location = new System.Drawing.Point(3, 32);
            this.listView_files.MultiSelect = false;
            this.listView_files.Name = "listView_files";
            this.listView_files.Size = new System.Drawing.Size(541, 346);
            this.listView_files.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_files.TabIndex = 3;
            this.listView_files.UseCompatibleStateImageBehavior = false;
            this.listView_files.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_fileName
            // 
            this.columnHeader_fileName.Text = "File name";
            this.columnHeader_fileName.Width = 537;
            // 
            // button_upload
            // 
            this.button_upload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_upload.Location = new System.Drawing.Point(3, 515);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(553, 23);
            this.button_upload.TabIndex = 2;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // checkBox_selectAll
            // 
            this.checkBox_selectAll.AutoSize = true;
            this.checkBox_selectAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_selectAll.Checked = true;
            this.checkBox_selectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_selectAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox_selectAll.Location = new System.Drawing.Point(475, 3);
            this.checkBox_selectAll.Name = "checkBox_selectAll";
            this.checkBox_selectAll.Size = new System.Drawing.Size(69, 23);
            this.checkBox_selectAll.TabIndex = 4;
            this.checkBox_selectAll.Text = "Select all";
            this.checkBox_selectAll.UseVisualStyleBackColor = true;
            this.checkBox_selectAll.CheckStateChanged += new System.EventHandler(this.checkBox_selectAll_CheckStateChanged);
            // 
            // BulkWebFileUploaderPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "BulkWebFileUploaderPluginControl";
            this.Size = new System.Drawing.Size(559, 566);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox_files.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton toolStripButton_refreshParameters;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_websites;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_webPages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_publishingStates;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.GroupBox groupBox_files;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_addFiles;
        private System.Windows.Forms.ListView listView_files;
        private System.Windows.Forms.ColumnHeader columnHeader_fileName;
        private System.Windows.Forms.CheckBox checkBox_selectAll;
    }
}
