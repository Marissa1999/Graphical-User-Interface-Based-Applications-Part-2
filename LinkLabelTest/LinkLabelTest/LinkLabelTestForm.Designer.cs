﻿namespace LinkLabelTest
{
    partial class LinkLabelTestForm
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
            this.driveLinkLabel = new System.Windows.Forms.LinkLabel();
            this.deitelLinkLabel = new System.Windows.Forms.LinkLabel();
            this.notepadLinkLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.vanierLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // driveLinkLabel
            // 
            this.driveLinkLabel.AutoSize = true;
            this.driveLinkLabel.Location = new System.Drawing.Point(26, 24);
            this.driveLinkLabel.Name = "driveLinkLabel";
            this.driveLinkLabel.Size = new System.Drawing.Size(97, 13);
            this.driveLinkLabel.TabIndex = 0;
            this.driveLinkLabel.TabStop = true;
            this.driveLinkLabel.Text = "Click to browse C:\\";
            this.driveLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.driveLinkLabel_LinkClicked);
            // 
            // deitelLinkLabel
            // 
            this.deitelLinkLabel.AutoSize = true;
            this.deitelLinkLabel.Location = new System.Drawing.Point(26, 52);
            this.deitelLinkLabel.Name = "deitelLinkLabel";
            this.deitelLinkLabel.Size = new System.Drawing.Size(141, 13);
            this.deitelLinkLabel.TabIndex = 1;
            this.deitelLinkLabel.TabStop = true;
            this.deitelLinkLabel.Text = "Click to visit www.deitel.com";
            this.deitelLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.deitelLinkLabel_LinkClicked);
            // 
            // notepadLinkLabel
            // 
            this.notepadLinkLabel.AutoSize = true;
            this.notepadLinkLabel.Location = new System.Drawing.Point(26, 81);
            this.notepadLinkLabel.Name = "notepadLinkLabel";
            this.notepadLinkLabel.Size = new System.Drawing.Size(104, 13);
            this.notepadLinkLabel.TabIndex = 2;
            this.notepadLinkLabel.TabStop = true;
            this.notepadLinkLabel.Text = "Click to run Notepad";
            this.notepadLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.notepadLinkLabel_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(26, 107);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 3;
            // 
            // vanierLinkLabel
            // 
            this.vanierLinkLabel.AutoSize = true;
            this.vanierLinkLabel.Location = new System.Drawing.Point(26, 107);
            this.vanierLinkLabel.Name = "vanierLinkLabel";
            this.vanierLinkLabel.Size = new System.Drawing.Size(227, 13);
            this.vanierLinkLabel.TabIndex = 4;
            this.vanierLinkLabel.TabStop = true;
            this.vanierLinkLabel.Text = "Click to visit https://www.vaniercollege.qc.ca/";
            this.vanierLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.vanierLinkLabel_LinkClicked);
            // 
            // LinkLabelTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 136);
            this.Controls.Add(this.vanierLinkLabel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.notepadLinkLabel);
            this.Controls.Add(this.deitelLinkLabel);
            this.Controls.Add(this.driveLinkLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LinkLabelTestForm";
            this.Text = "LinkLabelTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel driveLinkLabel;
        private System.Windows.Forms.LinkLabel deitelLinkLabel;
        private System.Windows.Forms.LinkLabel notepadLinkLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel vanierLinkLabel;
    }
}

