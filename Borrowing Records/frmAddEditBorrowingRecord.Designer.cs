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
            this.ctrlCopyDetailsWithFilter1 = new SimpleLibraryWinForm.BookCopies.Controls.ctrlCopyDetailsWithFilter();
            this.btnNextToRecordInfo = new System.Windows.Forms.Button();
            this.tbRecordInfo = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerOfDueDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOfBorrowingDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRecordID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbUserInfo = new System.Windows.Forms.TabPage();
            this.ctrlUserDetailsWithFilter1 = new SimpleLibraryWinForm.Users.Controls.ctrlUserDetailsWithFilter();
            this.btnNextToCopyInfo = new System.Windows.Forms.Button();
            this.tbInfo.SuspendLayout();
            this.tbCopyInfo.SuspendLayout();
            this.tbRecordInfo.SuspendLayout();
            this.tbUserInfo.SuspendLayout();
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
            this.tbInfo.Controls.Add(this.tbUserInfo);
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
            this.tbCopyInfo.Controls.Add(this.btnNextToRecordInfo);
            this.tbCopyInfo.Location = new System.Drawing.Point(4, 25);
            this.tbCopyInfo.Name = "tbCopyInfo";
            this.tbCopyInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbCopyInfo.Size = new System.Drawing.Size(914, 399);
            this.tbCopyInfo.TabIndex = 0;
            this.tbCopyInfo.Text = "Copy Info";
            this.tbCopyInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlCopyDetailsWithFilter1
            // 
            this.ctrlCopyDetailsWithFilter1.FilteredEnabled = true;
            this.ctrlCopyDetailsWithFilter1.Location = new System.Drawing.Point(6, 6);
            this.ctrlCopyDetailsWithFilter1.Name = "ctrlCopyDetailsWithFilter1";
            this.ctrlCopyDetailsWithFilter1.Size = new System.Drawing.Size(693, 378);
            this.ctrlCopyDetailsWithFilter1.TabIndex = 42;
            // 
            // btnNextToRecordInfo
            // 
            this.btnNextToRecordInfo.Location = new System.Drawing.Point(717, 276);
            this.btnNextToRecordInfo.Name = "btnNextToRecordInfo";
            this.btnNextToRecordInfo.Size = new System.Drawing.Size(75, 54);
            this.btnNextToRecordInfo.TabIndex = 41;
            this.btnNextToRecordInfo.Text = "Next";
            this.btnNextToRecordInfo.UseVisualStyleBackColor = true;
            this.btnNextToRecordInfo.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbRecordInfo
            // 
            this.tbRecordInfo.Controls.Add(this.label3);
            this.tbRecordInfo.Controls.Add(this.label1);
            this.tbRecordInfo.Controls.Add(this.dateTimePickerOfDueDate);
            this.tbRecordInfo.Controls.Add(this.dateTimePickerOfBorrowingDate);
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
            this.label3.Location = new System.Drawing.Point(95, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Due Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Borrowing Date:";
            // 
            // dateTimePickerOfDueDate
            // 
            this.dateTimePickerOfDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOfDueDate.Location = new System.Drawing.Point(312, 228);
            this.dateTimePickerOfDueDate.Name = "dateTimePickerOfDueDate";
            this.dateTimePickerOfDueDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerOfDueDate.TabIndex = 37;
            // 
            // dateTimePickerOfBorrowingDate
            // 
            this.dateTimePickerOfBorrowingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOfBorrowingDate.Location = new System.Drawing.Point(312, 166);
            this.dateTimePickerOfBorrowingDate.Name = "dateTimePickerOfBorrowingDate";
            this.dateTimePickerOfBorrowingDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerOfBorrowingDate.TabIndex = 36;
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
            this.lblRecordID.Location = new System.Drawing.Point(296, 58);
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
            // tbUserInfo
            // 
            this.tbUserInfo.Controls.Add(this.btnNextToCopyInfo);
            this.tbUserInfo.Controls.Add(this.ctrlUserDetailsWithFilter1);
            this.tbUserInfo.Location = new System.Drawing.Point(4, 25);
            this.tbUserInfo.Name = "tbUserInfo";
            this.tbUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbUserInfo.Size = new System.Drawing.Size(914, 399);
            this.tbUserInfo.TabIndex = 2;
            this.tbUserInfo.Text = "User Info";
            this.tbUserInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlUserDetailsWithFilter1
            // 
            this.ctrlUserDetailsWithFilter1.Location = new System.Drawing.Point(0, 3);
            this.ctrlUserDetailsWithFilter1.Name = "ctrlUserDetailsWithFilter1";
            this.ctrlUserDetailsWithFilter1.Size = new System.Drawing.Size(674, 356);
            this.ctrlUserDetailsWithFilter1.TabIndex = 0;
            // 
            // btnNextToCopyInfo
            // 
            this.btnNextToCopyInfo.Location = new System.Drawing.Point(727, 294);
            this.btnNextToCopyInfo.Name = "btnNextToCopyInfo";
            this.btnNextToCopyInfo.Size = new System.Drawing.Size(75, 54);
            this.btnNextToCopyInfo.TabIndex = 43;
            this.btnNextToCopyInfo.Text = "Next";
            this.btnNextToCopyInfo.UseVisualStyleBackColor = true;
            this.btnNextToCopyInfo.Click += new System.EventHandler(this.btnNextToCopyInfo_Click);
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
            this.tbUserInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tbInfo;
        private System.Windows.Forms.TabPage tbCopyInfo;
        private System.Windows.Forms.Button btnNextToRecordInfo;
        private System.Windows.Forms.TabPage tbRecordInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRecordID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private BookCopies.Controls.ctrlCopyDetailsWithFilter ctrlCopyDetailsWithFilter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerOfDueDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerOfBorrowingDate;
        private System.Windows.Forms.TabPage tbUserInfo;
        private System.Windows.Forms.Button btnNextToCopyInfo;
        private Users.Controls.ctrlUserDetailsWithFilter ctrlUserDetailsWithFilter1;
    }
}