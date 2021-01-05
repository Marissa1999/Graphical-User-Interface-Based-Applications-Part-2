namespace CheckedListBoxTest
{
    partial class CheckedListBoxTest
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
            this.itemCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // itemCheckedListBox
            // 
            this.itemCheckedListBox.FormattingEnabled = true;
            this.itemCheckedListBox.Items.AddRange(new object[] {
            "C HTTP",
            "C++ HTP",
            "Internet & WWW HTP",
            "Java HTP",
            "Visual Basic HTP",
            "Visual C++ HTP",
            "Visual C# HTP"});
            this.itemCheckedListBox.Location = new System.Drawing.Point(24, 33);
            this.itemCheckedListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemCheckedListBox.Name = "itemCheckedListBox";
            this.itemCheckedListBox.Size = new System.Drawing.Size(222, 151);
            this.itemCheckedListBox.TabIndex = 0;
            this.itemCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.itemCheckedListBox_ItemCheck);
            // 
            // displayListBox
            // 
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.ItemHeight = 20;
            this.displayListBox.Location = new System.Drawing.Point(268, 33);
            this.displayListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(230, 144);
            this.displayListBox.TabIndex = 1;
            // 
            // CheckedListBoxTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 202);
            this.Controls.Add(this.displayListBox);
            this.Controls.Add(this.itemCheckedListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CheckedListBoxTest";
            this.Text = "CheckListBoxTest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox itemCheckedListBox;
        private System.Windows.Forms.ListBox displayListBox;
    }
}

