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

namespace SimpleLibraryWinForm.BookCopies
{
    public partial class ctrlCopyDetails : UserControl
    {
        private clsCopies _Copy;

        public clsCopies SelectedCopyInfo
        {
            get { return _Copy; }
        }

        private int _CopyID;

        public int CopyID { get { return _CopyID; } }
        public ctrlCopyDetails()
        {
            InitializeComponent();
        }

        public void LoadCopyInfo(int CopyID)
        {
            _Copy = clsCopies.Find(CopyID);

            if (_Copy == null )
            {
                MessageBox.Show("No Copy with CopyID = " + CopyID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblAvailabilityStatus.Text = "[????]";
                return;
            }
            _CopyID = CopyID;
            ctrlBookDetails1.LoadBookInfo(_Copy.BookID);
            lblAvailabilityStatus.Text = _Copy.AvailabilityStatus == true ? "Available" : "Not Available";
        }

    }
}
