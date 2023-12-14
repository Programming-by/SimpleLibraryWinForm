using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLibraryWinForm.BookCopies
{
    public partial class frmCopyDetails : Form
    {
        int _CopID;
        public frmCopyDetails(int CopID)
        {
            InitializeComponent();
            _CopID = CopID;
        }

        private void frmCopyDetails_Load(object sender, EventArgs e)
        {
            ctrlCopyDetails1.LoadCopyInfo(_CopID);
        }
    }
}
