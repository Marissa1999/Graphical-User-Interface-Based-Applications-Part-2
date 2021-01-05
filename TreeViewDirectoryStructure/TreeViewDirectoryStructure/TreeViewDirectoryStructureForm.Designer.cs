namespace TreeViewDirectoryStructure
{
    partial class TreeViewDirectoryStructureForm
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
            this.directoryPathLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.directoryTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // directoryPathLabel
            // 
            this.directoryPathLabel.Location = new System.Drawing.Point(5, 17);
            this.directoryPathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.directoryPathLabel.Name = "directoryPathLabel";
            this.directoryPathLabel.Size = new System.Drawing.Size(303, 15);
            this.directoryPathLabel.TabIndex = 0;
            this.directoryPathLabel.Text = "Enter the full path to the directory you would like to view:";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(8, 34);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(237, 20);
            this.inputTextBox.TabIndex = 1;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(254, 32);
            this.enterButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(76, 26);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // directoryTreeView
            // 
            this.directoryTreeView.Location = new System.Drawing.Point(8, 62);
            this.directoryTreeView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.directoryTreeView.Name = "directoryTreeView";
            this.directoryTreeView.Size = new System.Drawing.Size(323, 247);
            this.directoryTreeView.TabIndex = 3;
            // 
            // TreeViewDirectoryStructureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 316);
            this.Controls.Add(this.directoryTreeView);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.directoryPathLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TreeViewDirectoryStructureForm";
            this.Text = "TreeViewDirectoryStructure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label directoryPathLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TreeView directoryTreeView;
    }
}

