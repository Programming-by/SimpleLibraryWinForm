namespace SimpleLibraryWinForm.Fines
{
    partial class frmAddEditFine
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
            this.label4 = new System.Windows.Forms.Label();
            this.lblFineID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumberOfLateDays = new System.Windows.Forms.Label();
            this.lblFineAmount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbInfo = new System.Windows.Forms.TabControl();
            this.tbUserInfo = new System.Windows.Forms.TabPage();
            this.btnNextToRecordInfo = new System.Windows.Forms.Button();
            this.tbRecordInfo = new System.Windows.Forms.TabPage();
            this.btnNextToFineInfo = new System.Windows.Forms.Button();
            this.tbFineInfo = new System.Windows.Forms.TabPage();
            this.ctrlUserDetailsWithFilter1 = new SimpleLibraryWinForm.Users.Controls.ctrlUserDetailsWithFilter();
            this.ctrlBorrowingRecordDetailsWithFilter1 = new SimpleLibraryWinForm.Borrowing_Records.Controls.ctrlBorrowingRecordDetailsWithFilter();
            this.rbPaid = new System.Windows.Forms.RadioButton();
            this.rbNotPaid = new System.Windows.Forms.RadioButton();
            this.tbInfo.SuspendLayout();
            this.tbUserInfo.SuspendLayout();
            this.tbRecordInfo.SuspendLayout();
            this.tbFineInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(324, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 32);
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "Add New Fine";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "FineID:";
            // 
            // lblFineID
            // 
            this.lblFineID.AutoSize = true;
            this.lblFineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineID.Location = new System.Drawing.Point(287, 77);
            this.lblFineID.Name = "lblFineID";
            this.lblFineID.Size = new System.Drawing.Size(45, 25);
            this.lblFineID.TabIndex = 37;
            this.lblFineID.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Number Of Late Days:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Fine Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Payment Status:";
            // 
            // lblNumberOfLateDays
            // 
            this.lblNumberOfLateDays.AutoSize = true;
            this.lblNumberOfLateDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfLateDays.Location = new System.Drawing.Point(287, 152);
            this.lblNumberOfLateDays.Name = "lblNumberOfLateDays";
            this.lblNumberOfLateDays.Size = new System.Drawing.Size(45, 25);
            this.lblNumberOfLateDays.TabIndex = 45;
            this.lblNumberOfLateDays.Text = "???";
            // 
            // lblFineAmount
            // 
            this.lblFineAmount.AutoSize = true;
            this.lblFineAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineAmount.Location = new System.Drawing.Point(287, 220);
            this.lblFineAmount.Name = "lblFineAmount";
            this.lblFineAmount.Size = new System.Drawing.Size(45, 25);
            this.lblFineAmount.TabIndex = 46;
            this.lblFineAmount.Text = "???";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(806, 496);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 54);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(679, 496);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 54);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbInfo
            // 
            this.tbInfo.Controls.Add(this.tbUserInfo);
            this.tbInfo.Controls.Add(this.tbRecordInfo);
            this.tbInfo.Controls.Add(this.tbFineInfo);
            this.tbInfo.Location = new System.Drawing.Point(12, 80);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.SelectedIndex = 0;
            this.tbInfo.Size = new System.Drawing.Size(873, 400);
            this.tbInfo.TabIndex = 49;
            // 
            // tbUserInfo
            // 
            this.tbUserInfo.Controls.Add(this.ctrlUserDetailsWithFilter1);
            this.tbUserInfo.Controls.Add(this.btnNextToRecordInfo);
            this.tbUserInfo.Location = new System.Drawing.Point(4, 25);
            this.tbUserInfo.Name = "tbUserInfo";
            this.tbUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbUserInfo.Size = new System.Drawing.Size(865, 371);
            this.tbUserInfo.TabIndex = 0;
            this.tbUserInfo.Text = "User Info";
            this.tbUserInfo.UseVisualStyleBackColor = true;
            // 
            // btnNextToRecordInfo
            // 
            this.btnNextToRecordInfo.Location = new System.Drawing.Point(717, 276);
            this.btnNextToRecordInfo.Name = "btnNextToRecordInfo";
            this.btnNextToRecordInfo.Size = new System.Drawing.Size(75, 54);
            this.btnNextToRecordInfo.TabIndex = 41;
            this.btnNextToRecordInfo.Text = "Next";
            this.btnNextToRecordInfo.UseVisualStyleBackColor = true;
            this.btnNextToRecordInfo.Click += new System.EventHandler(this.btnNextToRecordInfo_Click);
            // 
            // tbRecordInfo
            // 
            this.tbRecordInfo.Controls.Add(this.ctrlBorrowingRecordDetailsWithFilter1);
            this.tbRecordInfo.Controls.Add(this.btnNextToFineInfo);
            this.tbRecordInfo.Location = new System.Drawing.Point(4, 25);
            this.tbRecordInfo.Name = "tbRecordInfo";
            this.tbRecordInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbRecordInfo.Size = new System.Drawing.Size(865, 371);
            this.tbRecordInfo.TabIndex = 1;
            this.tbRecordInfo.Text = "Record Info";
            this.tbRecordInfo.UseVisualStyleBackColor = true;
            // 
            // btnNextToFineInfo
            // 
            this.btnNextToFineInfo.Location = new System.Drawing.Point(736, 276);
            this.btnNextToFineInfo.Name = "btnNextToFineInfo";
            this.btnNextToFineInfo.Size = new System.Drawing.Size(75, 54);
            this.btnNextToFineInfo.TabIndex = 42;
            this.btnNextToFineInfo.Text = "Next";
            this.btnNextToFineInfo.UseVisualStyleBackColor = true;
            this.btnNextToFineInfo.Click += new System.EventHandler(this.btnNextToFineInfo_Click);
            // 
            // tbFineInfo
            // 
            this.tbFineInfo.Controls.Add(this.rbNotPaid);
            this.tbFineInfo.Controls.Add(this.rbPaid);
            this.tbFineInfo.Controls.Add(this.label4);
            this.tbFineInfo.Controls.Add(this.lblFineID);
            this.tbFineInfo.Controls.Add(this.label3);
            this.tbFineInfo.Controls.Add(this.lblFineAmount);
            this.tbFineInfo.Controls.Add(this.label6);
            this.tbFineInfo.Controls.Add(this.lblNumberOfLateDays);
            this.tbFineInfo.Controls.Add(this.label5);
            this.tbFineInfo.Location = new System.Drawing.Point(4, 25);
            this.tbFineInfo.Name = "tbFineInfo";
            this.tbFineInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbFineInfo.Size = new System.Drawing.Size(865, 371);
            this.tbFineInfo.TabIndex = 2;
            this.tbFineInfo.Text = "Fine Info";
            this.tbFineInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlUserDetailsWithFilter1
            // 
            this.ctrlUserDetailsWithFilter1.FilteredEnabled = true;
            this.ctrlUserDetailsWithFilter1.Location = new System.Drawing.Point(3, 0);
            this.ctrlUserDetailsWithFilter1.Name = "ctrlUserDetailsWithFilter1";
            this.ctrlUserDetailsWithFilter1.Size = new System.Drawing.Size(683, 356);
            this.ctrlUserDetailsWithFilter1.TabIndex = 42;
            // 
            // ctrlBorrowingRecordDetailsWithFilter1
            // 
            this.ctrlBorrowingRecordDetailsWithFilter1.FilteredEnabled = true;
            this.ctrlBorrowingRecordDetailsWithFilter1.Location = new System.Drawing.Point(0, 3);
            this.ctrlBorrowingRecordDetailsWithFilter1.Name = "ctrlBorrowingRecordDetailsWithFilter1";
            this.ctrlBorrowingRecordDetailsWithFilter1.Size = new System.Drawing.Size(707, 323);
            this.ctrlBorrowingRecordDetailsWithFilter1.TabIndex = 43;
            // 
            // rbPaid
            // 
            this.rbPaid.AutoSize = true;
            this.rbPaid.Location = new System.Drawing.Point(241, 285);
            this.rbPaid.Name = "rbPaid";
            this.rbPaid.Size = new System.Drawing.Size(56, 20);
            this.rbPaid.TabIndex = 47;
            this.rbPaid.TabStop = true;
            this.rbPaid.Text = "Paid";
            this.rbPaid.UseVisualStyleBackColor = true;
            // 
            // rbNotPaid
            // 
            this.rbNotPaid.AutoSize = true;
            this.rbNotPaid.Location = new System.Drawing.Point(339, 285);
            this.rbNotPaid.Name = "rbNotPaid";
            this.rbNotPaid.Size = new System.Drawing.Size(80, 20);
            this.rbNotPaid.TabIndex = 48;
            this.rbNotPaid.TabStop = true;
            this.rbNotPaid.Text = "Not Paid";
            this.rbNotPaid.UseVisualStyleBackColor = true;
            // 
            // frmAddEditFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 572);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditFine";
            this.Text = "frmAddEditFine";
            this.Load += new System.EventHandler(this.frmAddEditFine_Load);
            this.tbInfo.ResumeLayout(false);
            this.tbUserInfo.ResumeLayout(false);
            this.tbRecordInfo.ResumeLayout(false);
            this.tbFineInfo.ResumeLayout(false);
            this.tbFineInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFineID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumberOfLateDays;
        private System.Windows.Forms.Label lblFineAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tbInfo;
        private System.Windows.Forms.TabPage tbUserInfo;
        private System.Windows.Forms.Button btnNextToRecordInfo;
        private System.Windows.Forms.TabPage tbRecordInfo;
        private System.Windows.Forms.Button btnNextToFineInfo;
        private System.Windows.Forms.TabPage tbFineInfo;
        private Users.Controls.ctrlUserDetailsWithFilter ctrlUserDetailsWithFilter1;
        private Borrowing_Records.Controls.ctrlBorrowingRecordDetailsWithFilter ctrlBorrowingRecordDetailsWithFilter1;
        private System.Windows.Forms.RadioButton rbNotPaid;
        private System.Windows.Forms.RadioButton rbPaid;
    }
}