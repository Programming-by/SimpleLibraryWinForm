namespace SimpleLibraryWinForm.Borrowing_Records
{
    partial class frmShowRecordDetails
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
            this.ctrlBorrowingRecordDetails1 = new SimpleLibraryWinForm.Borrowing_Records.Controls.ctrlBorrowingRecordDetails();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "Show Borrowing Record Details";
            // 
            // ctrlBorrowingRecordDetails1
            // 
            this.ctrlBorrowingRecordDetails1.Location = new System.Drawing.Point(2, 93);
            this.ctrlBorrowingRecordDetails1.Name = "ctrlBorrowingRecordDetails1";
            this.ctrlBorrowingRecordDetails1.Size = new System.Drawing.Size(704, 241);
            this.ctrlBorrowingRecordDetails1.TabIndex = 30;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(612, 331);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 48);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowRecordDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 389);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlBorrowingRecordDetails1);
            this.Controls.Add(this.label1);
            this.Name = "frmShowRecordDetails";
            this.Text = "frmShowRecordDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.ctrlBorrowingRecordDetails ctrlBorrowingRecordDetails1;
        private System.Windows.Forms.Button btnClose;
    }
}