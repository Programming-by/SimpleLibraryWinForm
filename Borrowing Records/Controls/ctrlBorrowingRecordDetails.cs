using SimpleLibraryBusinessLayer;
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
    public partial class ctrlBorrowingRecordDetails : UserControl
    {
        public ctrlBorrowingRecordDetails()
        {
            InitializeComponent();
        }

        private clsBorrowingRecords _Record;

        public clsBorrowingRecords Record
        {
            get { return _Record; }
        }


        private int _BorrowingRecordID = -1;

        public int BorrowingRecordID
        {
            get { return _BorrowingRecordID; }
        }

        public void LoadRecordInfo(int RecordID)
        {
            _Record = clsBorrowingRecords.Find(RecordID);

            if (_Record == null )
            {
                MessageBox.Show("Record is not exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            _BorrowingRecordID = _Record.BorrowingRecordID;
            lblRecordID.Text = _Record.BorrowingRecordID.ToString();
            lblUsername.Text = _Record.UserInfo.Name;
            lblBookName.Text = _Record.CopyInfo.BookInfo.Title;
            lblBorrowingDate.Text = _Record.BorrowingDate.ToString();
            lblDueDate.Text = _Record.DueDate.ToString();
            lblActualReturnDate.Text = _Record.ActualReturnDate.ToString();
        }

    }
}
