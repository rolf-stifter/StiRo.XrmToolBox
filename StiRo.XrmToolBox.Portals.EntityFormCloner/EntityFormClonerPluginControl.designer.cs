namespace StiRo.XrmToolBox.Portals.EntityFormCloner
{
    partial class EntityFormClonerPluginControl
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
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbLoad = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_entityForms = new System.Windows.Forms.GroupBox();
            this.listView_entityForms = new System.Windows.Forms.ListView();
            this.columnHeader_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_entity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_form = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_tab = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_mode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_Clone = new System.Windows.Forms.Button();
            this.groupBox_target = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_targetName = new System.Windows.Forms.TextBox();
            this.label_targetName = new System.Windows.Forms.Label();
            this.label_targetEntity = new System.Windows.Forms.Label();
            this.textBox_targetEntity = new System.Windows.Forms.TextBox();
            this.label_targetFormName = new System.Windows.Forms.Label();
            this.textBox_targetFormName = new System.Windows.Forms.TextBox();
            this.label_targetTabName = new System.Windows.Forms.Label();
            this.textBox_targetTabName = new System.Windows.Forms.TextBox();
            this.label_targetMode = new System.Windows.Forms.Label();
            this.comboBox_targetMode = new System.Windows.Forms.ComboBox();
            this.groupBox_source = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_sourceName = new System.Windows.Forms.TextBox();
            this.label_sourceName = new System.Windows.Forms.Label();
            this.label_sourceEntity = new System.Windows.Forms.Label();
            this.textBox_sourceEntity = new System.Windows.Forms.TextBox();
            this.label_sourceFormName = new System.Windows.Forms.Label();
            this.textBox_sourceFormName = new System.Windows.Forms.TextBox();
            this.label_sourceTabName = new System.Windows.Forms.Label();
            this.textBox_sourceTabName = new System.Windows.Forms.TextBox();
            this.label_sourceMode = new System.Windows.Forms.Label();
            this.textBox_sourceMode = new System.Windows.Forms.TextBox();
            this.groupBox_options = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_includeMetadata = new System.Windows.Forms.Label();
            this.checkBox_includeMetadata = new System.Windows.Forms.CheckBox();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_entityForms.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_target.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox_source.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox_options.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoad});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenu.Size = new System.Drawing.Size(600, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbLoad
            // 
            this.tsbLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLoad.Name = "tsbLoad";
            this.tsbLoad.Size = new System.Drawing.Size(106, 22);
            this.tsbLoad.Text = "Load Entity Forms";
            this.tsbLoad.Click += new System.EventHandler(this.tsbLoad_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_entityForms);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.AutoScrollMinSize = new System.Drawing.Size(0, 385);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(600, 475);
            this.splitContainer1.SplitterDistance = 322;
            this.splitContainer1.TabIndex = 5;
            // 
            // groupBox_entityForms
            // 
            this.groupBox_entityForms.Controls.Add(this.listView_entityForms);
            this.groupBox_entityForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_entityForms.Location = new System.Drawing.Point(0, 0);
            this.groupBox_entityForms.Name = "groupBox_entityForms";
            this.groupBox_entityForms.Size = new System.Drawing.Size(322, 475);
            this.groupBox_entityForms.TabIndex = 6;
            this.groupBox_entityForms.TabStop = false;
            this.groupBox_entityForms.Text = "Entity forms";
            // 
            // listView_entityForms
            // 
            this.listView_entityForms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_name,
            this.columnHeader_entity,
            this.columnHeader_form,
            this.columnHeader_tab,
            this.columnHeader_mode});
            this.listView_entityForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_entityForms.FullRowSelect = true;
            this.listView_entityForms.HideSelection = false;
            this.listView_entityForms.Location = new System.Drawing.Point(3, 16);
            this.listView_entityForms.MultiSelect = false;
            this.listView_entityForms.Name = "listView_entityForms";
            this.listView_entityForms.Size = new System.Drawing.Size(316, 456);
            this.listView_entityForms.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_entityForms.TabIndex = 3;
            this.listView_entityForms.UseCompatibleStateImageBehavior = false;
            this.listView_entityForms.View = System.Windows.Forms.View.Details;
            this.listView_entityForms.SelectedIndexChanged += new System.EventHandler(this.listView_entityForms_SelectedIndexChanged);
            // 
            // columnHeader_name
            // 
            this.columnHeader_name.Text = "Name";
            this.columnHeader_name.Width = 40;
            // 
            // columnHeader_entity
            // 
            this.columnHeader_entity.Text = "Entity";
            this.columnHeader_entity.Width = 38;
            // 
            // columnHeader_form
            // 
            this.columnHeader_form.Text = "Form name";
            this.columnHeader_form.Width = 64;
            // 
            // columnHeader_tab
            // 
            this.columnHeader_tab.Text = "Tab name";
            // 
            // columnHeader_mode
            // 
            this.columnHeader_mode.Text = "Mode";
            this.columnHeader_mode.Width = 67;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button_Clone, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_target, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_source, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_options, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(274, 475);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button_Clone
            // 
            this.button_Clone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Clone.Location = new System.Drawing.Point(3, 449);
            this.button_Clone.Name = "button_Clone";
            this.button_Clone.Size = new System.Drawing.Size(268, 23);
            this.button_Clone.TabIndex = 9;
            this.button_Clone.Text = "Clone";
            this.button_Clone.UseVisualStyleBackColor = true;
            this.button_Clone.Click += new System.EventHandler(this.button_Clone_Click);
            // 
            // groupBox_target
            // 
            this.groupBox_target.Controls.Add(this.tableLayoutPanel4);
            this.groupBox_target.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_target.Location = new System.Drawing.Point(3, 158);
            this.groupBox_target.Name = "groupBox_target";
            this.groupBox_target.Size = new System.Drawing.Size(268, 150);
            this.groupBox_target.TabIndex = 6;
            this.groupBox_target.TabStop = false;
            this.groupBox_target.Text = "Target";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.textBox_targetName, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label_targetName, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label_targetEntity, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBox_targetEntity, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label_targetFormName, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.textBox_targetFormName, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label_targetTabName, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.textBox_targetTabName, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label_targetMode, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.comboBox_targetMode, 1, 4);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(262, 131);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // textBox_targetName
            // 
            this.textBox_targetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_targetName.Location = new System.Drawing.Point(71, 3);
            this.textBox_targetName.Name = "textBox_targetName";
            this.textBox_targetName.Size = new System.Drawing.Size(188, 20);
            this.textBox_targetName.TabIndex = 2;
            // 
            // label_targetName
            // 
            this.label_targetName.AutoSize = true;
            this.label_targetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_targetName.Location = new System.Drawing.Point(3, 0);
            this.label_targetName.Name = "label_targetName";
            this.label_targetName.Size = new System.Drawing.Size(62, 26);
            this.label_targetName.TabIndex = 1;
            this.label_targetName.Text = "Name:";
            this.label_targetName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_targetEntity
            // 
            this.label_targetEntity.AutoSize = true;
            this.label_targetEntity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_targetEntity.Location = new System.Drawing.Point(3, 26);
            this.label_targetEntity.Name = "label_targetEntity";
            this.label_targetEntity.Size = new System.Drawing.Size(62, 26);
            this.label_targetEntity.TabIndex = 3;
            this.label_targetEntity.Text = "Entity:";
            this.label_targetEntity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_targetEntity
            // 
            this.textBox_targetEntity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_targetEntity.Location = new System.Drawing.Point(71, 29);
            this.textBox_targetEntity.Name = "textBox_targetEntity";
            this.textBox_targetEntity.ReadOnly = true;
            this.textBox_targetEntity.Size = new System.Drawing.Size(188, 20);
            this.textBox_targetEntity.TabIndex = 4;
            // 
            // label_targetFormName
            // 
            this.label_targetFormName.AutoSize = true;
            this.label_targetFormName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_targetFormName.Location = new System.Drawing.Point(3, 52);
            this.label_targetFormName.Name = "label_targetFormName";
            this.label_targetFormName.Size = new System.Drawing.Size(62, 26);
            this.label_targetFormName.TabIndex = 5;
            this.label_targetFormName.Text = "Form name:";
            this.label_targetFormName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_targetFormName
            // 
            this.textBox_targetFormName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_targetFormName.Location = new System.Drawing.Point(71, 55);
            this.textBox_targetFormName.Name = "textBox_targetFormName";
            this.textBox_targetFormName.ReadOnly = true;
            this.textBox_targetFormName.Size = new System.Drawing.Size(188, 20);
            this.textBox_targetFormName.TabIndex = 6;
            // 
            // label_targetTabName
            // 
            this.label_targetTabName.AutoSize = true;
            this.label_targetTabName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_targetTabName.Location = new System.Drawing.Point(3, 78);
            this.label_targetTabName.Name = "label_targetTabName";
            this.label_targetTabName.Size = new System.Drawing.Size(62, 26);
            this.label_targetTabName.TabIndex = 7;
            this.label_targetTabName.Text = "Tab name:";
            this.label_targetTabName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_targetTabName
            // 
            this.textBox_targetTabName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_targetTabName.Location = new System.Drawing.Point(71, 81);
            this.textBox_targetTabName.Name = "textBox_targetTabName";
            this.textBox_targetTabName.ReadOnly = true;
            this.textBox_targetTabName.Size = new System.Drawing.Size(188, 20);
            this.textBox_targetTabName.TabIndex = 8;
            // 
            // label_targetMode
            // 
            this.label_targetMode.AutoSize = true;
            this.label_targetMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_targetMode.Location = new System.Drawing.Point(3, 104);
            this.label_targetMode.Name = "label_targetMode";
            this.label_targetMode.Size = new System.Drawing.Size(62, 27);
            this.label_targetMode.TabIndex = 9;
            this.label_targetMode.Text = "Mode";
            this.label_targetMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_targetMode
            // 
            this.comboBox_targetMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_targetMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_targetMode.FormattingEnabled = true;
            this.comboBox_targetMode.Items.AddRange(new object[] {
            "Insert",
            "Edit",
            "ReadOnly"});
            this.comboBox_targetMode.Location = new System.Drawing.Point(71, 107);
            this.comboBox_targetMode.Name = "comboBox_targetMode";
            this.comboBox_targetMode.Size = new System.Drawing.Size(188, 21);
            this.comboBox_targetMode.TabIndex = 10;
            // 
            // groupBox_source
            // 
            this.groupBox_source.Controls.Add(this.tableLayoutPanel3);
            this.groupBox_source.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_source.Location = new System.Drawing.Point(3, 3);
            this.groupBox_source.Name = "groupBox_source";
            this.groupBox_source.Size = new System.Drawing.Size(268, 149);
            this.groupBox_source.TabIndex = 5;
            this.groupBox_source.TabStop = false;
            this.groupBox_source.Text = "Source";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.textBox_sourceName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_sourceName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_sourceEntity, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox_sourceEntity, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label_sourceFormName, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBox_sourceFormName, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label_sourceTabName, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBox_sourceTabName, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label_sourceMode, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.textBox_sourceMode, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(262, 130);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox_sourceName
            // 
            this.textBox_sourceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_sourceName.Location = new System.Drawing.Point(71, 3);
            this.textBox_sourceName.Name = "textBox_sourceName";
            this.textBox_sourceName.ReadOnly = true;
            this.textBox_sourceName.Size = new System.Drawing.Size(188, 20);
            this.textBox_sourceName.TabIndex = 2;
            // 
            // label_sourceName
            // 
            this.label_sourceName.AutoSize = true;
            this.label_sourceName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_sourceName.Location = new System.Drawing.Point(3, 0);
            this.label_sourceName.Name = "label_sourceName";
            this.label_sourceName.Size = new System.Drawing.Size(62, 26);
            this.label_sourceName.TabIndex = 1;
            this.label_sourceName.Text = "Name:";
            this.label_sourceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_sourceEntity
            // 
            this.label_sourceEntity.AutoSize = true;
            this.label_sourceEntity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_sourceEntity.Location = new System.Drawing.Point(3, 26);
            this.label_sourceEntity.Name = "label_sourceEntity";
            this.label_sourceEntity.Size = new System.Drawing.Size(62, 26);
            this.label_sourceEntity.TabIndex = 3;
            this.label_sourceEntity.Text = "Entity:";
            this.label_sourceEntity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_sourceEntity
            // 
            this.textBox_sourceEntity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_sourceEntity.Location = new System.Drawing.Point(71, 29);
            this.textBox_sourceEntity.Name = "textBox_sourceEntity";
            this.textBox_sourceEntity.ReadOnly = true;
            this.textBox_sourceEntity.Size = new System.Drawing.Size(188, 20);
            this.textBox_sourceEntity.TabIndex = 4;
            // 
            // label_sourceFormName
            // 
            this.label_sourceFormName.AutoSize = true;
            this.label_sourceFormName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_sourceFormName.Location = new System.Drawing.Point(3, 52);
            this.label_sourceFormName.Name = "label_sourceFormName";
            this.label_sourceFormName.Size = new System.Drawing.Size(62, 26);
            this.label_sourceFormName.TabIndex = 5;
            this.label_sourceFormName.Text = "Form name:";
            this.label_sourceFormName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_sourceFormName
            // 
            this.textBox_sourceFormName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_sourceFormName.Location = new System.Drawing.Point(71, 55);
            this.textBox_sourceFormName.Name = "textBox_sourceFormName";
            this.textBox_sourceFormName.ReadOnly = true;
            this.textBox_sourceFormName.Size = new System.Drawing.Size(188, 20);
            this.textBox_sourceFormName.TabIndex = 6;
            // 
            // label_sourceTabName
            // 
            this.label_sourceTabName.AutoSize = true;
            this.label_sourceTabName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_sourceTabName.Location = new System.Drawing.Point(3, 78);
            this.label_sourceTabName.Name = "label_sourceTabName";
            this.label_sourceTabName.Size = new System.Drawing.Size(62, 26);
            this.label_sourceTabName.TabIndex = 7;
            this.label_sourceTabName.Text = "Tab name:";
            this.label_sourceTabName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_sourceTabName
            // 
            this.textBox_sourceTabName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_sourceTabName.Location = new System.Drawing.Point(71, 81);
            this.textBox_sourceTabName.Name = "textBox_sourceTabName";
            this.textBox_sourceTabName.ReadOnly = true;
            this.textBox_sourceTabName.Size = new System.Drawing.Size(188, 20);
            this.textBox_sourceTabName.TabIndex = 8;
            // 
            // label_sourceMode
            // 
            this.label_sourceMode.AutoSize = true;
            this.label_sourceMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_sourceMode.Location = new System.Drawing.Point(3, 104);
            this.label_sourceMode.Name = "label_sourceMode";
            this.label_sourceMode.Size = new System.Drawing.Size(62, 26);
            this.label_sourceMode.TabIndex = 9;
            this.label_sourceMode.Text = "Mode:";
            this.label_sourceMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_sourceMode
            // 
            this.textBox_sourceMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_sourceMode.Location = new System.Drawing.Point(71, 107);
            this.textBox_sourceMode.Name = "textBox_sourceMode";
            this.textBox_sourceMode.ReadOnly = true;
            this.textBox_sourceMode.Size = new System.Drawing.Size(188, 20);
            this.textBox_sourceMode.TabIndex = 10;
            // 
            // groupBox_options
            // 
            this.groupBox_options.AutoSize = true;
            this.groupBox_options.Controls.Add(this.tableLayoutPanel2);
            this.groupBox_options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_options.Location = new System.Drawing.Point(3, 314);
            this.groupBox_options.Name = "groupBox_options";
            this.groupBox_options.Size = new System.Drawing.Size(268, 39);
            this.groupBox_options.TabIndex = 10;
            this.groupBox_options.TabStop = false;
            this.groupBox_options.Text = "Options";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label_includeMetadata, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBox_includeMetadata, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(262, 20);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label_includeMetadata
            // 
            this.label_includeMetadata.AutoSize = true;
            this.label_includeMetadata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_includeMetadata.Location = new System.Drawing.Point(3, 0);
            this.label_includeMetadata.Name = "label_includeMetadata";
            this.label_includeMetadata.Size = new System.Drawing.Size(93, 20);
            this.label_includeMetadata.TabIndex = 1;
            this.label_includeMetadata.Text = "Include Metadata:";
            this.label_includeMetadata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox_includeMetadata
            // 
            this.checkBox_includeMetadata.AutoSize = true;
            this.checkBox_includeMetadata.Checked = true;
            this.checkBox_includeMetadata.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_includeMetadata.Location = new System.Drawing.Point(102, 3);
            this.checkBox_includeMetadata.Name = "checkBox_includeMetadata";
            this.checkBox_includeMetadata.Size = new System.Drawing.Size(15, 14);
            this.checkBox_includeMetadata.TabIndex = 2;
            this.checkBox_includeMetadata.UseVisualStyleBackColor = true;
            // 
            // EntityFormClonerPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "EntityFormClonerPluginControl";
            this.Size = new System.Drawing.Size(600, 500);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_entityForms.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox_target.ResumeLayout(false);
            this.groupBox_target.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox_source.ResumeLayout(false);
            this.groupBox_source.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBox_options.ResumeLayout(false);
            this.groupBox_options.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbLoad;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox_entityForms;
        private System.Windows.Forms.ListView listView_entityForms;
        private System.Windows.Forms.ColumnHeader columnHeader_name;
        private System.Windows.Forms.ColumnHeader columnHeader_entity;
        private System.Windows.Forms.ColumnHeader columnHeader_form;
        private System.Windows.Forms.ColumnHeader columnHeader_tab;
        private System.Windows.Forms.ColumnHeader columnHeader_mode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_Clone;
        private System.Windows.Forms.GroupBox groupBox_target;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox textBox_targetName;
        private System.Windows.Forms.Label label_targetName;
        private System.Windows.Forms.Label label_targetEntity;
        private System.Windows.Forms.TextBox textBox_targetEntity;
        private System.Windows.Forms.Label label_targetFormName;
        private System.Windows.Forms.TextBox textBox_targetFormName;
        private System.Windows.Forms.Label label_targetTabName;
        private System.Windows.Forms.TextBox textBox_targetTabName;
        private System.Windows.Forms.Label label_targetMode;
        private System.Windows.Forms.ComboBox comboBox_targetMode;
        private System.Windows.Forms.GroupBox groupBox_source;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox_sourceName;
        private System.Windows.Forms.Label label_sourceName;
        private System.Windows.Forms.Label label_sourceEntity;
        private System.Windows.Forms.TextBox textBox_sourceEntity;
        private System.Windows.Forms.Label label_sourceFormName;
        private System.Windows.Forms.TextBox textBox_sourceFormName;
        private System.Windows.Forms.Label label_sourceTabName;
        private System.Windows.Forms.TextBox textBox_sourceTabName;
        private System.Windows.Forms.Label label_sourceMode;
        private System.Windows.Forms.TextBox textBox_sourceMode;
        private System.Windows.Forms.GroupBox groupBox_options;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_includeMetadata;
        private System.Windows.Forms.CheckBox checkBox_includeMetadata;
    }
}
