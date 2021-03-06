// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace MigAz.Azure.UserControls
{
    partial class ResourceSummary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbResources = new System.Windows.Forms.ComboBox();
            this.lblResourceText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ResourceSummary_Click);
            // 
            // cmbResources
            // 
            this.cmbResources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResources.Enabled = false;
            this.cmbResources.FormattingEnabled = true;
            this.cmbResources.Location = new System.Drawing.Point(45, 0);
            this.cmbResources.Name = "cmbResources";
            this.cmbResources.Size = new System.Drawing.Size(239, 28);
            this.cmbResources.TabIndex = 2;
            this.cmbResources.SelectedIndexChanged += new System.EventHandler(this.cmbResources_SelectedIndexChanged);
            this.cmbResources.Click += new System.EventHandler(this.cmbResources_Click);
            // 
            // lblResourceText
            // 
            this.lblResourceText.AutoSize = true;
            this.lblResourceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResourceText.Location = new System.Drawing.Point(45, 3);
            this.lblResourceText.Name = "lblResourceText";
            this.lblResourceText.Size = new System.Drawing.Size(138, 20);
            this.lblResourceText.TabIndex = 3;
            this.lblResourceText.Text = "lblResourceText";
            this.lblResourceText.Visible = false;
            this.lblResourceText.Click += new System.EventHandler(this.ResourceSummary_Click);
            // 
            // ResourceSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lblResourceText);
            this.Controls.Add(this.cmbResources);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ResourceSummary";
            this.Size = new System.Drawing.Size(338, 25);
            this.Click += new System.EventHandler(this.ResourceSummary_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbResources;
        private System.Windows.Forms.Label lblResourceText;
    }
}

