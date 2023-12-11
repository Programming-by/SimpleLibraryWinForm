using SimpleLibraryWinForm.Books;
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

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBooks frm = new frmListBooks();
            frm.ShowDialog();
        }
    }
}
