namespace StiRo.XrmToolBox.Portals.EasyWebFileTransporter
{
    partial class EasyWebFileTransporterPluginControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView_webFiles = new System.Windows.Forms.TreeView();
            this.groupBox_environments = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_sourceEnvironment = new System.Windows.Forms.TextBox();
            this.textBox_targetEnvironment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_selectTargetEnvironment = new System.Windows.Forms.Button();
            this.button_saveSelection = new System.Windows.Forms.Button();
            this.button_transport = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox_environments.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.treeView_webFiles, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox_environments, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_saveSelection, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_transport, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 300);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // treeView_webFiles
            // 
            this.treeView_webFiles.CheckBoxes = true;
            this.tableLayoutPanel1.SetColumnSpan(this.treeView_webFiles, 2);
            this.treeView_webFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_webFiles.Location = new System.Drawing.Point(3, 83);
            this.treeView_webFiles.Name = "treeView_webFiles";
            this.treeView_webFiles.Size = new System.Drawing.Size(553, 185);
            this.treeView_webFiles.TabIndex = 1;
            // 
            // groupBox_environments
            // 
            this.groupBox_environments.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox_environments, 2);
            this.groupBox_environments.Controls.Add(this.tableLayoutPanel2);
            this.groupBox_environments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_environments.Location = new System.Drawing.Point(3, 3);
            this.groupBox_environments.Name = "groupBox_environments";
            this.groupBox_environments.Size = new System.Drawing.Size(553, 74);
            this.groupBox_environments.TabIndex = 1;
            this.groupBox_environments.TabStop = false;
            this.groupBox_environments.Text = "Environments";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_sourceEnvironment, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_targetEnvironment, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_selectTargetEnvironment, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(547, 55);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_sourceEnvironment
            // 
            this.textBox_sourceEnvironment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_sourceEnvironment.Location = new System.Drawing.Point(56, 3);
            this.textBox_sourceEnvironment.Name = "textBox_sourceEnvironment";
            this.textBox_sourceEnvironment.ReadOnly = true;
            this.textBox_sourceEnvironment.Size = new System.Drawing.Size(407, 20);
            this.textBox_sourceEnvironment.TabIndex = 1;
            // 
            // textBox_targetEnvironment
            // 
            this.textBox_targetEnvironment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_targetEnvironment.Location = new System.Drawing.Point(56, 29);
            this.textBox_targetEnvironment.Name = "textBox_targetEnvironment";
            this.textBox_targetEnvironment.ReadOnly = true;
            this.textBox_targetEnvironment.Size = new System.Drawing.Size(407, 20);
            this.textBox_targetEnvironment.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_selectTargetEnvironment
            // 
            this.button_selectTargetEnvironment.Location = new System.Drawing.Point(469, 29);
            this.button_selectTargetEnvironment.Name = "button_selectTargetEnvironment";
            this.button_selectTargetEnvironment.Size = new System.Drawing.Size(75, 23);
            this.button_selectTargetEnvironment.TabIndex = 4;
            this.button_selectTargetEnvironment.Text = "Select";
            this.button_selectTargetEnvironment.UseVisualStyleBackColor = true;
            this.button_selectTargetEnvironment.Click += new System.EventHandler(this.button_selectTargetEnvironment_Click);
            // 
            // button_saveSelection
            // 
            this.button_saveSelection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_saveSelection.Location = new System.Drawing.Point(3, 274);
            this.button_saveSelection.Name = "button_saveSelection";
            this.button_saveSelection.Size = new System.Drawing.Size(273, 23);
            this.button_saveSelection.TabIndex = 2;
            this.button_saveSelection.Text = "Save selection";
            this.button_saveSelection.UseVisualStyleBackColor = true;
            this.button_saveSelection.Click += new System.EventHandler(this.button_saveSelection_Click);
            // 
            // button_transport
            // 
            this.button_transport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_transport.Location = new System.Drawing.Point(282, 274);
            this.button_transport.Name = "button_transport";
            this.button_transport.Size = new System.Drawing.Size(274, 23);
            this.button_transport.TabIndex = 3;
            this.button_transport.Text = "Transport";
            this.button_transport.UseVisualStyleBackColor = true;
            this.button_transport.Click += new System.EventHandler(this.button_transport_Click);
            // 
            // EasyWebFileTransporterPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EasyWebFileTransporterPluginControl";
            this.Size = new System.Drawing.Size(559, 300);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox_environments.ResumeLayout(false);
            this.groupBox_environments.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox_environments;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_sourceEnvironment;
        private System.Windows.Forms.TextBox textBox_targetEnvironment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_selectTargetEnvironment;
        private System.Windows.Forms.TreeView treeView_webFiles;
        private System.Windows.Forms.Button button_saveSelection;
        private System.Windows.Forms.Button button_transport;
    }
}
