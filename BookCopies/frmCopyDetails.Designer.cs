namespace SimpleLibraryWinForm.BookCopies
{
    partial class frmCopyDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlCopyDetails1 = new SimpleLibraryWinForm.BookCopies.ctrlCopyDetails();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Book Copy Details";
            // 
            // ctrlCopyDetails1
            // 
            this.ctrlCopyDetails1.Location = new System.Drawing.Point(23, 84);
            this.ctrlCopyDetails1.Name = "ctrlCopyDetails1";
            this.ctrlCopyDetails1.Size = new System.Drawing.Size(697, 321);
            this.ctrlCopyDetails1.TabIndex = 21;
            // 
            // frmCopyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlCopyDetails1);
            this.Controls.Add(this.label1);
            this.Name = "frmCopyDetails";
            this.Text = "frmCopyDetails";
            this.Load += new System.EventHandler(this.frmCopyDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ctrlCopyDetails ctrlCopyDetails1;
    }
}