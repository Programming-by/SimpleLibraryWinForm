namespace SimpleLibraryWinForm.BookCopies
{
    partial class ctrlCopyDetails
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
            this.ctrlBookDetails1 = new SimpleLibraryWinForm.Books.ctrlBookDetails();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAvailabilityStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctrlBookDetails1
            // 
            this.ctrlBookDetails1.Location = new System.Drawing.Point(14, 13);
            this.ctrlBookDetails1.Name = "ctrlBookDetails1";
            this.ctrlBookDetails1.Size = new System.Drawing.Size(663, 246);
            this.ctrlBookDetails1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Availability Status:";
            // 
            // lblAvailabilityStatus
            // 
            this.lblAvailabilityStatus.AutoSize = true;
            this.lblAvailabilityStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailabilityStatus.Location = new System.Drawing.Point(214, 262);
            this.lblAvailabilityStatus.Name = "lblAvailabilityStatus";
            this.lblAvailabilityStatus.Size = new System.Drawing.Size(68, 25);
            this.lblAvailabilityStatus.TabIndex = 2;
            this.lblAvailabilityStatus.Text = "[????]";
            // 
            // ctrlCopyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAvailabilityStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlBookDetails1);
            this.Name = "ctrlCopyDetails";
            this.Size = new System.Drawing.Size(697, 321);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Books.ctrlBookDetails ctrlBookDetails1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAvailabilityStatus;
    }
}
