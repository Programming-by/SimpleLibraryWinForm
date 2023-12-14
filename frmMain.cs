﻿using SimpleLibraryWinForm.BookCopies;
using SimpleLibraryWinForm.Books;
using SimpleLibraryWinForm.Reservations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLibraryWinForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUsers frm = new frmListUsers();

            frm.ShowDialog();
        }

        private void ManageBooksStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListBooks frm = new frmListBooks();
            frm.ShowDialog();
        }

        private void BookCopiesStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListBookCopies frm = new frmListBookCopies();
            frm.ShowDialog();
        }

        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListReservations frm = new frmListReservations();
            frm.ShowDialog();
        }
    }
}
