namespace SimpleLibraryWinForm.BookCopies
{
    partial class frmListBookCopies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListBookCopies));
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCopies = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showCopyDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbAvailabilityStatus = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopies)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(206, 62);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(147, 29);
            this.txtFilter.TabIndex = 25;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cbFilters
            // 
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "CopyID",
            "Title",
            "Genre",
            "Availability Status"});
            this.cbFilters.Location = new System.Drawing.Point(12, 62);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(153, 24);
            this.cbFilters.TabIndex = 24;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.Location = new System.Drawing.Point(942, 67);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(75, 70);
            this.btnAddNewBook.TabIndex = 23;
            this.btnAddNewBook.Text = "Add";
            this.btnAddNewBook.UseVisualStyleBackColor = true;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewCopy_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(201, 438);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(49, 29);
            this.lblRecordsCount.TabIndex = 22;
            this.lblRecordsCount.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Records Count:";
            // 
            // dgvCopies
            // 
            this.dgvCopies.AllowUserToAddRows = false;
            this.dgvCopies.AllowUserToDeleteRows = false;
            this.dgvCopies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCopies.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCopies.Location = new System.Drawing.Point(12, 151);
            this.dgvCopies.Name = "dgvCopies";
            this.dgvCopies.ReadOnly = true;
            this.dgvCopies.RowHeadersWidth = 51;
            this.dgvCopies.RowTemplate.Height = 24;
            this.dgvCopies.Size = new System.Drawing.Size(1005, 275);
            this.dgvCopies.TabIndex = 20;
            this.dgvCopies.DoubleClick += new System.EventHandler(this.dgvCopies_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCopyDetailsToolStripMenuItem,
            this.addNewCopyToolStripMenuItem,
            this.editCopyToolStripMenuItem,
            this.deleteCopyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 100);
            // 
            // showCopyDetailsToolStripMenuItem
            // 
            this.showCopyDetailsToolStripMenuItem.Name = "showCopyDetailsToolStripMenuItem";
            this.showCopyDetailsToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.showCopyDetailsToolStripMenuItem.Text = "Show Copy Details";
            this.showCopyDetailsToolStripMenuItem.Click += new System.EventHandler(this.showCopyDetailsToolStripMenuItem_Click);
            // 
            // addNewCopyToolStripMenuItem
            // 
            this.addNewCopyToolStripMenuItem.Name = "addNewCopyToolStripMenuItem";
            this.addNewCopyToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.addNewCopyToolStripMenuItem.Text = "Add New Copy";
            this.addNewCopyToolStripMenuItem.Click += new System.EventHandler(this.addNewCopyToolStripMenuItem_Click);
            // 
            // editCopyToolStripMenuItem
            // 
            this.editCopyToolStripMenuItem.Name = "editCopyToolStripMenuItem";
            this.editCopyToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.editCopyToolStripMenuItem.Text = "Edit Copy";
            this.editCopyToolStripMenuItem.Click += new System.EventHandler(this.editCopyToolStripMenuItem_Click);
            // 
            // deleteCopyToolStripMenuItem
            // 
            this.deleteCopyToolStripMenuItem.Name = "deleteCopyToolStripMenuItem";
            this.deleteCopyToolStripMenuItem.Size = new System.Drawing.Size(202, 24);
            this.deleteCopyToolStripMenuItem.Text = "Delete Copy";
            this.deleteCopyToolStripMenuItem.Click += new System.EventHandler(this.deleteCopyToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Manage Book Copies";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(942, 432);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 48);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbAvailabilityStatus
            // 
            this.cbAvailabilityStatus.FormattingEnabled = true;
            this.cbAvailabilityStatus.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbAvailabilityStatus.Location = new System.Drawing.Point(217, 67);
            this.cbAvailabilityStatus.Name = "cbAvailabilityStatus";
            this.cbAvailabilityStatus.Size = new System.Drawing.Size(153, 24);
            this.cbAvailabilityStatus.TabIndex = 27;
            this.cbAvailabilityStatus.Visible = false;
            this.cbAvailabilityStatus.SelectedIndexChanged += new System.EventHandler(this.cbAvailabilityStatus_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(429, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 81);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // frmListBookCopies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 501);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbAvailabilityStatus);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.btnAddNewBook);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCopies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmListBookCopies";
            this.Text = "frmListBookCopies";
            this.Load += new System.EventHandler(this.frmListBookCopies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopies)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCopies;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCopyToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbAvailabilityStatus;
        private System.Windows.Forms.ToolStripMenuItem showCopyDetailsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}