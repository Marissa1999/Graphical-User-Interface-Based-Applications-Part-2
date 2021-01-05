namespace DateTimePickerTest
{
    partial class DateTimePickerForm
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
            this.dropOffDateLabel = new System.Windows.Forms.Label();
            this.dateTimePickerDropOff = new System.Windows.Forms.DateTimePicker();
            this.estimatedDeliveryDateLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dropOffDateLabel
            // 
            this.dropOffDateLabel.AutoSize = true;
            this.dropOffDateLabel.Location = new System.Drawing.Point(24, 19);
            this.dropOffDateLabel.Name = "dropOffDateLabel";
            this.dropOffDateLabel.Size = new System.Drawing.Size(76, 13);
            this.dropOffDateLabel.TabIndex = 0;
            this.dropOffDateLabel.Text = "Drop Off Date:";
            // 
            // dateTimePickerDropOff
            // 
            this.dateTimePickerDropOff.CustomFormat = "dddd, MMMM dd, yyyy";
            this.dateTimePickerDropOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDropOff.Location = new System.Drawing.Point(27, 35);
            this.dateTimePickerDropOff.Name = "dateTimePickerDropOff";
            this.dateTimePickerDropOff.Size = new System.Drawing.Size(213, 20);
            this.dateTimePickerDropOff.TabIndex = 1;
            this.dateTimePickerDropOff.TabStop = false;
            this.dateTimePickerDropOff.ValueChanged += new System.EventHandler(this.dateTimePickerDropOff_ValueChanged);
            // 
            // estimatedDeliveryDateLabel
            // 
            this.estimatedDeliveryDateLabel.AutoSize = true;
            this.estimatedDeliveryDateLabel.Location = new System.Drawing.Point(24, 74);
            this.estimatedDeliveryDateLabel.Name = "estimatedDeliveryDateLabel";
            this.estimatedDeliveryDateLabel.Size = new System.Drawing.Size(123, 13);
            this.estimatedDeliveryDateLabel.TabIndex = 2;
            this.estimatedDeliveryDateLabel.Text = "Estimated Delivery Date:";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Location = new System.Drawing.Point(27, 96);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(213, 24);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateTimePickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 144);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.estimatedDeliveryDateLabel);
            this.Controls.Add(this.dateTimePickerDropOff);
            this.Controls.Add(this.dropOffDateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DateTimePickerForm";
            this.Text = "DateTimePickerTest";
            this.Load += new System.EventHandler(this.DateTimePickerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dropOffDateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerDropOff;
        private System.Windows.Forms.Label estimatedDeliveryDateLabel;
        private System.Windows.Forms.Label outputLabel;
    }
}

