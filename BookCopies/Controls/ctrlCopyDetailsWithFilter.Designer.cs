namespace SimpleLibraryWinForm.BookCopies.Controls
{
    partial class ctrlCopyDetailsWithFilter
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
            this.components = new System.ComponentModel.Container();
            this.gpFilter = new System.Windows.Forms.GroupBox();
            this.btnAddNewCopy = new System.Windows.Forms.Button();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.ctrlCopyDetails1 = new SimpleLibraryWinForm.BookCopies.ctrlCopyDetails();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpFilter
            // 
            this.gpFilter.Controls.Add(this.label1);
            this.gpFilter.Controls.Add(this.btnAddNewCopy);
            this.gpFilter.Controls.Add(this.txtFilterBy);
            this.gpFilter.Controls.Add(this.btnFind);
            this.gpFilter.Location = new System.Drawing.Point(36, 15);
            this.gpFilter.Name = "gpFilter";
            this.gpFilter.Size = new System.Drawing.Size(638, 71);
            this.gpFilter.TabIndex = 5;
            this.gpFilter.TabStop = false;
            this.gpFilter.Text = "Filter";
            // 
            // btnAddNewCopy
            // 
            this.btnAddNewCopy.Location = new System.Drawing.Point(477, 21);
            this.btnAddNewCopy.Name = "btnAddNewCopy";
            this.btnAddNewCopy.Size = new System.Drawing.Size(75, 39);
            this.btnAddNewCopy.TabIndex = 4;
            this.btnAddNewCopy.Text = "Add";
            this.btnAddNewCopy.UseVisualStyleBackColor = true;
            this.btnAddNewCopy.Click += new System.EventHandler(this.btnAddNewCopy_Click);
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Location = new System.Drawing.Point(158, 25);
            this.txtFilterBy.Multiline = true;
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(232, 29);
            this.txtFilterBy.TabIndex = 0;
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            this.txtFilterBy.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterBy_Validating);
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
            // ctrlCopyDetails1
            // 
            this.ctrlCopyDetails1.Location = new System.Drawing.Point(14, 81);
            this.ctrlCopyDetails1.Name = "ctrlCopyDetails1";
            this.ctrlCopyDetails1.Size = new System.Drawing.Size(697, 321);
            this.ctrlCopyDetails1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "CopyID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlCopyDetailsWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpFilter);
            this.Controls.Add(this.ctrlCopyDetails1);
            this.Name = "ctrlCopyDetailsWithFilter";
            this.Size = new System.Drawing.Size(699, 395);
            this.Load += new System.EventHandler(this.ctrlCopyDetailsWithFilter_Load);
            this.gpFilter.ResumeLayout(false);
            this.gpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlCopyDetails ctrlCopyDetails1;
        private System.Windows.Forms.GroupBox gpFilter;
        private System.Windows.Forms.Button btnAddNewCopy;
        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
