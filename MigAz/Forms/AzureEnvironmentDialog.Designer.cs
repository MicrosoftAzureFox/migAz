﻿namespace MigAz.Forms
{
    partial class AzureEnvironmentDialog
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLoginUrl = new System.Windows.Forms.TextBox();
            this.lblLoginUrl = new System.Windows.Forms.Label();
            this.txtGraphApiUrl = new System.Windows.Forms.TextBox();
            this.lblGraphApiUrl = new System.Windows.Forms.Label();
            this.txtASMManagementUrl = new System.Windows.Forms.TextBox();
            this.lblASMManagementUrl = new System.Windows.Forms.Label();
            this.txtARMManagementUrl = new System.Windows.Forms.TextBox();
            this.lblARMManagementUrl = new System.Windows.Forms.Label();
            this.txtStorageEndpoint = new System.Windows.Forms.TextBox();
            this.lblStorageEndpoint = new System.Windows.Forms.Label();
            this.txtBlobEndpoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAzureEnvironments = new System.Windows.Forms.ListBox();
            this.btnNewAzureEnvironment = new System.Windows.Forms.Button();
            this.btnCloneAzureEnvironment = new System.Windows.Forms.Button();
            this.btnDeleteAzureEnvironment = new System.Windows.Forms.Button();
            this.groupBoxAzureEnvironments = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbAzureEnvironmentType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAzureStackAdminManagementUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQueryAzureStackMetadata = new System.Windows.Forms.Button();
            this.groupBoxAzureEnvironments.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(572, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(760, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 26);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // txtLoginUrl
            // 
            this.txtLoginUrl.Enabled = false;
            this.txtLoginUrl.Location = new System.Drawing.Point(760, 220);
            this.txtLoginUrl.Name = "txtLoginUrl";
            this.txtLoginUrl.Size = new System.Drawing.Size(484, 26);
            this.txtLoginUrl.TabIndex = 3;
            // 
            // lblLoginUrl
            // 
            this.lblLoginUrl.AutoSize = true;
            this.lblLoginUrl.Location = new System.Drawing.Point(572, 223);
            this.lblLoginUrl.Name = "lblLoginUrl";
            this.lblLoginUrl.Size = new System.Drawing.Size(89, 20);
            this.lblLoginUrl.TabIndex = 2;
            this.lblLoginUrl.Text = "Login URL:";
            // 
            // txtGraphApiUrl
            // 
            this.txtGraphApiUrl.Enabled = false;
            this.txtGraphApiUrl.Location = new System.Drawing.Point(760, 252);
            this.txtGraphApiUrl.Name = "txtGraphApiUrl";
            this.txtGraphApiUrl.Size = new System.Drawing.Size(484, 26);
            this.txtGraphApiUrl.TabIndex = 5;
            // 
            // lblGraphApiUrl
            // 
            this.lblGraphApiUrl.AutoSize = true;
            this.lblGraphApiUrl.Location = new System.Drawing.Point(572, 255);
            this.lblGraphApiUrl.Name = "lblGraphApiUrl";
            this.lblGraphApiUrl.Size = new System.Drawing.Size(125, 20);
            this.lblGraphApiUrl.TabIndex = 4;
            this.lblGraphApiUrl.Text = "Graph API URL:";
            // 
            // txtASMManagementUrl
            // 
            this.txtASMManagementUrl.Enabled = false;
            this.txtASMManagementUrl.Location = new System.Drawing.Point(760, 285);
            this.txtASMManagementUrl.Name = "txtASMManagementUrl";
            this.txtASMManagementUrl.Size = new System.Drawing.Size(484, 26);
            this.txtASMManagementUrl.TabIndex = 7;
            // 
            // lblASMManagementUrl
            // 
            this.lblASMManagementUrl.AutoSize = true;
            this.lblASMManagementUrl.Location = new System.Drawing.Point(572, 288);
            this.lblASMManagementUrl.Name = "lblASMManagementUrl";
            this.lblASMManagementUrl.Size = new System.Drawing.Size(183, 20);
            this.lblASMManagementUrl.TabIndex = 6;
            this.lblASMManagementUrl.Text = "ASM Management URL:";
            // 
            // txtARMManagementUrl
            // 
            this.txtARMManagementUrl.Enabled = false;
            this.txtARMManagementUrl.Location = new System.Drawing.Point(760, 317);
            this.txtARMManagementUrl.Name = "txtARMManagementUrl";
            this.txtARMManagementUrl.Size = new System.Drawing.Size(484, 26);
            this.txtARMManagementUrl.TabIndex = 9;
            // 
            // lblARMManagementUrl
            // 
            this.lblARMManagementUrl.AutoSize = true;
            this.lblARMManagementUrl.Location = new System.Drawing.Point(572, 320);
            this.lblARMManagementUrl.Name = "lblARMManagementUrl";
            this.lblARMManagementUrl.Size = new System.Drawing.Size(184, 20);
            this.lblARMManagementUrl.TabIndex = 8;
            this.lblARMManagementUrl.Text = "ARM Management URL:";
            // 
            // txtStorageEndpoint
            // 
            this.txtStorageEndpoint.Enabled = false;
            this.txtStorageEndpoint.Location = new System.Drawing.Point(760, 349);
            this.txtStorageEndpoint.Name = "txtStorageEndpoint";
            this.txtStorageEndpoint.Size = new System.Drawing.Size(484, 26);
            this.txtStorageEndpoint.TabIndex = 11;
            // 
            // lblStorageEndpoint
            // 
            this.lblStorageEndpoint.AutoSize = true;
            this.lblStorageEndpoint.Location = new System.Drawing.Point(572, 352);
            this.lblStorageEndpoint.Name = "lblStorageEndpoint";
            this.lblStorageEndpoint.Size = new System.Drawing.Size(138, 20);
            this.lblStorageEndpoint.TabIndex = 10;
            this.lblStorageEndpoint.Text = "Storage Endpoint:";
            // 
            // txtBlobEndpoint
            // 
            this.txtBlobEndpoint.Enabled = false;
            this.txtBlobEndpoint.Location = new System.Drawing.Point(760, 383);
            this.txtBlobEndpoint.Name = "txtBlobEndpoint";
            this.txtBlobEndpoint.Size = new System.Drawing.Size(484, 26);
            this.txtBlobEndpoint.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Blob Endpoint:";
            // 
            // listBoxAzureEnvironments
            // 
            this.listBoxAzureEnvironments.FormattingEnabled = true;
            this.listBoxAzureEnvironments.ItemHeight = 20;
            this.listBoxAzureEnvironments.Location = new System.Drawing.Point(28, 35);
            this.listBoxAzureEnvironments.Name = "listBoxAzureEnvironments";
            this.listBoxAzureEnvironments.Size = new System.Drawing.Size(445, 324);
            this.listBoxAzureEnvironments.TabIndex = 14;
            this.listBoxAzureEnvironments.SelectedIndexChanged += new System.EventHandler(this.listBoxAzureEnvironments_SelectedIndexChanged);
            // 
            // btnNewAzureEnvironment
            // 
            this.btnNewAzureEnvironment.Location = new System.Drawing.Point(29, 388);
            this.btnNewAzureEnvironment.Name = "btnNewAzureEnvironment";
            this.btnNewAzureEnvironment.Size = new System.Drawing.Size(124, 43);
            this.btnNewAzureEnvironment.TabIndex = 16;
            this.btnNewAzureEnvironment.Text = "&New";
            this.btnNewAzureEnvironment.UseVisualStyleBackColor = true;
            this.btnNewAzureEnvironment.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCloneAzureEnvironment
            // 
            this.btnCloneAzureEnvironment.Location = new System.Drawing.Point(189, 388);
            this.btnCloneAzureEnvironment.Name = "btnCloneAzureEnvironment";
            this.btnCloneAzureEnvironment.Size = new System.Drawing.Size(124, 43);
            this.btnCloneAzureEnvironment.TabIndex = 19;
            this.btnCloneAzureEnvironment.Text = "&Clone";
            this.btnCloneAzureEnvironment.UseVisualStyleBackColor = true;
            this.btnCloneAzureEnvironment.Click += new System.EventHandler(this.btnCloneAzureEnvironment_Click);
            // 
            // btnDeleteAzureEnvironment
            // 
            this.btnDeleteAzureEnvironment.Location = new System.Drawing.Point(349, 388);
            this.btnDeleteAzureEnvironment.Name = "btnDeleteAzureEnvironment";
            this.btnDeleteAzureEnvironment.Size = new System.Drawing.Size(124, 43);
            this.btnDeleteAzureEnvironment.TabIndex = 20;
            this.btnDeleteAzureEnvironment.Text = "&Delete";
            this.btnDeleteAzureEnvironment.UseVisualStyleBackColor = true;
            this.btnDeleteAzureEnvironment.Click += new System.EventHandler(this.btnDeleteAzureEnvironment_Click);
            // 
            // groupBoxAzureEnvironments
            // 
            this.groupBoxAzureEnvironments.Controls.Add(this.listBoxAzureEnvironments);
            this.groupBoxAzureEnvironments.Controls.Add(this.btnDeleteAzureEnvironment);
            this.groupBoxAzureEnvironments.Controls.Add(this.btnNewAzureEnvironment);
            this.groupBoxAzureEnvironments.Controls.Add(this.btnCloneAzureEnvironment);
            this.groupBoxAzureEnvironments.Location = new System.Drawing.Point(26, 32);
            this.groupBoxAzureEnvironments.Name = "groupBoxAzureEnvironments";
            this.groupBoxAzureEnvironments.Size = new System.Drawing.Size(502, 457);
            this.groupBoxAzureEnvironments.TabIndex = 22;
            this.groupBoxAzureEnvironments.TabStop = false;
            this.groupBoxAzureEnvironments.Text = "Azure Environments";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1120, 446);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 43);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbAzureEnvironmentType
            // 
            this.cmbAzureEnvironmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAzureEnvironmentType.Enabled = false;
            this.cmbAzureEnvironmentType.FormattingEnabled = true;
            this.cmbAzureEnvironmentType.Items.AddRange(new object[] {
            "Azure",
            "AzureStack"});
            this.cmbAzureEnvironmentType.Location = new System.Drawing.Point(760, 88);
            this.cmbAzureEnvironmentType.Name = "cmbAzureEnvironmentType";
            this.cmbAzureEnvironmentType.Size = new System.Drawing.Size(250, 28);
            this.cmbAzureEnvironmentType.TabIndex = 25;
            this.cmbAzureEnvironmentType.SelectedIndexChanged += new System.EventHandler(this.cmbAzureEnvironmentType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Type:";
            // 
            // txtAzureStackAdminManagementUrl
            // 
            this.txtAzureStackAdminManagementUrl.Enabled = false;
            this.txtAzureStackAdminManagementUrl.Location = new System.Drawing.Point(760, 129);
            this.txtAzureStackAdminManagementUrl.Name = "txtAzureStackAdminManagementUrl";
            this.txtAzureStackAdminManagementUrl.Size = new System.Drawing.Size(484, 26);
            this.txtAzureStackAdminManagementUrl.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Azure Stack:";
            // 
            // btnQueryAzureStackMetadata
            // 
            this.btnQueryAzureStackMetadata.Enabled = false;
            this.btnQueryAzureStackMetadata.Location = new System.Drawing.Point(760, 166);
            this.btnQueryAzureStackMetadata.Name = "btnQueryAzureStackMetadata";
            this.btnQueryAzureStackMetadata.Size = new System.Drawing.Size(276, 43);
            this.btnQueryAzureStackMetadata.TabIndex = 29;
            this.btnQueryAzureStackMetadata.Text = "&Query Azure Stack Metadata";
            this.btnQueryAzureStackMetadata.UseVisualStyleBackColor = true;
            this.btnQueryAzureStackMetadata.Click += new System.EventHandler(this.btnQueryAzureStackMetadata_Click);
            // 
            // AzureEnvironmentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 514);
            this.Controls.Add(this.btnQueryAzureStackMetadata);
            this.Controls.Add(this.txtAzureStackAdminManagementUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAzureEnvironmentType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtBlobEndpoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStorageEndpoint);
            this.Controls.Add(this.lblStorageEndpoint);
            this.Controls.Add(this.txtARMManagementUrl);
            this.Controls.Add(this.lblARMManagementUrl);
            this.Controls.Add(this.txtASMManagementUrl);
            this.Controls.Add(this.lblASMManagementUrl);
            this.Controls.Add(this.txtGraphApiUrl);
            this.Controls.Add(this.lblGraphApiUrl);
            this.Controls.Add(this.txtLoginUrl);
            this.Controls.Add(this.lblLoginUrl);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.groupBoxAzureEnvironments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AzureEnvironmentDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Azure Environments";
            this.groupBoxAzureEnvironments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLoginUrl;
        private System.Windows.Forms.Label lblLoginUrl;
        private System.Windows.Forms.TextBox txtGraphApiUrl;
        private System.Windows.Forms.Label lblGraphApiUrl;
        private System.Windows.Forms.TextBox txtASMManagementUrl;
        private System.Windows.Forms.Label lblASMManagementUrl;
        private System.Windows.Forms.TextBox txtARMManagementUrl;
        private System.Windows.Forms.Label lblARMManagementUrl;
        private System.Windows.Forms.TextBox txtStorageEndpoint;
        private System.Windows.Forms.Label lblStorageEndpoint;
        private System.Windows.Forms.TextBox txtBlobEndpoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAzureEnvironments;
        private System.Windows.Forms.Button btnNewAzureEnvironment;
        private System.Windows.Forms.Button btnCloneAzureEnvironment;
        private System.Windows.Forms.Button btnDeleteAzureEnvironment;
        private System.Windows.Forms.GroupBox groupBoxAzureEnvironments;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbAzureEnvironmentType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAzureStackAdminManagementUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQueryAzureStackMetadata;
    }
}