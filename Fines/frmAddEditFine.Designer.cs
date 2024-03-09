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
            this.chkPaymentStatus = new System.Windows.Forms.CheckBox();
            this.lblNumberOfLateDays = new System.Windows.Forms.Label();
            this.lblFineAmount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbInfo = new System.Windows.Forms.TabControl();
            this.tbBookInfo = new System.Windows.Forms.TabPage();
            this.btnNextToRecordInfo = new System.Windows.Forms.Button();
            this.tbCopyInfo = new System.Windows.Forms.TabPage();
            this.tbFineInfo = new System.Windows.Forms.TabPage();
            this.btnNextToFineInfo = new System.Windows.Forms.Button();
            this.tbInfo.SuspendLayout();
            this.tbBookInfo.SuspendLayout();
            this.tbCopyInfo.SuspendLayout();
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
            // chkPaymentStatus
            // 
            this.chkPaymentStatus.AutoSize = true;
            this.chkPaymentStatus.Enabled = false;
            this.chkPaymentStatus.Location = new System.Drawing.Point(275, 280);
            this.chkPaymentStatus.Name = "chkPaymentStatus";
            this.chkPaymentStatus.Size = new System.Drawing.Size(57, 20);
            this.chkPaymentStatus.TabIndex = 44;
            this.chkPaymentStatus.Text = "Paid";
            this.chkPaymentStatus.UseVisualStyleBackColor = true;
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
            this.tbInfo.Controls.Add(this.tbBookInfo);
            this.tbInfo.Controls.Add(this.tbCopyInfo);
            this.tbInfo.Controls.Add(this.tbFineInfo);
            this.tbInfo.Location = new System.Drawing.Point(12, 80);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.SelectedIndex = 0;
            this.tbInfo.Size = new System.Drawing.Size(873, 400);
            this.tbInfo.TabIndex = 49;
            // 
            // tbBookInfo
            // 
            this.tbBookInfo.Controls.Add(this.btnNextToRecordInfo);
            this.tbBookInfo.Location = new System.Drawing.Point(4, 25);
            this.tbBookInfo.Name = "tbBookInfo";
            this.tbBookInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbBookInfo.Size = new System.Drawing.Size(865, 371);
            this.tbBookInfo.TabIndex = 0;
            this.tbBookInfo.Text = "User Info";
            this.tbBookInfo.UseVisualStyleBackColor = true;
            // 
            // btnNextToRecordInfo
            // 
            this.btnNextToRecordInfo.Location = new System.Drawing.Point(717, 276);
            this.btnNextToRecordInfo.Name = "btnNextToRecordInfo";
            this.btnNextToRecordInfo.Size = new System.Drawing.Size(75, 54);
            this.btnNextToRecordInfo.TabIndex = 41;
            this.btnNextToRecordInfo.Text = "Next";
            this.btnNextToRecordInfo.UseVisualStyleBackColor = true;
            // 
            // tbCopyInfo
            // 
            this.tbCopyInfo.Controls.Add(this.btnNextToFineInfo);
            this.tbCopyInfo.Location = new System.Drawing.Point(4, 25);
            this.tbCopyInfo.Name = "tbCopyInfo";
            this.tbCopyInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbCopyInfo.Size = new System.Drawing.Size(865, 371);
            this.tbCopyInfo.TabIndex = 1;
            this.tbCopyInfo.Text = "Record Info";
            this.tbCopyInfo.UseVisualStyleBackColor = true;
            // 
            // tbFineInfo
            // 
            this.tbFineInfo.Controls.Add(this.label4);
            this.tbFineInfo.Controls.Add(this.lblFineID);
            this.tbFineInfo.Controls.Add(this.label3);
            this.tbFineInfo.Controls.Add(this.chkPaymentStatus);
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
            // btnNextToFineInfo
            // 
            this.btnNextToFineInfo.Location = new System.Drawing.Point(736, 276);
            this.btnNextToFineInfo.Name = "btnNextToFineInfo";
            this.btnNextToFineInfo.Size = new System.Drawing.Size(75, 54);
            this.btnNextToFineInfo.TabIndex = 42;
            this.btnNextToFineInfo.Text = "Next";
            this.btnNextToFineInfo.UseVisualStyleBackColor = true;
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
            this.tbBookInfo.ResumeLayout(false);
            this.tbCopyInfo.ResumeLayout(false);
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
        private System.Windows.Forms.CheckBox chkPaymentStatus;
        private System.Windows.Forms.Label lblNumberOfLateDays;
        private System.Windows.Forms.Label lblFineAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tbInfo;
        private System.Windows.Forms.TabPage tbBookInfo;
        private System.Windows.Forms.Button btnNextToRecordInfo;
        private System.Windows.Forms.TabPage tbCopyInfo;
        private System.Windows.Forms.Button btnNextToFineInfo;
        private System.Windows.Forms.TabPage tbFineInfo;
    }
}