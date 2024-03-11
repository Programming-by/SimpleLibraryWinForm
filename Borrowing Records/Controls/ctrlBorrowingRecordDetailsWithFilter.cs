using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLibraryWinForm.Borrowing_Records.Controls
{
    public partial class ctrlBorrowingRecordDetailsWithFilter : UserControl
    {

        public int BorrowingRecordID
        {
            get { return ctrlBorrowingRecordDetails1.BorrowingRecordID; }
        }

        private bool _FilteredEnabled = true;
        public bool FilteredEnabled
        {
            get { return _FilteredEnabled; }
            set
            {
                _FilteredEnabled = value;
                gpFilter.Enabled = _FilteredEnabled;
            }
        }


        public ctrlBorrowingRecordDetailsWithFilter()
        {
            InitializeComponent();
        }
        public void LoadRecordInfo(int RecordID)
        {
            txtFilterBy.Text = RecordID.ToString();
            ctrlBorrowingRecordDetails1.LoadRecordInfo(int.Parse(txtFilterBy.Text));

        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            ctrlBorrowingRecordDetails1.LoadRecordInfo(int.Parse(txtFilterBy.Text));
        }

        public void frm_DataBack(object sender, int RecordID)
        {
            txtFilterBy.Text = RecordID.ToString();
            ctrlBorrowingRecordDetails1.LoadRecordInfo(RecordID);
        }
        
        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {
            frmAddEditBorrowingRecord frm = new frmAddEditBorrowingRecord();

            frm.DataBack += frm_DataBack;
            frm.ShowDialog();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
