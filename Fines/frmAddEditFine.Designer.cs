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
            this.numericUpDownUserID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFineID = new System.Windows.Forms.Label();
            this.numericUpDownRecordID = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkPaymentStatus = new System.Windows.Forms.CheckBox();
            this.lblNumberOfLateDays = new System.Windows.Forms.Label();
            this.lblFineAmount = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecordID)).BeginInit();
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
            // numericUpDownUserID
            // 
            this.numericUpDownUserID.Location = new System.Drawing.Point(330, 200);
            this.numericUpDownUserID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownUserID.Name = "numericUpDownUserID";
            this.numericUpDownUserID.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownUserID.TabIndex = 38;
            this.numericUpDownUserID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "UserID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "FineID:";
            // 
            // lblFineID
            // 
            this.lblFineID.AutoSize = true;
            this.lblFineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineID.Location = new System.Drawing.Point(325, 145);
            this.lblFineID.Name = "lblFineID";
            this.lblFineID.Size = new System.Drawing.Size(45, 25);
            this.lblFineID.TabIndex = 37;
            this.lblFineID.Text = "???";
            // 
            // numericUpDownRecordID
            // 
            this.numericUpDownRecordID.Location = new System.Drawing.Point(330, 265);
            this.numericUpDownRecordID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRecordID.Name = "numericUpDownRecordID";
            this.numericUpDownRecordID.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRecordID.TabIndex = 40;
            this.numericUpDownRecordID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRecordID.ValueChanged += new System.EventHandler(this.numericUpDownRecordID_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "RecordID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Number Of Late Days:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Fine Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "Payment Status:";
            // 
            // chkPaymentStatus
            // 
            this.chkPaymentStatus.AutoSize = true;
            this.chkPaymentStatus.Enabled = false;
            this.chkPaymentStatus.Location = new System.Drawing.Point(330, 417);
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
            this.lblNumberOfLateDays.Location = new System.Drawing.Point(325, 312);
            this.lblNumberOfLateDays.Name = "lblNumberOfLateDays";
            this.lblNumberOfLateDays.Size = new System.Drawing.Size(45, 25);
            this.lblNumberOfLateDays.TabIndex = 45;
            this.lblNumberOfLateDays.Text = "???";
            // 
            // lblFineAmount
            // 
            this.lblFineAmount.AutoSize = true;
            this.lblFineAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineAmount.Location = new System.Drawing.Point(325, 371);
            this.lblFineAmount.Name = "lblFineAmount";
            this.lblFineAmount.Size = new System.Drawing.Size(45, 25);
            this.lblFineAmount.TabIndex = 46;
            this.lblFineAmount.Text = "???";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(650, 443);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 54);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(137, 443);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 54);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddEditFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 572);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFineAmount);
            this.Controls.Add(this.lblNumberOfLateDays);
            this.Controls.Add(this.chkPaymentStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownRecordID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownUserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFineID);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditFine";
            this.Text = "frmAddEditFine";
            this.Load += new System.EventHandler(this.frmAddEditFine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecordID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.NumericUpDown numericUpDownUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFineID;
        private System.Windows.Forms.NumericUpDown numericUpDownRecordID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkPaymentStatus;
        private System.Windows.Forms.Label lblNumberOfLateDays;
        private System.Windows.Forms.Label lblFineAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}