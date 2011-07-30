namespace AJGenesis.UI
{
    partial class frmAJGenesisUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAJGenesisUI));
            this.cboStringConnections = new System.Windows.Forms.ComboBox();
            this.txtAPPFolderName = new System.Windows.Forms.TextBox();
            this.btnGetFolder = new System.Windows.Forms.Button();
            this.lblConections = new System.Windows.Forms.Label();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.gvTableInfo = new System.Windows.Forms.DataGridView();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnGetTableInfo = new System.Windows.Forms.Button();
            this.txtModelsAPPFolderName = new System.Windows.Forms.TextBox();
            this.txtTemnplateAPPFolderName = new System.Windows.Forms.TextBox();
            this.lblModelsAPPFolderName = new System.Windows.Forms.Label();
            this.lblTemnplateAPPFolderName = new System.Windows.Forms.Label();
            this.lblAPPFolderName = new System.Windows.Forms.Label();
            this.pbProgressBar = new System.Windows.Forms.ProgressBar();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkUseUserModel = new System.Windows.Forms.CheckBox();
            this.chkUseGeneratedModel = new System.Windows.Forms.CheckBox();
            this.chkRunAJGenesis = new System.Windows.Forms.CheckBox();
            this.chkUseCompleteModel = new System.Windows.Forms.CheckBox();
            this.lblTaskAPPFolderName = new System.Windows.Forms.Label();
            this.txtTaskAPPFolderName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSolutionAPPFileName = new System.Windows.Forms.Label();
            this.txtSolutionAPPFileName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkUseMetaData = new System.Windows.Forms.CheckBox();
            this.chkDeleteExistingControllers = new System.Windows.Forms.CheckBox();
            this.chkDeleteExistingHelpers = new System.Windows.Forms.CheckBox();
            this.chkDeleteExistingModels = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblProgressMsg = new System.Windows.Forms.Label();
            this.chkUseExistingModels = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gvTableInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboStringConnections
            // 
            this.cboStringConnections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStringConnections.Enabled = false;
            this.cboStringConnections.FormattingEnabled = true;
            this.cboStringConnections.Location = new System.Drawing.Point(4, 22);
            this.cboStringConnections.Name = "cboStringConnections";
            this.cboStringConnections.Size = new System.Drawing.Size(434, 21);
            this.cboStringConnections.TabIndex = 0;
            this.cboStringConnections.SelectedIndexChanged += new System.EventHandler(this.cboStringConnections_SelectedIndexChanged);
            // 
            // txtAPPFolderName
            // 
            this.txtAPPFolderName.Location = new System.Drawing.Point(7, 32);
            this.txtAPPFolderName.Name = "txtAPPFolderName";
            this.txtAPPFolderName.Size = new System.Drawing.Size(320, 20);
            this.txtAPPFolderName.TabIndex = 5;
            // 
            // btnGetFolder
            // 
            this.btnGetFolder.Location = new System.Drawing.Point(332, 29);
            this.btnGetFolder.Name = "btnGetFolder";
            this.btnGetFolder.Size = new System.Drawing.Size(28, 23);
            this.btnGetFolder.TabIndex = 6;
            this.btnGetFolder.Text = "...";
            this.btnGetFolder.UseVisualStyleBackColor = true;
            this.btnGetFolder.Click += new System.EventHandler(this.btnGetFolder_Click);
            // 
            // lblConections
            // 
            this.lblConections.Location = new System.Drawing.Point(1, 0);
            this.lblConections.Name = "lblConections";
            this.lblConections.Size = new System.Drawing.Size(468, 20);
            this.lblConections.TabIndex = 3;
            this.lblConections.Text = "Conexiones disponibles";
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConnectionString.BackColor = System.Drawing.Color.Gray;
            this.lblConnectionString.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionString.ForeColor = System.Drawing.Color.White;
            this.lblConnectionString.Location = new System.Drawing.Point(4, 46);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(468, 40);
            this.lblConnectionString.TabIndex = 4;
            this.lblConnectionString.Text = "connectionString...";
            // 
            // gvTableInfo
            // 
            this.gvTableInfo.AllowUserToAddRows = false;
            this.gvTableInfo.AllowUserToDeleteRows = false;
            this.gvTableInfo.AllowUserToResizeColumns = false;
            this.gvTableInfo.AllowUserToResizeRows = false;
            this.gvTableInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvTableInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableName,
            this.CM,
            this.CV});
            this.gvTableInfo.Location = new System.Drawing.Point(8, 150);
            this.gvTableInfo.MultiSelect = false;
            this.gvTableInfo.Name = "gvTableInfo";
            this.gvTableInfo.Size = new System.Drawing.Size(475, 331);
            this.gvTableInfo.TabIndex = 2;
            // 
            // TableName
            // 
            this.TableName.DataPropertyName = "TableName";
            this.TableName.Frozen = true;
            this.TableName.HeaderText = "Table Name";
            this.TableName.Name = "TableName";
            this.TableName.ReadOnly = true;
            this.TableName.Width = 400;
            // 
            // CM
            // 
            this.CM.DataPropertyName = "CM";
            this.CM.HeaderText = "C.Model";
            this.CM.Name = "CM";
            this.CM.Visible = false;
            this.CM.Width = 60;
            // 
            // CV
            // 
            this.CV.DataPropertyName = "CV";
            this.CV.HeaderText = "C.View";
            this.CV.Name = "CV";
            this.CV.Visible = false;
            this.CV.Width = 60;
            // 
            // btnGetTableInfo
            // 
            this.btnGetTableInfo.Enabled = false;
            this.btnGetTableInfo.Location = new System.Drawing.Point(440, 20);
            this.btnGetTableInfo.Name = "btnGetTableInfo";
            this.btnGetTableInfo.Size = new System.Drawing.Size(28, 23);
            this.btnGetTableInfo.TabIndex = 1;
            this.btnGetTableInfo.Text = "...";
            this.btnGetTableInfo.UseVisualStyleBackColor = true;
            this.btnGetTableInfo.Click += new System.EventHandler(this.btnGetTableInfo_Click);
            // 
            // txtModelsAPPFolderName
            // 
            this.txtModelsAPPFolderName.Location = new System.Drawing.Point(143, 58);
            this.txtModelsAPPFolderName.Name = "txtModelsAPPFolderName";
            this.txtModelsAPPFolderName.Size = new System.Drawing.Size(184, 20);
            this.txtModelsAPPFolderName.TabIndex = 7;
            // 
            // txtTemnplateAPPFolderName
            // 
            this.txtTemnplateAPPFolderName.Location = new System.Drawing.Point(143, 84);
            this.txtTemnplateAPPFolderName.Name = "txtTemnplateAPPFolderName";
            this.txtTemnplateAPPFolderName.Size = new System.Drawing.Size(184, 20);
            this.txtTemnplateAPPFolderName.TabIndex = 8;
            // 
            // lblModelsAPPFolderName
            // 
            this.lblModelsAPPFolderName.Location = new System.Drawing.Point(7, 61);
            this.lblModelsAPPFolderName.Name = "lblModelsAPPFolderName";
            this.lblModelsAPPFolderName.Size = new System.Drawing.Size(130, 20);
            this.lblModelsAPPFolderName.TabIndex = 7;
            this.lblModelsAPPFolderName.Text = "Carpeta de Modelos";
            // 
            // lblTemnplateAPPFolderName
            // 
            this.lblTemnplateAPPFolderName.Location = new System.Drawing.Point(7, 87);
            this.lblTemnplateAPPFolderName.Name = "lblTemnplateAPPFolderName";
            this.lblTemnplateAPPFolderName.Size = new System.Drawing.Size(130, 20);
            this.lblTemnplateAPPFolderName.TabIndex = 8;
            this.lblTemnplateAPPFolderName.Text = "Carpeta de Templates";
            // 
            // lblAPPFolderName
            // 
            this.lblAPPFolderName.Location = new System.Drawing.Point(7, 9);
            this.lblAPPFolderName.Name = "lblAPPFolderName";
            this.lblAPPFolderName.Size = new System.Drawing.Size(315, 20);
            this.lblAPPFolderName.TabIndex = 9;
            this.lblAPPFolderName.Text = "Carpeta de trabajo de la aplicación";
            // 
            // pbProgressBar
            // 
            this.pbProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgressBar.Location = new System.Drawing.Point(502, 429);
            this.pbProgressBar.Name = "pbProgressBar";
            this.pbProgressBar.Size = new System.Drawing.Size(363, 23);
            this.pbProgressBar.TabIndex = 30;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(502, 458);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 23);
            this.btnGenerate.TabIndex = 31;
            this.btnGenerate.Text = "Generar";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(765, 458);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkUseUserModel
            // 
            this.chkUseUserModel.AutoSize = true;
            this.chkUseUserModel.Location = new System.Drawing.Point(7, 13);
            this.chkUseUserModel.Name = "chkUseUserModel";
            this.chkUseUserModel.Size = new System.Drawing.Size(107, 17);
            this.chkUseUserModel.TabIndex = 12;
            this.chkUseUserModel.Text = "Utilizar Model.xml";
            this.chkUseUserModel.UseVisualStyleBackColor = true;
            this.chkUseUserModel.CheckedChanged += new System.EventHandler(this.chkUseUserModel_CheckedChanged);
            // 
            // chkUseGeneratedModel
            // 
            this.chkUseGeneratedModel.AutoSize = true;
            this.chkUseGeneratedModel.Checked = true;
            this.chkUseGeneratedModel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseGeneratedModel.Enabled = false;
            this.chkUseGeneratedModel.Location = new System.Drawing.Point(137, 13);
            this.chkUseGeneratedModel.Name = "chkUseGeneratedModel";
            this.chkUseGeneratedModel.Size = new System.Drawing.Size(143, 17);
            this.chkUseGeneratedModel.TabIndex = 14;
            this.chkUseGeneratedModel.Text = "Utilizar Modelo generado";
            this.chkUseGeneratedModel.UseVisualStyleBackColor = true;
            // 
            // chkRunAJGenesis
            // 
            this.chkRunAJGenesis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRunAJGenesis.AutoSize = true;
            this.chkRunAJGenesis.Checked = true;
            this.chkRunAJGenesis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRunAJGenesis.Location = new System.Drawing.Point(509, 360);
            this.chkRunAJGenesis.Name = "chkRunAJGenesis";
            this.chkRunAJGenesis.Size = new System.Drawing.Size(281, 17);
            this.chkRunAJGenesis.TabIndex = 20;
            this.chkRunAJGenesis.Text = "Ejecutar el Generador de AJGenesis automaticamente";
            this.chkRunAJGenesis.UseVisualStyleBackColor = true;
            // 
            // chkUseCompleteModel
            // 
            this.chkUseCompleteModel.AutoSize = true;
            this.chkUseCompleteModel.Checked = true;
            this.chkUseCompleteModel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseCompleteModel.Location = new System.Drawing.Point(7, 59);
            this.chkUseCompleteModel.Name = "chkUseCompleteModel";
            this.chkUseCompleteModel.Size = new System.Drawing.Size(133, 17);
            this.chkUseCompleteModel.TabIndex = 14;
            this.chkUseCompleteModel.Text = "Utilizar CompleteModel";
            this.chkUseCompleteModel.UseVisualStyleBackColor = true;
            // 
            // lblTaskAPPFolderName
            // 
            this.lblTaskAPPFolderName.Location = new System.Drawing.Point(7, 113);
            this.lblTaskAPPFolderName.Name = "lblTaskAPPFolderName";
            this.lblTaskAPPFolderName.Size = new System.Drawing.Size(130, 20);
            this.lblTaskAPPFolderName.TabIndex = 17;
            this.lblTaskAPPFolderName.Text = "Carpeta de Tasks";
            // 
            // txtTaskAPPFolderName
            // 
            this.txtTaskAPPFolderName.Location = new System.Drawing.Point(143, 110);
            this.txtTaskAPPFolderName.Name = "txtTaskAPPFolderName";
            this.txtTaskAPPFolderName.Size = new System.Drawing.Size(184, 20);
            this.txtTaskAPPFolderName.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblConections);
            this.panel1.Controls.Add(this.cboStringConnections);
            this.panel1.Controls.Add(this.lblConnectionString);
            this.panel1.Controls.Add(this.btnGetTableInfo);
            this.panel1.Location = new System.Drawing.Point(8, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 98);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblSolutionAPPFileName);
            this.panel2.Controls.Add(this.txtSolutionAPPFileName);
            this.panel2.Controls.Add(this.lblAPPFolderName);
            this.panel2.Controls.Add(this.txtAPPFolderName);
            this.panel2.Controls.Add(this.lblTaskAPPFolderName);
            this.panel2.Controls.Add(this.btnGetFolder);
            this.panel2.Controls.Add(this.txtTaskAPPFolderName);
            this.panel2.Controls.Add(this.txtModelsAPPFolderName);
            this.panel2.Controls.Add(this.txtTemnplateAPPFolderName);
            this.panel2.Controls.Add(this.lblModelsAPPFolderName);
            this.panel2.Controls.Add(this.lblTemnplateAPPFolderName);
            this.panel2.Location = new System.Drawing.Point(502, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 162);
            this.panel2.TabIndex = 3;
            // 
            // lblSolutionAPPFileName
            // 
            this.lblSolutionAPPFileName.Location = new System.Drawing.Point(7, 139);
            this.lblSolutionAPPFileName.Name = "lblSolutionAPPFileName";
            this.lblSolutionAPPFileName.Size = new System.Drawing.Size(130, 20);
            this.lblSolutionAPPFileName.TabIndex = 19;
            this.lblSolutionAPPFileName.Text = "Archivo de generación";
            // 
            // txtSolutionAPPFileName
            // 
            this.txtSolutionAPPFileName.Location = new System.Drawing.Point(143, 136);
            this.txtSolutionAPPFileName.Name = "txtSolutionAPPFileName";
            this.txtSolutionAPPFileName.Size = new System.Drawing.Size(184, 20);
            this.txtSolutionAPPFileName.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.chkUseMetaData);
            this.panel3.Controls.Add(this.chkUseCompleteModel);
            this.panel3.Controls.Add(this.chkUseUserModel);
            this.panel3.Controls.Add(this.chkUseGeneratedModel);
            this.panel3.Location = new System.Drawing.Point(502, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 83);
            this.panel3.TabIndex = 11;
            // 
            // chkUseMetaData
            // 
            this.chkUseMetaData.AutoSize = true;
            this.chkUseMetaData.Location = new System.Drawing.Point(7, 36);
            this.chkUseMetaData.Name = "chkUseMetaData";
            this.chkUseMetaData.Size = new System.Drawing.Size(107, 17);
            this.chkUseMetaData.TabIndex = 13;
            this.chkUseMetaData.Text = "Utilizar MetaData";
            this.chkUseMetaData.UseVisualStyleBackColor = true;
            // 
            // chkDeleteExistingControllers
            // 
            this.chkDeleteExistingControllers.AutoSize = true;
            this.chkDeleteExistingControllers.Location = new System.Drawing.Point(7, 14);
            this.chkDeleteExistingControllers.Name = "chkDeleteExistingControllers";
            this.chkDeleteExistingControllers.Size = new System.Drawing.Size(160, 17);
            this.chkDeleteExistingControllers.TabIndex = 17;
            this.chkDeleteExistingControllers.Text = "Borrrar Controllers Existentes";
            this.chkDeleteExistingControllers.UseVisualStyleBackColor = true;
            // 
            // chkDeleteExistingHelpers
            // 
            this.chkDeleteExistingHelpers.AutoSize = true;
            this.chkDeleteExistingHelpers.Location = new System.Drawing.Point(7, 37);
            this.chkDeleteExistingHelpers.Name = "chkDeleteExistingHelpers";
            this.chkDeleteExistingHelpers.Size = new System.Drawing.Size(147, 17);
            this.chkDeleteExistingHelpers.TabIndex = 18;
            this.chkDeleteExistingHelpers.Text = "Borrrar Helpers Existentes";
            this.chkDeleteExistingHelpers.UseVisualStyleBackColor = true;
            // 
            // chkDeleteExistingModels
            // 
            this.chkDeleteExistingModels.AutoSize = true;
            this.chkDeleteExistingModels.Location = new System.Drawing.Point(7, 60);
            this.chkDeleteExistingModels.Name = "chkDeleteExistingModels";
            this.chkDeleteExistingModels.Size = new System.Drawing.Size(145, 17);
            this.chkDeleteExistingModels.TabIndex = 19;
            this.chkDeleteExistingModels.Text = "Borrrar Models Existentes";
            this.chkDeleteExistingModels.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.chkDeleteExistingControllers);
            this.panel4.Controls.Add(this.chkDeleteExistingModels);
            this.panel4.Controls.Add(this.chkDeleteExistingHelpers);
            this.panel4.Location = new System.Drawing.Point(502, 269);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 85);
            this.panel4.TabIndex = 15;
            // 
            // lblProgressMsg
            // 
            this.lblProgressMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgressMsg.BackColor = System.Drawing.Color.Gray;
            this.lblProgressMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProgressMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressMsg.ForeColor = System.Drawing.Color.White;
            this.lblProgressMsg.Location = new System.Drawing.Point(502, 405);
            this.lblProgressMsg.Name = "lblProgressMsg";
            this.lblProgressMsg.Size = new System.Drawing.Size(362, 21);
            this.lblProgressMsg.TabIndex = 5;
            // 
            // chkUseExistingModels
            // 
            this.chkUseExistingModels.AutoSize = true;
            this.chkUseExistingModels.Checked = true;
            this.chkUseExistingModels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseExistingModels.Location = new System.Drawing.Point(6, 10);
            this.chkUseExistingModels.Name = "chkUseExistingModels";
            this.chkUseExistingModels.Size = new System.Drawing.Size(140, 17);
            this.chkUseExistingModels.TabIndex = 18;
            this.chkUseExistingModels.Text = "Usar modelos existentes";
            this.chkUseExistingModels.UseVisualStyleBackColor = true;
            this.chkUseExistingModels.CheckedChanged += new System.EventHandler(this.chkUseExistingModels_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.chkUseExistingModels);
            this.panel5.Location = new System.Drawing.Point(8, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(474, 33);
            this.panel5.TabIndex = 33;
            // 
            // frmAJGenesisUI
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(882, 493);
            this.Controls.Add(this.lblProgressMsg);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chkRunAJGenesis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.pbProgressBar);
            this.Controls.Add(this.gvTableInfo);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAJGenesisUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AJGenesis UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTableInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboStringConnections;
        private System.Windows.Forms.TextBox txtAPPFolderName;
        private System.Windows.Forms.Button btnGetFolder;
        private System.Windows.Forms.Label lblConections;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.DataGridView gvTableInfo;
        private System.Windows.Forms.Button btnGetTableInfo;
        private System.Windows.Forms.TextBox txtModelsAPPFolderName;
        private System.Windows.Forms.TextBox txtTemnplateAPPFolderName;
        private System.Windows.Forms.Label lblModelsAPPFolderName;
        private System.Windows.Forms.Label lblTemnplateAPPFolderName;
        private System.Windows.Forms.Label lblAPPFolderName;
        private System.Windows.Forms.ProgressBar pbProgressBar;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkUseUserModel;
        private System.Windows.Forms.CheckBox chkUseGeneratedModel;
        private System.Windows.Forms.CheckBox chkRunAJGenesis;
        private System.Windows.Forms.CheckBox chkUseCompleteModel;
        private System.Windows.Forms.Label lblTaskAPPFolderName;
        private System.Windows.Forms.TextBox txtTaskAPPFolderName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSolutionAPPFileName;
        private System.Windows.Forms.TextBox txtSolutionAPPFileName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkUseMetaData;
        private System.Windows.Forms.CheckBox chkDeleteExistingControllers;
        private System.Windows.Forms.CheckBox chkDeleteExistingHelpers;
        private System.Windows.Forms.CheckBox chkDeleteExistingModels;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CM;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CV;
        private System.Windows.Forms.Label lblProgressMsg;
        private System.Windows.Forms.CheckBox chkUseExistingModels;
        private System.Windows.Forms.Panel panel5;
    }
}

