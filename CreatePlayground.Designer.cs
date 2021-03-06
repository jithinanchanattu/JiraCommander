﻿namespace CodeReaper
{
    partial class CreatePlayground
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePlayground));
            this.NoteHomeTitle = new System.Windows.Forms.Label();
            this.NoteWelcome = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.NoteWarning = new System.Windows.Forms.Label();
            this.NoteHeader = new System.Windows.Forms.Label();
            this.imgProcessing = new System.Windows.Forms.PictureBox();
            this.lblProcessing = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.infoCompleted = new System.Windows.Forms.Label();
            this.btnShowFiles = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.rhInputJiraIDs = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rhComments = new System.Windows.Forms.RichTextBox();
            this.rhstatusId = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgProcessing)).BeginInit();
            this.SuspendLayout();
            // 
            // NoteHomeTitle
            // 
            this.NoteHomeTitle.AutoSize = true;
            this.NoteHomeTitle.Font = new System.Drawing.Font("Century Gothic", 22.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteHomeTitle.Location = new System.Drawing.Point(37, 279);
            this.NoteHomeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NoteHomeTitle.Name = "NoteHomeTitle";
            this.NoteHomeTitle.Size = new System.Drawing.Size(583, 44);
            this.NoteHomeTitle.TabIndex = 0;
            this.NoteHomeTitle.Text = "Click to authenticate your Job!";
            // 
            // NoteWelcome
            // 
            this.NoteWelcome.AutoSize = true;
            this.NoteWelcome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteWelcome.Location = new System.Drawing.Point(43, 49);
            this.NoteWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NoteWelcome.Name = "NoteWelcome";
            this.NoteWelcome.Size = new System.Drawing.Size(318, 22);
            this.NoteWelcome.TabIndex = 0;
            this.NoteWelcome.Text = "Welcome to the Jira Commander!";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(45, 338);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(219, 47);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Authenticate!";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // NoteWarning
            // 
            this.NoteWarning.AutoSize = true;
            this.NoteWarning.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteWarning.Location = new System.Drawing.Point(43, 436);
            this.NoteWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NoteWarning.Name = "NoteWarning";
            this.NoteWarning.Size = new System.Drawing.Size(414, 20);
            this.NoteWarning.TabIndex = 0;
            this.NoteWarning.Text = "Please make sure the values in Settings Tab are Correct.";
            // 
            // NoteHeader
            // 
            this.NoteHeader.AutoSize = true;
            this.NoteHeader.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteHeader.Location = new System.Drawing.Point(43, 410);
            this.NoteHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NoteHeader.Name = "NoteHeader";
            this.NoteHeader.Size = new System.Drawing.Size(99, 18);
            this.NoteHeader.TabIndex = 2;
            this.NoteHeader.Text = "Please Note:";
            // 
            // imgProcessing
            // 
            this.imgProcessing.Image = ((System.Drawing.Image)(resources.GetObject("imgProcessing.Image")));
            this.imgProcessing.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgProcessing.InitialImage")));
            this.imgProcessing.Location = new System.Drawing.Point(435, 100);
            this.imgProcessing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgProcessing.Name = "imgProcessing";
            this.imgProcessing.Size = new System.Drawing.Size(219, 256);
            this.imgProcessing.TabIndex = 3;
            this.imgProcessing.TabStop = false;
            this.imgProcessing.Visible = false;
            // 
            // lblProcessing
            // 
            this.lblProcessing.AutoSize = true;
            this.lblProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessing.Location = new System.Drawing.Point(477, 54);
            this.lblProcessing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcessing.Name = "lblProcessing";
            this.lblProcessing.Size = new System.Drawing.Size(102, 17);
            this.lblProcessing.TabIndex = 4;
            this.lblProcessing.Text = "Processing..!";
            this.lblProcessing.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Tomato;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(420, 415);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(219, 47);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel!";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // infoCompleted
            // 
            this.infoCompleted.AutoSize = true;
            this.infoCompleted.Font = new System.Drawing.Font("Century Gothic", 22.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoCompleted.Location = new System.Drawing.Point(317, 239);
            this.infoCompleted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.infoCompleted.Name = "infoCompleted";
            this.infoCompleted.Size = new System.Drawing.Size(446, 44);
            this.infoCompleted.TabIndex = 6;
            this.infoCompleted.Text = "Processing Completed!";
            this.infoCompleted.Visible = false;
            // 
            // btnShowFiles
            // 
            this.btnShowFiles.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnShowFiles.FlatAppearance.BorderSize = 0;
            this.btnShowFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFiles.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFiles.ForeColor = System.Drawing.Color.White;
            this.btnShowFiles.Location = new System.Drawing.Point(319, 287);
            this.btnShowFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowFiles.Name = "btnShowFiles";
            this.btnShowFiles.Size = new System.Drawing.Size(219, 47);
            this.btnShowFiles.TabIndex = 7;
            this.btnShowFiles.Text = "Verify";
            this.btnShowFiles.UseVisualStyleBackColor = false;
            this.btnShowFiles.Visible = false;
            this.btnShowFiles.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Gold;
            this.btnPlayAgain.FlatAppearance.BorderSize = 0;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.Black;
            this.btnPlayAgain.Location = new System.Drawing.Point(545, 287);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(219, 47);
            this.btnPlayAgain.TabIndex = 8;
            this.btnPlayAgain.Text = "Try Again!";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.button4_Click);
            // 
            // rhInputJiraIDs
            // 
            this.rhInputJiraIDs.Location = new System.Drawing.Point(47, 108);
            this.rhInputJiraIDs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rhInputJiraIDs.Name = "rhInputJiraIDs";
            this.rhInputJiraIDs.Size = new System.Drawing.Size(605, 127);
            this.rhInputJiraIDs.TabIndex = 9;
            this.rhInputJiraIDs.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.label1.Location = new System.Drawing.Point(43, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter the Jira Ids (comma seperated)*";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(272, 338);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Status Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(499, 338);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 47);
            this.button2.TabIndex = 12;
            this.button2.Text = "Comment";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.label2.Location = new System.Drawing.Point(661, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter the Jira Comment (if any)";
            // 
            // rhComments
            // 
            this.rhComments.Location = new System.Drawing.Point(665, 108);
            this.rhComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rhComments.Name = "rhComments";
            this.rhComments.Size = new System.Drawing.Size(393, 89);
            this.rhComments.TabIndex = 14;
            this.rhComments.Text = "";
            // 
            // rhstatusId
            // 
            this.rhstatusId.Location = new System.Drawing.Point(912, 203);
            this.rhstatusId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rhstatusId.Name = "rhstatusId";
            this.rhstatusId.Size = new System.Drawing.Size(147, 32);
            this.rhstatusId.TabIndex = 15;
            this.rhstatusId.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.label3.Location = new System.Drawing.Point(664, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Manual Status Change (id)";
            // 
            // CreatePlayground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rhstatusId);
            this.Controls.Add(this.rhComments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rhInputJiraIDs);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnShowFiles);
            this.Controls.Add(this.infoCompleted);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblProcessing);
            this.Controls.Add(this.imgProcessing);
            this.Controls.Add(this.NoteHeader);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.NoteHomeTitle);
            this.Controls.Add(this.NoteWelcome);
            this.Controls.Add(this.NoteWarning);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreatePlayground";
            this.Size = new System.Drawing.Size(1084, 521);
            ((System.ComponentModel.ISupportInitialize)(this.imgProcessing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoteHomeTitle;
        private System.Windows.Forms.Label NoteWelcome;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label NoteWarning;
        private System.Windows.Forms.Label NoteHeader;
        private System.Windows.Forms.PictureBox imgProcessing;
        private System.Windows.Forms.Label lblProcessing;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label infoCompleted;
        private System.Windows.Forms.Button btnShowFiles;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.RichTextBox rhInputJiraIDs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rhComments;
        private System.Windows.Forms.RichTextBox rhstatusId;
        private System.Windows.Forms.Label label3;
    }
}
