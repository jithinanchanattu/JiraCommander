namespace CodeReaper
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.NavPanel = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnHomeHelp = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Version = new System.Windows.Forms.Label();
            this.CodeReaper = new System.Windows.Forms.Label();
            this.CodeReaperLogo = new System.Windows.Forms.PictureBox();
            this.LicenseInfo = new System.Windows.Forms.Label();
            this.Notifications = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.CreateControl = new CodeReaper.CreatePlayground();
            this.mySecondCustmControl1 = new CodeReaper.CreateMapper();
            this.NavPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CodeReaperLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.NavPanel.Controls.Add(this.SidePanel);
            this.NavPanel.Controls.Add(this.btnHomeHelp);
            this.NavPanel.Controls.Add(this.btnSettings);
            this.NavPanel.Controls.Add(this.btnHome);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavPanel.Location = new System.Drawing.Point(0, 0);
            this.NavPanel.Margin = new System.Windows.Forms.Padding(4);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(279, 718);
            this.NavPanel.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 75);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(13, 66);
            this.SidePanel.TabIndex = 4;
            // 
            // btnHomeHelp
            // 
            this.btnHomeHelp.FlatAppearance.BorderSize = 0;
            this.btnHomeHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeHelp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeHelp.ForeColor = System.Drawing.Color.White;
            this.btnHomeHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeHelp.Location = new System.Drawing.Point(4, 672);
            this.btnHomeHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHomeHelp.Name = "btnHomeHelp";
            this.btnHomeHelp.Size = new System.Drawing.Size(48, 42);
            this.btnHomeHelp.TabIndex = 4;
            this.btnHomeHelp.Text = "?";
            this.btnHomeHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHomeHelp.UseVisualStyleBackColor = true;
            this.btnHomeHelp.Click += new System.EventHandler(this.button14_Click_1);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(16, 139);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(263, 66);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "       Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(16, 73);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(263, 66);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "       Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(279, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 12);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Controls.Add(this.Version);
            this.panel3.Controls.Add(this.CodeReaper);
            this.panel3.Controls.Add(this.CodeReaperLogo);
            this.panel3.Location = new System.Drawing.Point(324, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 183);
            this.panel3.TabIndex = 2;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version.ForeColor = System.Drawing.Color.Gray;
            this.Version.Location = new System.Drawing.Point(58, 150);
            this.Version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(55, 19);
            this.Version.TabIndex = 3;
            this.Version.Text = "Ver 2.0";
            // 
            // CodeReaper
            // 
            this.CodeReaper.AutoSize = true;
            this.CodeReaper.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.CodeReaper.ForeColor = System.Drawing.Color.DimGray;
            this.CodeReaper.Location = new System.Drawing.Point(8, 122);
            this.CodeReaper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CodeReaper.Name = "CodeReaper";
            this.CodeReaper.Size = new System.Drawing.Size(141, 19);
            this.CodeReaper.TabIndex = 3;
            this.CodeReaper.Text = "JiraCommander";
            // 
            // CodeReaperLogo
            // 
            this.CodeReaperLogo.Image = ((System.Drawing.Image)(resources.GetObject("CodeReaperLogo.Image")));
            this.CodeReaperLogo.Location = new System.Drawing.Point(26, 4);
            this.CodeReaperLogo.Margin = new System.Windows.Forms.Padding(4);
            this.CodeReaperLogo.Name = "CodeReaperLogo";
            this.CodeReaperLogo.Size = new System.Drawing.Size(113, 102);
            this.CodeReaperLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CodeReaperLogo.TabIndex = 4;
            this.CodeReaperLogo.TabStop = false;
            // 
            // LicenseInfo
            // 
            this.LicenseInfo.AutoSize = true;
            this.LicenseInfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseInfo.Location = new System.Drawing.Point(1093, 36);
            this.LicenseInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LicenseInfo.Name = "LicenseInfo";
            this.LicenseInfo.Size = new System.Drawing.Size(100, 21);
            this.LicenseInfo.TabIndex = 3;
            this.LicenseInfo.Text = "MIT Licensed";
            this.LicenseInfo.Click += new System.EventHandler(this.label4_Click);
            // 
            // Notifications
            // 
            this.Notifications.FlatAppearance.BorderSize = 0;
            this.Notifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Notifications.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notifications.ForeColor = System.Drawing.Color.White;
            this.Notifications.Image = ((System.Drawing.Image)(resources.GetObject("Notifications.Image")));
            this.Notifications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Notifications.Location = new System.Drawing.Point(1201, 23);
            this.Notifications.Margin = new System.Windows.Forms.Padding(4);
            this.Notifications.Name = "Notifications";
            this.Notifications.Size = new System.Drawing.Size(43, 43);
            this.Notifications.TabIndex = 4;
            this.Notifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Notifications.UseVisualStyleBackColor = true;
            this.Notifications.Click += new System.EventHandler(this.button11_Click);
            // 
            // Settings
            // 
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.White;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(1252, 23);
            this.Settings.Margin = new System.Windows.Forms.Padding(4);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(43, 43);
            this.Settings.TabIndex = 4;
            this.Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // Logout
            // 
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Image = ((System.Drawing.Image)(resources.GetObject("Logout.Image")));
            this.Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logout.Location = new System.Drawing.Point(1303, 23);
            this.Logout.Margin = new System.Windows.Forms.Padding(4);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(43, 43);
            this.Logout.TabIndex = 4;
            this.Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.button13_Click);
            // 
            // CreateControl
            // 
            this.CreateControl.Location = new System.Drawing.Point(287, 192);
            this.CreateControl.Margin = new System.Windows.Forms.Padding(5);
            this.CreateControl.Name = "CreateControl";
            this.CreateControl.Size = new System.Drawing.Size(1065, 521);
            this.CreateControl.TabIndex = 5;
            this.CreateControl.Load += new System.EventHandler(this.firstCustomControl1_Load);
            // 
            // mySecondCustmControl1
            // 
            this.mySecondCustmControl1.Location = new System.Drawing.Point(287, 192);
            this.mySecondCustmControl1.Margin = new System.Windows.Forms.Padding(5);
            this.mySecondCustmControl1.Name = "mySecondCustmControl1";
            this.mySecondCustmControl1.Size = new System.Drawing.Size(1081, 500);
            this.mySecondCustmControl1.TabIndex = 6;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 718);
            this.Controls.Add(this.LicenseInfo);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Notifications);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.NavPanel);
            this.Controls.Add(this.CreateControl);
            this.Controls.Add(this.mySecondCustmControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jira Commander";
            this.NavPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CodeReaperLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label CodeReaper;
        private System.Windows.Forms.PictureBox CodeReaperLogo;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnHomeHelp;
        private System.Windows.Forms.Label LicenseInfo;
        private System.Windows.Forms.Button Notifications;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Logout;
        private CreatePlayground CreateControl;
        private CreateMapper mySecondCustmControl1;
    }
}

