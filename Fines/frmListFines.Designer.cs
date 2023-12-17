namespace SimpleLibraryWinForm.Fines
{
    partial class frmListFines
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
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbFilters = new System.Windows.Forms.ComboBox();
            this.btnAddNewFine = new System.Windows.Forms.Button();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvFines = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewFineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(185, 75);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(147, 29);
            this.txtFilter.TabIndex = 42;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // cbFilters
            // 
            this.cbFilters.FormattingEnabled = true;
            this.cbFilters.Items.AddRange(new object[] {
            "None",
            "FineID",
            "Name",
            "Title"});
            this.cbFilters.Location = new System.Drawing.Point(12, 80);
            this.cbFilters.Name = "cbFilters";
            this.cbFilters.Size = new System.Drawing.Size(153, 24);
            this.cbFilters.TabIndex = 41;
            this.cbFilters.SelectedIndexChanged += new System.EventHandler(this.cbFilters_SelectedIndexChanged);
            // 
            // btnAddNewFine
            // 
            this.btnAddNewFine.Location = new System.Drawing.Point(942, 41);
            this.btnAddNewFine.Name = "btnAddNewFine";
            this.btnAddNewFine.Size = new System.Drawing.Size(75, 70);
            this.btnAddNewFine.TabIndex = 40;
            this.btnAddNewFine.Text = "Add";
            this.btnAddNewFine.UseVisualStyleBackColor = true;
            this.btnAddNewFine.Click += new System.EventHandler(this.btnAddNewFine_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(197, 404);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(49, 29);
            this.lblRecordsCount.TabIndex = 39;
            this.lblRecordsCount.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "Records Count:";
            // 
            // dgvFines
            // 
            this.dgvFines.AllowUserToAddRows = false;
            this.dgvFines.AllowUserToDeleteRows = false;
            this.dgvFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFines.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvFines.Location = new System.Drawing.Point(12, 117);
            this.dgvFines.Name = "dgvFines";
            this.dgvFines.ReadOnly = true;
            this.dgvFines.RowHeadersWidth = 51;
            this.dgvFines.RowTemplate.Height = 24;
            this.dgvFines.Size = new System.Drawing.Size(1005, 275);
            this.dgvFines.TabIndex = 37;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewFineToolStripMenuItem,
            this.editFineToolStripMenuItem,
            this.deleteFineToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 76);
            // 
            // addNewFineToolStripMenuItem
            // 
            this.addNewFineToolStripMenuItem.Name = "addNewFineToolStripMenuItem";
            this.addNewFineToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addNewFineToolStripMenuItem.Text = "Add New Fine";
            this.addNewFineToolStripMenuItem.Click += new System.EventHandler(this.addNewFineToolStripMenuItem_Click);
            // 
            // editFineToolStripMenuItem
            // 
            this.editFineToolStripMenuItem.Name = "editFineToolStripMenuItem";
            this.editFineToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editFineToolStripMenuItem.Text = "Edit Fine";
            this.editFineToolStripMenuItem.Click += new System.EventHandler(this.editFineToolStripMenuItem_Click);
            // 
            // deleteFineToolStripMenuItem
            // 
            this.deleteFineToolStripMenuItem.Name = "deleteFineToolStripMenuItem";
            this.deleteFineToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteFineToolStripMenuItem.Text = "Delete Fine";
            this.deleteFineToolStripMenuItem.Click += new System.EventHandler(this.deleteFineToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 32);
            this.label1.TabIndex = 36;
            this.label1.Text = "Manage Fines";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(942, 404);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 48);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmListFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 466);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilters);
            this.Controls.Add(this.btnAddNewFine);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmListFines";
            this.Text = "frmListFines";
            this.Load += new System.EventHandler(this.frmListFines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilters;
        private System.Windows.Forms.Button btnAddNewFine;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvFines;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewFineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFineToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}