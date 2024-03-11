using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLibraryWinForm.Borrowing_Records
{
    public partial class frmShowRecordDetails : Form
    {
        public frmShowRecordDetails(int RecordID)
        {
            InitializeComponent();
            ctrlBorrowingRecordDetails1.LoadRecordInfo(RecordID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
