namespace SimpleLibraryWinForm.Reservations
{
    partial class frmAddEditReservation
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReservationID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TabControl();
            this.tbCopyInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbReservationInfo = new System.Windows.Forms.TabPage();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlCopyDetailsWithFilter1 = new SimpleLibraryWinForm.BookCopies.Controls.ctrlCopyDetailsWithFilter();
            this.tbInfo.SuspendLayout();
            this.tbCopyInfo.SuspendLayout();
            this.tbReservationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(242, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(287, 32);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Add New Reservation";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(313, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Reservation Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "ReservationID:";
            // 
            // lblReservationID
            // 
            this.lblReservationID.AutoSize = true;
            this.lblReservationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationID.Location = new System.Drawing.Point(339, 57);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(49, 29);
            this.lblReservationID.TabIndex = 16;
            this.lblReservationID.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "UserID:";
            // 
            // tbInfo
            // 
            this.tbInfo.Controls.Add(this.tbCopyInfo);
            this.tbInfo.Controls.Add(this.tbReservationInfo);
            this.tbInfo.Location = new System.Drawing.Point(12, 101);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.SelectedIndex = 0;
            this.tbInfo.Size = new System.Drawing.Size(873, 400);
            this.tbInfo.TabIndex = 41;
            // 
            // tbCopyInfo
            // 
            this.tbCopyInfo.Controls.Add(this.ctrlCopyDetailsWithFilter1);
            this.tbCopyInfo.Controls.Add(this.btnNext);
            this.tbCopyInfo.Location = new System.Drawing.Point(4, 25);
            this.tbCopyInfo.Name = "tbCopyInfo";
            this.tbCopyInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbCopyInfo.Size = new System.Drawing.Size(865, 371);
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
            // tbReservationInfo
            // 
            this.tbReservationInfo.Controls.Add(this.numericUpDown1);
            this.tbReservationInfo.Controls.Add(this.label5);
            this.tbReservationInfo.Controls.Add(this.dateTimePicker1);
            this.tbReservationInfo.Controls.Add(this.lblReservationID);
            this.tbReservationInfo.Controls.Add(this.label3);
            this.tbReservationInfo.Controls.Add(this.label2);
            this.tbReservationInfo.Location = new System.Drawing.Point(4, 25);
            this.tbReservationInfo.Name = "tbReservationInfo";
            this.tbReservationInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbReservationInfo.Size = new System.Drawing.Size(865, 371);
            this.tbReservationInfo.TabIndex = 1;
            this.tbReservationInfo.Text = "Reservation Info";
            this.tbReservationInfo.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(313, 124);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(779, 518);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 54);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(654, 518);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 54);
            this.btnClose.TabIndex = 44;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlCopyDetailsWithFilter1
            // 
            this.ctrlCopyDetailsWithFilter1.FilteredEnabled = true;
            this.ctrlCopyDetailsWithFilter1.Location = new System.Drawing.Point(-4, 3);
            this.ctrlCopyDetailsWithFilter1.Name = "ctrlCopyDetailsWithFilter1";
            this.ctrlCopyDetailsWithFilter1.Size = new System.Drawing.Size(699, 395);
            this.ctrlCopyDetailsWithFilter1.TabIndex = 42;
            // 
            // frmAddEditReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 584);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditReservation";
            this.Text = "frmAddEditReservation";
            this.Load += new System.EventHandler(this.frmAddEditReservation_Load);
            this.tbInfo.ResumeLayout(false);
            this.tbCopyInfo.ResumeLayout(false);
            this.tbReservationInfo.ResumeLayout(false);
            this.tbReservationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReservationID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tbInfo;
        private System.Windows.Forms.TabPage tbCopyInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tbReservationInfo;
        private BookCopies.Controls.ctrlCopyDetailsWithFilter ctrlCopyDetailsWithFilter1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}