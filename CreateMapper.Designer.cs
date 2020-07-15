namespace CodeReaper
{
    partial class CreateMapper
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
            this.lblXMLPath = new System.Windows.Forms.Label();
            this.lblXMLPathDesc = new System.Windows.Forms.Label();
            this.btnBrowseXMLPath = new System.Windows.Forms.Button();
            this.txtXMLPath = new System.Windows.Forms.TextBox();
            this.btnSaveHelper = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveXMLPath = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveInputFolderPath = new System.Windows.Forms.Button();
            this.btnSaveInputFolderHelper = new System.Windows.Forms.Button();
            this.txtInputFolderPath = new System.Windows.Forms.TextBox();
            this.btnBrowseInputFolderPath = new System.Windows.Forms.Button();
            this.lblInputFolderDesc = new System.Windows.Forms.Label();
            this.lblInputFolderPath = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSaveOutputZIPPath = new System.Windows.Forms.Button();
            this.btnSaveOutputZIPHelper = new System.Windows.Forms.Button();
            this.txtOutputZipPath = new System.Windows.Forms.TextBox();
            this.btnBrowseOutputZipPath = new System.Windows.Forms.Button();
            this.lblOutputZipDesc = new System.Windows.Forms.Label();
            this.lblOutputZipPath = new System.Windows.Forms.Label();
            this.btnCreateMapper = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblXMLPath
            // 
            this.lblXMLPath.AutoSize = true;
            this.lblXMLPath.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMLPath.Location = new System.Drawing.Point(8, 15);
            this.lblXMLPath.Name = "lblXMLPath";
            this.lblXMLPath.Size = new System.Drawing.Size(143, 25);
            this.lblXMLPath.TabIndex = 1;
            this.lblXMLPath.Text = "Jira Base URL";
            // 
            // lblXMLPathDesc
            // 
            this.lblXMLPathDesc.AutoSize = true;
            this.lblXMLPathDesc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXMLPathDesc.Location = new System.Drawing.Point(10, 41);
            this.lblXMLPathDesc.Name = "lblXMLPathDesc";
            this.lblXMLPathDesc.Size = new System.Drawing.Size(448, 17);
            this.lblXMLPathDesc.TabIndex = 1;
            this.lblXMLPathDesc.Text = "Please enter the base URL for Jira API Connection (including the ending \"/\")";
            // 
            // btnBrowseXMLPath
            // 
            this.btnBrowseXMLPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btnBrowseXMLPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseXMLPath.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseXMLPath.ForeColor = System.Drawing.Color.White;
            this.btnBrowseXMLPath.Location = new System.Drawing.Point(434, 61);
            this.btnBrowseXMLPath.Name = "btnBrowseXMLPath";
            this.btnBrowseXMLPath.Size = new System.Drawing.Size(107, 26);
            this.btnBrowseXMLPath.TabIndex = 1;
            this.btnBrowseXMLPath.Text = "Browse";
            this.btnBrowseXMLPath.UseVisualStyleBackColor = false;
            this.btnBrowseXMLPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtXMLPath
            // 
            this.txtXMLPath.Location = new System.Drawing.Point(9, 61);
            this.txtXMLPath.Multiline = true;
            this.txtXMLPath.Name = "txtXMLPath";
            this.txtXMLPath.Size = new System.Drawing.Size(419, 26);
            this.txtXMLPath.TabIndex = 3;
            // 
            // btnSaveHelper
            // 
            this.btnSaveHelper.FlatAppearance.BorderSize = 0;
            this.btnSaveHelper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveHelper.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveHelper.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSaveHelper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveHelper.Location = new System.Drawing.Point(517, 3);
            this.btnSaveHelper.Name = "btnSaveHelper";
            this.btnSaveHelper.Size = new System.Drawing.Size(36, 34);
            this.btnSaveHelper.TabIndex = 5;
            this.btnSaveHelper.Text = "?";
            this.btnSaveHelper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveHelper.UseVisualStyleBackColor = true;
            this.btnSaveHelper.Click += new System.EventHandler(this.button14_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnSaveXMLPath);
            this.panel1.Controls.Add(this.btnSaveHelper);
            this.panel1.Controls.Add(this.txtXMLPath);
            this.panel1.Controls.Add(this.btnBrowseXMLPath);
            this.panel1.Controls.Add(this.lblXMLPathDesc);
            this.panel1.Controls.Add(this.lblXMLPath);
            this.panel1.Location = new System.Drawing.Point(29, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 103);
            this.panel1.TabIndex = 0;
            // 
            // btnSaveXMLPath
            // 
            this.btnSaveXMLPath.FlatAppearance.BorderSize = 0;
            this.btnSaveXMLPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveXMLPath.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveXMLPath.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSaveXMLPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveXMLPath.Location = new System.Drawing.Point(475, 3);
            this.btnSaveXMLPath.Name = "btnSaveXMLPath";
            this.btnSaveXMLPath.Size = new System.Drawing.Size(36, 34);
            this.btnSaveXMLPath.TabIndex = 6;
            this.btnSaveXMLPath.Text = "✔";
            this.btnSaveXMLPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveXMLPath.UseVisualStyleBackColor = true;
            this.btnSaveXMLPath.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.btnSaveInputFolderPath);
            this.panel2.Controls.Add(this.btnSaveInputFolderHelper);
            this.panel2.Controls.Add(this.txtInputFolderPath);
            this.panel2.Controls.Add(this.btnBrowseInputFolderPath);
            this.panel2.Controls.Add(this.lblInputFolderDesc);
            this.panel2.Controls.Add(this.lblInputFolderPath);
            this.panel2.Location = new System.Drawing.Point(29, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 103);
            this.panel2.TabIndex = 6;
            // 
            // btnSaveInputFolderPath
            // 
            this.btnSaveInputFolderPath.FlatAppearance.BorderSize = 0;
            this.btnSaveInputFolderPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInputFolderPath.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInputFolderPath.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSaveInputFolderPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveInputFolderPath.Location = new System.Drawing.Point(475, 3);
            this.btnSaveInputFolderPath.Name = "btnSaveInputFolderPath";
            this.btnSaveInputFolderPath.Size = new System.Drawing.Size(36, 34);
            this.btnSaveInputFolderPath.TabIndex = 8;
            this.btnSaveInputFolderPath.Text = "✔";
            this.btnSaveInputFolderPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveInputFolderPath.UseVisualStyleBackColor = true;
            this.btnSaveInputFolderPath.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSaveInputFolderHelper
            // 
            this.btnSaveInputFolderHelper.FlatAppearance.BorderSize = 0;
            this.btnSaveInputFolderHelper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInputFolderHelper.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInputFolderHelper.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSaveInputFolderHelper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveInputFolderHelper.Location = new System.Drawing.Point(517, 3);
            this.btnSaveInputFolderHelper.Name = "btnSaveInputFolderHelper";
            this.btnSaveInputFolderHelper.Size = new System.Drawing.Size(36, 34);
            this.btnSaveInputFolderHelper.TabIndex = 7;
            this.btnSaveInputFolderHelper.Text = "?";
            this.btnSaveInputFolderHelper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveInputFolderHelper.UseVisualStyleBackColor = true;
            // 
            // txtInputFolderPath
            // 
            this.txtInputFolderPath.Location = new System.Drawing.Point(9, 61);
            this.txtInputFolderPath.Multiline = true;
            this.txtInputFolderPath.Name = "txtInputFolderPath";
            this.txtInputFolderPath.Size = new System.Drawing.Size(419, 26);
            this.txtInputFolderPath.TabIndex = 3;
            // 
            // btnBrowseInputFolderPath
            // 
            this.btnBrowseInputFolderPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btnBrowseInputFolderPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseInputFolderPath.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseInputFolderPath.ForeColor = System.Drawing.Color.White;
            this.btnBrowseInputFolderPath.Location = new System.Drawing.Point(434, 61);
            this.btnBrowseInputFolderPath.Name = "btnBrowseInputFolderPath";
            this.btnBrowseInputFolderPath.Size = new System.Drawing.Size(107, 26);
            this.btnBrowseInputFolderPath.TabIndex = 1;
            this.btnBrowseInputFolderPath.Text = "Browse";
            this.btnBrowseInputFolderPath.UseVisualStyleBackColor = false;
            this.btnBrowseInputFolderPath.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblInputFolderDesc
            // 
            this.lblInputFolderDesc.AutoSize = true;
            this.lblInputFolderDesc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputFolderDesc.Location = new System.Drawing.Point(10, 41);
            this.lblInputFolderDesc.Name = "lblInputFolderDesc";
            this.lblInputFolderDesc.Size = new System.Drawing.Size(322, 17);
            this.lblInputFolderDesc.TabIndex = 1;
            this.lblInputFolderDesc.Text = "Please enter the username credentials for API access";
            // 
            // lblInputFolderPath
            // 
            this.lblInputFolderPath.AutoSize = true;
            this.lblInputFolderPath.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputFolderPath.Location = new System.Drawing.Point(8, 15);
            this.lblInputFolderPath.Name = "lblInputFolderPath";
            this.lblInputFolderPath.Size = new System.Drawing.Size(115, 25);
            this.lblInputFolderPath.TabIndex = 1;
            this.lblInputFolderPath.Text = "Username";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.btnSaveOutputZIPPath);
            this.panel3.Controls.Add(this.btnSaveOutputZIPHelper);
            this.panel3.Controls.Add(this.txtOutputZipPath);
            this.panel3.Controls.Add(this.btnBrowseOutputZipPath);
            this.panel3.Controls.Add(this.lblOutputZipDesc);
            this.panel3.Controls.Add(this.lblOutputZipPath);
            this.panel3.Location = new System.Drawing.Point(29, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 103);
            this.panel3.TabIndex = 7;
            // 
            // btnSaveOutputZIPPath
            // 
            this.btnSaveOutputZIPPath.FlatAppearance.BorderSize = 0;
            this.btnSaveOutputZIPPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOutputZIPPath.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOutputZIPPath.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSaveOutputZIPPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveOutputZIPPath.Location = new System.Drawing.Point(475, 3);
            this.btnSaveOutputZIPPath.Name = "btnSaveOutputZIPPath";
            this.btnSaveOutputZIPPath.Size = new System.Drawing.Size(36, 34);
            this.btnSaveOutputZIPPath.TabIndex = 8;
            this.btnSaveOutputZIPPath.Text = "✔";
            this.btnSaveOutputZIPPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveOutputZIPPath.UseVisualStyleBackColor = true;
            this.btnSaveOutputZIPPath.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSaveOutputZIPHelper
            // 
            this.btnSaveOutputZIPHelper.FlatAppearance.BorderSize = 0;
            this.btnSaveOutputZIPHelper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOutputZIPHelper.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOutputZIPHelper.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSaveOutputZIPHelper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveOutputZIPHelper.Location = new System.Drawing.Point(517, 3);
            this.btnSaveOutputZIPHelper.Name = "btnSaveOutputZIPHelper";
            this.btnSaveOutputZIPHelper.Size = new System.Drawing.Size(36, 34);
            this.btnSaveOutputZIPHelper.TabIndex = 7;
            this.btnSaveOutputZIPHelper.Text = "?";
            this.btnSaveOutputZIPHelper.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveOutputZIPHelper.UseVisualStyleBackColor = true;
            // 
            // txtOutputZipPath
            // 
            this.txtOutputZipPath.Location = new System.Drawing.Point(9, 61);
            this.txtOutputZipPath.Multiline = true;
            this.txtOutputZipPath.Name = "txtOutputZipPath";
            this.txtOutputZipPath.Size = new System.Drawing.Size(419, 26);
            this.txtOutputZipPath.TabIndex = 3;
            // 
            // btnBrowseOutputZipPath
            // 
            this.btnBrowseOutputZipPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.btnBrowseOutputZipPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseOutputZipPath.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseOutputZipPath.ForeColor = System.Drawing.Color.White;
            this.btnBrowseOutputZipPath.Location = new System.Drawing.Point(434, 61);
            this.btnBrowseOutputZipPath.Name = "btnBrowseOutputZipPath";
            this.btnBrowseOutputZipPath.Size = new System.Drawing.Size(107, 26);
            this.btnBrowseOutputZipPath.TabIndex = 1;
            this.btnBrowseOutputZipPath.Text = "Browse";
            this.btnBrowseOutputZipPath.UseVisualStyleBackColor = false;
            this.btnBrowseOutputZipPath.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblOutputZipDesc
            // 
            this.lblOutputZipDesc.AutoSize = true;
            this.lblOutputZipDesc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputZipDesc.Location = new System.Drawing.Point(10, 41);
            this.lblOutputZipDesc.Name = "lblOutputZipDesc";
            this.lblOutputZipDesc.Size = new System.Drawing.Size(320, 17);
            this.lblOutputZipDesc.TabIndex = 1;
            this.lblOutputZipDesc.Text = "Please enter the password credentials for API access";
            // 
            // lblOutputZipPath
            // 
            this.lblOutputZipPath.AutoSize = true;
            this.lblOutputZipPath.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputZipPath.Location = new System.Drawing.Point(8, 15);
            this.lblOutputZipPath.Name = "lblOutputZipPath";
            this.lblOutputZipPath.Size = new System.Drawing.Size(107, 25);
            this.lblOutputZipPath.TabIndex = 1;
            this.lblOutputZipPath.Text = "Password";
            // 
            // btnCreateMapper
            // 
            this.btnCreateMapper.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCreateMapper.FlatAppearance.BorderSize = 0;
            this.btnCreateMapper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMapper.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMapper.ForeColor = System.Drawing.Color.White;
            this.btnCreateMapper.Location = new System.Drawing.Point(293, 359);
            this.btnCreateMapper.Name = "btnCreateMapper";
            this.btnCreateMapper.Size = new System.Drawing.Size(164, 38);
            this.btnCreateMapper.TabIndex = 8;
            this.btnCreateMapper.Text = "Save Settings!";
            this.btnCreateMapper.UseVisualStyleBackColor = false;
            this.btnCreateMapper.Click += new System.EventHandler(this.button9_Click);
            // 
            // CreateMapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCreateMapper);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CreateMapper";
            this.Size = new System.Drawing.Size(754, 411);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblXMLPath;
        private System.Windows.Forms.Label lblXMLPathDesc;
        private System.Windows.Forms.Button btnBrowseXMLPath;
        private System.Windows.Forms.TextBox txtXMLPath;
        private System.Windows.Forms.Button btnSaveHelper;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtInputFolderPath;
        private System.Windows.Forms.Button btnBrowseInputFolderPath;
        private System.Windows.Forms.Label lblInputFolderDesc;
        private System.Windows.Forms.Label lblInputFolderPath;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtOutputZipPath;
        private System.Windows.Forms.Button btnBrowseOutputZipPath;
        private System.Windows.Forms.Label lblOutputZipDesc;
        private System.Windows.Forms.Label lblOutputZipPath;
        private System.Windows.Forms.Button btnSaveXMLPath;
        private System.Windows.Forms.Button btnSaveInputFolderPath;
        private System.Windows.Forms.Button btnSaveInputFolderHelper;
        private System.Windows.Forms.Button btnSaveOutputZIPPath;
        private System.Windows.Forms.Button btnSaveOutputZIPHelper;
        private System.Windows.Forms.Button btnCreateMapper;

    }
}
