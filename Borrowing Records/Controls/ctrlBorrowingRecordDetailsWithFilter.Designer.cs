namespace SimpleLibraryWinForm.Borrowing_Records.Controls
{
    partial class ctrlBorrowingRecordDetailsWithFilter
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
            this.gpFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewCopy = new System.Windows.Forms.Button();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.ctrlBorrowingRecordDetails1 = new SimpleLibraryWinForm.Borrowing_Records.Controls.ctrlBorrowingRecordDetails();
            this.gpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpFilter
            // 
            this.gpFilter.Controls.Add(this.label1);
            this.gpFilter.Controls.Add(this.btnAddNewCopy);
            this.gpFilter.Controls.Add(this.txtFilterBy);
            this.gpFilter.Controls.Add(this.btnFind);
            this.gpFilter.Location = new System.Drawing.Point(3, 3);
            this.gpFilter.Name = "gpFilter";
            this.gpFilter.Size = new System.Drawing.Size(638, 71);
            this.gpFilter.TabIndex = 6;
            this.gpFilter.TabStop = false;
            this.gpFilter.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "RecordID:";
            // 
            // btnAddNewCopy
            // 
            this.btnAddNewCopy.Location = new System.Drawing.Point(477, 21);
            this.btnAddNewCopy.Name = "btnAddNewCopy";
            this.btnAddNewCopy.Size = new System.Drawing.Size(75, 39);
            this.btnAddNewCopy.TabIndex = 4;
            this.btnAddNewCopy.Text = "Add";
            this.btnAddNewCopy.UseVisualStyleBackColor = true;
            this.btnAddNewCopy.Click += new System.EventHandler(this.btnAddNewRecord_Click);
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Location = new System.Drawing.Point(158, 25);
            this.txtFilterBy.Multiline = true;
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(232, 29);
            this.txtFilterBy.TabIndex = 0;
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(396, 21);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 39);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // ctrlBorrowingRecordDetails1
            // 
            this.ctrlBorrowingRecordDetails1.Location = new System.Drawing.Point(3, 76);
            this.ctrlBorrowingRecordDetails1.Name = "ctrlBorrowingRecordDetails1";
            this.ctrlBorrowingRecordDetails1.Size = new System.Drawing.Size(662, 239);
            this.ctrlBorrowingRecordDetails1.TabIndex = 7;
            // 
            // ctrlBorrowingRecordDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlBorrowingRecordDetails1);
            this.Controls.Add(this.gpFilter);
            this.Name = "ctrlBorrowingRecordDetailsWithFilter";
            this.Size = new System.Drawing.Size(707, 323);
            this.gpFilter.ResumeLayout(false);
            this.gpFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewCopy;
        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.Button btnFind;
        private ctrlBorrowingRecordDetails ctrlBorrowingRecordDetails1;
    }
}
