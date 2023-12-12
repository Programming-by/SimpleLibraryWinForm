using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLibraryWinForm.Books
{
    public partial class frmShowBookDetails : Form
    {
        private int _BookID;
        public frmShowBookDetails(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowBookDetails_Load(object sender, EventArgs e)
        {
            ctrlBookDetails1.LoadBookInfo(_BookID);
        }
    }
}
