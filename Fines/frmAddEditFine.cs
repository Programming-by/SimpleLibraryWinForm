using SimpleLibraryBusinessLayer;
using SimpleLibraryWinForm.BookCopies.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLibraryWinForm.Fines
{
    public partial class frmAddEditFine : Form
    {
        clsFines _Fine;
        public enum enMode { AddNew = 0 , Update = 1 }
        enMode _Mode;
        private int _FineID;

        clsBorrowingRecords _Record;
        public frmAddEditFine()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddEditFine(int FineID)
        {
            InitializeComponent();
            _FineID = FineID;
            _Mode = enMode.Update;

        }
        private void _ResetDefaultValues()
        {
            if(_Mode == enMode.AddNew)
            {
            _Fine = new clsFines();
            lblTitle.Text = "Add New Fine";
            this.Text = "Add New Fine";
            } else
            {
                    this.Text = "Update Fine";
                    lblTitle.Text = "Update Fine";
            }
            btnSave.Enabled = false;
            tbRecordInfo.Enabled = false;
            tbFineInfo.Enabled = false;
            rbNotPaid.Checked = true;

        }
        private void _LoadData()
        {
            _Fine = clsFines.Find(_FineID);
            if (_Fine == null)
            {
                MessageBox.Show("This form will be closed because No Fine with ID = " + _FineID);
                this.Close();
                return;
            }
            ctrlBorrowingRecordDetailsWithFilter1.FilteredEnabled = false;
            ctrlUserDetailsWithFilter1.FilteredEnabled = false;
            ctrlUserDetailsWithFilter1.LoadUserInfo(_Fine.UserID);
            ctrlBorrowingRecordDetailsWithFilter1.LoadRecordInfo(_Fine.BorrowingRecordID);
            lblFineID.Text = _Fine.FineID.ToString();
            lblNumberOfLateDays.Text = _Fine.NumberOfLateDays.ToString();
            lblFineAmount.Text = _Fine.FineAmount.ToString() + "$";
            if (_Fine.PaymentStatus)
                rbPaid.Checked = true;
            else 
                rbPaid.Checked = false;
      
        }
        private void frmAddEditFine_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _PreventAddingNewFineForTheSameRecord()
        {
            clsFines PreviousFine = clsFines.FindByBorrowingRecordID(ctrlBorrowingRecordDetailsWithFilter1.BorrowingRecordID);

            if (PreviousFine != null)
            {
                    MessageBox.Show("Cannot Add New Fine for this Record, there is Active Fine Application For this Record", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    btnSave.Enabled = false;
                    return;
            }
        }
        private void CalculateLateDaysAndFineAmount()
        {
             _Record = clsBorrowingRecords.Find(ctrlBorrowingRecordDetailsWithFilter1.BorrowingRecordID);

            if (_Record == null)
            {
                return;
            }

            if (_Record.ActualReturnDate.HasValue)
            {
                TimeSpan difference = _Record.ActualReturnDate.Value - _Record.DueDate;

                double totalDays = difference.TotalDays;
                lblNumberOfLateDays.Text = totalDays.ToString();
                lblFineAmount.Text = (totalDays * 2).ToString();

                if (totalDays <= 0)
                {
                    MessageBox.Show("Cannot Add Fine to this Record Because its Not Late" , "Not Allowed",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    btnSave.Enabled = false;
                    return;
                }
            }
            else
            {
                lblNumberOfLateDays.Text = "0";
                lblFineAmount.Text = "0";
                return;
            }
        }
        private void btnNextToRecordInfo_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tbUserInfo.Enabled = false;
                tbRecordInfo.Enabled = false;
            }
            if (ctrlUserDetailsWithFilter1.UserID != -1)
            {
                tbUserInfo.Enabled = false;
                tbRecordInfo.Enabled = true;
                tbInfo.SelectedTab = tbInfo.TabPages["tbRecordInfo"];
            } else
            {
                MessageBox.Show("Please Select User","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

        }
        private void btnNextToFineInfo_Click(object sender, EventArgs e)
        {
            if (ctrlBorrowingRecordDetailsWithFilter1.BorrowingRecordID != -1)
            {
                btnSave.Enabled = true;
                tbRecordInfo.Enabled = false;
                tbFineInfo.Enabled = true;
                tbInfo.SelectedTab = tbInfo.TabPages["tbFineInfo"];
                _PreventAddingNewFineForTheSameRecord();
                CalculateLateDaysAndFineAmount();

            }
            else
            {
                MessageBox.Show("Please Select a Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Fine.UserID = ctrlUserDetailsWithFilter1.UserID;
            _Fine.BorrowingRecordID = ctrlBorrowingRecordDetailsWithFilter1.BorrowingRecordID;
            _Fine.NumberOfLateDays = int.Parse(lblNumberOfLateDays.Text);
            _Fine.FineAmount = int.Parse(lblFineAmount.Text);
            _Fine.PaymentStatus = rbPaid.Checked ? true : false;

            if (_Fine.Save())
            {
                lblFineID.Text = _Fine.FineID.ToString();
                MessageBox.Show("Data Saved Successfully");
                _Mode = enMode.Update;
                lblTitle.Text = "Update Fines";
                this.Text = "Update Fines";
            }
            else
                MessageBox.Show("Fine Failed To Save");

        }

    }
}
