namespace SimpleLibraryWinForm.Borrowing_Records
{
    partial class frmAddEditBorrowingRecord
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TabControl();
            this.tbCopyInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbRecordInfo = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerOfDueDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOfBorrowingDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRecordID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlCopyDetailsWithFilter1 = new SimpleLibraryWinForm.BookCopies.Controls.ctrlCopyDetailsWithFilter();
            this.tbInfo.SuspendLayout();
            this.tbCopyInfo.SuspendLayout();
            this.tbRecordInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(281, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(361, 32);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Add New Borrowing Record";
            // 
            // tbInfo
            // 
            this.tbInfo.Controls.Add(this.tbCopyInfo);
            this.tbInfo.Controls.Add(this.tbRecordInfo);
            this.tbInfo.Location = new System.Drawing.Point(32, 79);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.SelectedIndex = 0;
            this.tbInfo.Size = new System.Drawing.Size(922, 428);
            this.tbInfo.TabIndex = 41;
            // 
            // tbCopyInfo
            // 
            this.tbCopyInfo.Controls.Add(this.ctrlCopyDetailsWithFilter1);
            this.tbCopyInfo.Controls.Add(this.btnNext);
            this.tbCopyInfo.Location = new System.Drawing.Point(4, 25);
            this.tbCopyInfo.Name = "tbCopyInfo";
            this.tbCopyInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbCopyInfo.Size = new System.Drawing.Size(914, 399);
            this.tbCopyInfo.TabIndex = 0;
            this.tbCopyInfo.Text = "Copy Info";
            this.tbCopyInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(717, 276);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 54);
            this.btnNext.TabIndex = 41;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbRecordInfo
            // 
            this.tbRecordInfo.Controls.Add(this.label3);
            this.tbRecordInfo.Controls.Add(this.label1);
            this.tbRecordInfo.Controls.Add(this.dateTimePickerOfDueDate);
            this.tbRecordInfo.Controls.Add(this.dateTimePickerOfBorrowingDate);
            this.tbRecordInfo.Controls.Add(this.numericUpDown1);
            this.tbRecordInfo.Controls.Add(this.label2);
            this.tbRecordInfo.Controls.Add(this.label4);
            this.tbRecordInfo.Controls.Add(this.lblRecordID);
            this.tbRecordInfo.Location = new System.Drawing.Point(4, 25);
            this.tbRecordInfo.Name = "tbRecordInfo";
            this.tbRecordInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbRecordInfo.Size = new System.Drawing.Size(914, 399);
            this.tbRecordInfo.TabIndex = 1;
            this.tbRecordInfo.Text = "Record Info";
            this.tbRecordInfo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Due Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Borrowing Date:";
            // 
            // dateTimePickerOfDueDate
            // 
            this.dateTimePickerOfDueDate.Location = new System.Drawing.Point(231, 228);
            this.dateTimePickerOfDueDate.Name = "dateTimePickerOfDueDate";
            this.dateTimePickerOfDueDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerOfDueDate.TabIndex = 37;
            // 
            // dateTimePickerOfBorrowingDate
            // 
            this.dateTimePickerOfBorrowingDate.Location = new System.Drawing.Point(231, 169);
            this.dateTimePickerOfBorrowingDate.Name = "dateTimePickerOfBorrowingDate";
            this.dateTimePickerOfBorrowingDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerOfBorrowingDate.TabIndex = 36;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(231, 113);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 34;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "UserID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "RecordID:";
            // 
            // lblRecordID
            // 
            this.lblRecordID.AutoSize = true;
            this.lblRecordID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordID.Location = new System.Drawing.Point(226, 58);
            this.lblRecordID.Name = "lblRecordID";
            this.lblRecordID.Size = new System.Drawing.Size(45, 25);
            this.lblRecordID.TabIndex = 33;
            this.lblRecordID.Text = "???";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(753, 513);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 54);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(473, 513);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 54);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlCopyDetailsWithFilter1
            // 
            this.ctrlCopyDetailsWithFilter1.FilteredEnabled = true;
            this.ctrlCopyDetailsWithFilter1.Location = new System.Drawing.Point(6, 6);
            this.ctrlCopyDetailsWithFilter1.Name = "ctrlCopyDetailsWithFilter1";
            this.ctrlCopyDetailsWithFilter1.Size = new System.Drawing.Size(693, 378);
            this.ctrlCopyDetailsWithFilter1.TabIndex = 42;
            // 
            // frmAddEditBorrowingRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 590);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditBorrowingRecord";
            this.Text = "frmAddEditBorrowingRecord";
            this.Activated += new System.EventHandler(this.frmAddEditBorrowingRecord_Activated);
            this.Load += new System.EventHandler(this.frmAddEditBorrowingRecord_Load);
            this.tbInfo.ResumeLayout(false);
            this.tbCopyInfo.ResumeLayout(false);
            this.tbRecordInfo.ResumeLayout(false);
            this.tbRecordInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tbInfo;
        private System.Windows.Forms.TabPage tbCopyInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tbRecordInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRecordID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private BookCopies.Controls.ctrlCopyDetailsWithFilter ctrlCopyDetailsWithFilter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerOfDueDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerOfBorrowingDate;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}