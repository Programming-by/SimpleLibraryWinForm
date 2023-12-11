namespace SimpleLibraryWinForm.Books
{
    partial class frmAddEditBook
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
            this.txtAdditionalDetails = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(472, 523);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 48);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAdditionalDetails
            // 
            this.txtAdditionalDetails.Location = new System.Drawing.Point(260, 347);
            this.txtAdditionalDetails.Multiline = true;
            this.txtAdditionalDetails.Name = "txtAdditionalDetails";
            this.txtAdditionalDetails.Size = new System.Drawing.Size(310, 135);
            this.txtAdditionalDetails.TabIndex = 21;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(377, 523);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 48);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Publication Date:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(255, 96);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(45, 25);
            this.lblUserID.TabIndex = 18;
            this.lblUserID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "BookID:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(260, 196);
            this.txtISBN.Multiline = true;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(168, 27);
            this.txtISBN.TabIndex = 16;
            this.txtISBN.Validating += new System.ComponentModel.CancelEventHandler(this.txtISBN_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "ISBN:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(260, 146);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(168, 27);
            this.txtTitle.TabIndex = 14;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Title:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(234, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 32);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Add New Book";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(260, 251);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(310, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Genre:";
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Items.AddRange(new object[] {
            "Action",
            "Crime",
            "Drama",
            "Mystery",
            "Romance",
            "Horror",
            "Thriller",
            "Sc-Fi"});
            this.cbGenre.Location = new System.Drawing.Point(260, 299);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(168, 24);
            this.cbGenre.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Additional Details:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAdditionalDetails);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddEditBook";
            this.Text = "frmAddEditBook";
            this.Load += new System.EventHandler(this.frmAddEditBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAdditionalDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}