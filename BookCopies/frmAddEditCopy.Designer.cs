namespace SimpleLibraryWinForm.BookCopies
{
    partial class frmAddEditCopy
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCopyID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rbAvailable = new System.Windows.Forms.RadioButton();
            this.rbNotAvailable = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbBookInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrlBookDetailsWithFilter1 = new SimpleLibraryWinForm.Books.ctrlBookDetailsWithFilter();
            this.tbCopyInfo = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbBookInfo.SuspendLayout();
            this.tbCopyInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(794, 479);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 54);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(510, 479);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 54);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCopyID
            // 
            this.lblCopyID.AutoSize = true;
            this.lblCopyID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyID.Location = new System.Drawing.Point(306, 136);
            this.lblCopyID.Name = "lblCopyID";
            this.lblCopyID.Size = new System.Drawing.Size(45, 25);
            this.lblCopyID.TabIndex = 33;
            this.lblCopyID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "CopyID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "AvailabilityStatus:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(301, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(201, 32);
            this.lblTitle.TabIndex = 28;
            this.lblTitle.Text = "Add New Copy";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rbAvailable
            // 
            this.rbAvailable.AutoSize = true;
            this.rbAvailable.Location = new System.Drawing.Point(311, 229);
            this.rbAvailable.Name = "rbAvailable";
            this.rbAvailable.Size = new System.Drawing.Size(85, 20);
            this.rbAvailable.TabIndex = 38;
            this.rbAvailable.TabStop = true;
            this.rbAvailable.Text = "Available";
            this.rbAvailable.UseVisualStyleBackColor = true;
            // 
            // rbNotAvailable
            // 
            this.rbNotAvailable.AutoSize = true;
            this.rbNotAvailable.Location = new System.Drawing.Point(445, 229);
            this.rbNotAvailable.Name = "rbNotAvailable";
            this.rbNotAvailable.Size = new System.Drawing.Size(109, 20);
            this.rbNotAvailable.TabIndex = 39;
            this.rbNotAvailable.TabStop = true;
            this.rbNotAvailable.Text = "Not Available";
            this.rbNotAvailable.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbBookInfo);
            this.tabControl1.Controls.Add(this.tbCopyInfo);
            this.tabControl1.Location = new System.Drawing.Point(27, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(873, 400);
            this.tabControl1.TabIndex = 40;
            // 
            // tbBookInfo
            // 
            this.tbBookInfo.Controls.Add(this.btnNext);
            this.tbBookInfo.Controls.Add(this.ctrlBookDetailsWithFilter1);
            this.tbBookInfo.Location = new System.Drawing.Point(4, 25);
            this.tbBookInfo.Name = "tbBookInfo";
            this.tbBookInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbBookInfo.Size = new System.Drawing.Size(865, 371);
            this.tbBookInfo.TabIndex = 0;
            this.tbBookInfo.Text = "Book Info";
            this.tbBookInfo.UseVisualStyleBackColor = true;
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
            // ctrlBookDetailsWithFilter1
            // 
            this.ctrlBookDetailsWithFilter1.FilterEnabled = true;
            this.ctrlBookDetailsWithFilter1.Location = new System.Drawing.Point(0, 3);
            this.ctrlBookDetailsWithFilter1.Name = "ctrlBookDetailsWithFilter1";
            this.ctrlBookDetailsWithFilter1.Size = new System.Drawing.Size(720, 397);
            this.ctrlBookDetailsWithFilter1.TabIndex = 0;
            this.ctrlBookDetailsWithFilter1.OnBookSelected += new System.Action<int>(this.ctrlBookDetailsWithFilter1_OnBookSelected);
            // 
            // tbCopyInfo
            // 
            this.tbCopyInfo.Controls.Add(this.label2);
            this.tbCopyInfo.Controls.Add(this.rbNotAvailable);
            this.tbCopyInfo.Controls.Add(this.label4);
            this.tbCopyInfo.Controls.Add(this.rbAvailable);
            this.tbCopyInfo.Controls.Add(this.lblCopyID);
            this.tbCopyInfo.Location = new System.Drawing.Point(4, 25);
            this.tbCopyInfo.Name = "tbCopyInfo";
            this.tbCopyInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbCopyInfo.Size = new System.Drawing.Size(865, 371);
            this.tbCopyInfo.TabIndex = 1;
            this.tbCopyInfo.Text = "Copy Info";
            this.tbCopyInfo.UseVisualStyleBackColor = true;
            // 
            // frmAddEditCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 591);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditCopy";
            this.Text = "frmAddEditCopy";
            this.Activated += new System.EventHandler(this.frmAddEditCopy_Activated);
            this.Load += new System.EventHandler(this.frmAddEditCopy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbBookInfo.ResumeLayout(false);
            this.tbCopyInfo.ResumeLayout(false);
            this.tbCopyInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCopyID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton rbNotAvailable;
        private System.Windows.Forms.RadioButton rbAvailable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbBookInfo;
        private System.Windows.Forms.TabPage tbCopyInfo;
        private Books.ctrlBookDetailsWithFilter ctrlBookDetailsWithFilter1;
        private System.Windows.Forms.Button btnNext;
    }
}