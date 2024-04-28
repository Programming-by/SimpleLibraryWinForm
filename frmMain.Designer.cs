namespace SimpleLibraryWinForm
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.msMainMenue = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageBooksStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BookCopiesStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.borrowingRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.finesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMainMenue
            // 
            this.msMainMenue.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMainMenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.msMainMenue.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.msMainMenue.Location = new System.Drawing.Point(0, 0);
            this.msMainMenue.Name = "msMainMenue";
            this.msMainMenue.Size = new System.Drawing.Size(800, 80);
            this.msMainMenue.TabIndex = 0;
            this.msMainMenue.Text = "msMainMenue";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageBooksStripMenuItem1,
            this.toolStripSeparator1,
            this.BookCopiesStripMenuItem1,
            this.toolStripSeparator2,
            this.reservationsToolStripMenuItem,
            this.toolStripSeparator3,
            this.borrowingRecordsToolStripMenuItem,
            this.toolStripSeparator4,
            this.finesToolStripMenuItem});
            this.booksToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("booksToolStripMenuItem.Image")));
            this.booksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(155, 76);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // ManageBooksStripMenuItem1
            // 
            this.ManageBooksStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ManageBooksStripMenuItem1.Image")));
            this.ManageBooksStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManageBooksStripMenuItem1.Name = "ManageBooksStripMenuItem1";
            this.ManageBooksStripMenuItem1.Size = new System.Drawing.Size(306, 54);
            this.ManageBooksStripMenuItem1.Text = "Manage Books";
            this.ManageBooksStripMenuItem1.Click += new System.EventHandler(this.ManageBooksStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(303, 6);
            // 
            // BookCopiesStripMenuItem1
            // 
            this.BookCopiesStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("BookCopiesStripMenuItem1.Image")));
            this.BookCopiesStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BookCopiesStripMenuItem1.Name = "BookCopiesStripMenuItem1";
            this.BookCopiesStripMenuItem1.Size = new System.Drawing.Size(306, 54);
            this.BookCopiesStripMenuItem1.Text = "Book Copies";
            this.BookCopiesStripMenuItem1.Click += new System.EventHandler(this.BookCopiesStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(303, 6);
            // 
            // reservationsToolStripMenuItem
            // 
            this.reservationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reservationsToolStripMenuItem.Image")));
            this.reservationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reservationsToolStripMenuItem.Name = "reservationsToolStripMenuItem";
            this.reservationsToolStripMenuItem.Size = new System.Drawing.Size(306, 54);
            this.reservationsToolStripMenuItem.Text = "Reservations";
            this.reservationsToolStripMenuItem.Click += new System.EventHandler(this.reservationsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(303, 6);
            // 
            // borrowingRecordsToolStripMenuItem
            // 
            this.borrowingRecordsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("borrowingRecordsToolStripMenuItem.Image")));
            this.borrowingRecordsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.borrowingRecordsToolStripMenuItem.Name = "borrowingRecordsToolStripMenuItem";
            this.borrowingRecordsToolStripMenuItem.Size = new System.Drawing.Size(306, 54);
            this.borrowingRecordsToolStripMenuItem.Text = "Borrowing Records";
            this.borrowingRecordsToolStripMenuItem.Click += new System.EventHandler(this.borrowingRecordsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(303, 6);
            // 
            // finesToolStripMenuItem
            // 
            this.finesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("finesToolStripMenuItem.Image")));
            this.finesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.finesToolStripMenuItem.Name = "finesToolStripMenuItem";
            this.finesToolStripMenuItem.Size = new System.Drawing.Size(306, 54);
            this.finesToolStripMenuItem.Text = "Fines";
            this.finesToolStripMenuItem.Click += new System.EventHandler(this.finesToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usersToolStripMenuItem.Image")));
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(141, 68);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msMainMenue);
            this.MainMenuStrip = this.msMainMenue;
            this.Name = "frmMain";
            this.Text = "Main Form";
            this.msMainMenue.ResumeLayout(false);
            this.msMainMenue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenue;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BookCopiesStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ManageBooksStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem reservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem borrowingRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem finesToolStripMenuItem;
    }
}

