namespace SimpleLibraryWinForm.Users
{
    partial class frmAddEditUser
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContactInformation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtLibraryCardNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(230, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(194, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add New User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(256, 152);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 27);
            this.txtName.TabIndex = 3;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact Information:";
            // 
            // txtContactInformation
            // 
            this.txtContactInformation.Location = new System.Drawing.Point(256, 202);
            this.txtContactInformation.Multiline = true;
            this.txtContactInformation.Name = "txtContactInformation";
            this.txtContactInformation.Size = new System.Drawing.Size(168, 27);
            this.txtContactInformation.TabIndex = 5;
            this.txtContactInformation.Validating += new System.ComponentModel.CancelEventHandler(this.txtContactInformation_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "UserID:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(251, 102);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(45, 25);
            this.lblUserID.TabIndex = 7;
            this.lblUserID.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Library Card Number";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(256, 316);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 48);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtLibraryCardNumber
            // 
            this.txtLibraryCardNumber.Location = new System.Drawing.Point(256, 248);
            this.txtLibraryCardNumber.Multiline = true;
            this.txtLibraryCardNumber.Name = "txtLibraryCardNumber";
            this.txtLibraryCardNumber.Size = new System.Drawing.Size(168, 27);
            this.txtLibraryCardNumber.TabIndex = 10;
            this.txtLibraryCardNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLibraryCardNumber_KeyPress);
            this.txtLibraryCardNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtLibraryCardNumber_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(375, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 48);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 376);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLibraryCardNumber);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContactInformation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditUser";
            this.Text = "frmAddNewUser";
            this.Load += new System.EventHandler(this.frmAddEditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContactInformation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtLibraryCardNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}