using SimpleLibraryBusinessLayer;
using SimpleLibraryWinForm.Books;
using SimpleLibraryWinForm.Global_Classes;
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
    public partial class frmAddEditBorrowingRecord : Form
    {
        enum enMode { AddNew = 0 , Update = 1}
        enMode _Mode;
        private int _RecordID;
        clsBorrowingRecords _Record;

        public delegate void DataBackHandler(object sender, int RecordID);

        public DataBackHandler DataBack;
        public frmAddEditBorrowingRecord()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditBorrowingRecord(int RecordID)
        {
            InitializeComponent();
            _RecordID = RecordID;
            _Mode = enMode.Update;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
            _Record = new clsBorrowingRecords();
            lblTitle.Text = "Add New Borrowing Record";
            this.Text = lblTitle.Text;

            } else
            {
                lblTitle.Text = "Update Borrowing Record";
                this.Text = lblTitle.Text;
            }

            dateTimePickerOfBorrowingDate.MinDate = DateTime.Now;
            dateTimePickerOfDueDate.MinDate = DateTime.Now;
            tbCopyInfo.Enabled = false;
            tbRecordInfo.Enabled = false;
        }


        private void _LoadData()
        {
            _Record = clsBorrowingRecords.Find(_RecordID);
            ctrlUserDetailsWithFilter1.FilteredEnabled = false;
            ctrlCopyDetailsWithFilter1.FilteredEnabled = false;
            if (_Record == null)
            {
                MessageBox.Show("This form will be closed because No Record with ID = " + _RecordID);
                this.Close();
                return;
            }

            ctrlUserDetailsWithFilter1.LoadUserInfo(_Record.UserID);
            ctrlCopyDetailsWithFilter1.LoadCopyInfo(_Record.CopyID);
            lblRecordID.Text = _Record.BorrowingRecordID.ToString();

            if (DateTime.Now.Date >= _Record.BorrowingDate.Date)
            {
                dateTimePickerOfBorrowingDate.MinDate = DateTime.Now;
                dateTimePickerOfDueDate.MinDate = DateTime.Now;
            }
            else
            {
                dateTimePickerOfBorrowingDate.MinDate = _Record.BorrowingDate;
                dateTimePickerOfDueDate.MinDate = _Record.DueDate;
            }
            tbRecordInfo.Enabled = false;
        }


        private void frmAddEditBorrowingRecord_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void frmAddEditBorrowingRecord_Activated(object sender, EventArgs e)
        {
            ctrlCopyDetailsWithFilter1.txtFocus();
        }

        private void btnNextToCopyInfo_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tbCopyInfo.Enabled = true;
                tbInfo.SelectedTab = tbInfo.TabPages["tbCopyInfo"];
                return;
            }


            if (ctrlUserDetailsWithFilter1.UserID != -1)
            {
                btnSave.Enabled = true;
                tbCopyInfo.Enabled = true;
                tbInfo.SelectedTab = tbInfo.TabPages["tbCopyInfo"];
            }
            else
                MessageBox.Show("Please Select a User", "Select a User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ctrlUserDetailsWithFilter1.txtFocus();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tbRecordInfo.Enabled = true;
                tbInfo.SelectedTab = tbInfo.TabPages["tbRecordInfo"];
                return;
            }


                if (ctrlCopyDetailsWithFilter1.CopyID != -1)
            {
                if (clsBorrowingRecords.IsRecordExistForCopyID(ctrlCopyDetailsWithFilter1.CopyID))
                {
                    MessageBox.Show("this Copy is Borrowed , Please Choose Another One", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (clsReservations.IsReservationExistForCopyID(ctrlCopyDetailsWithFilter1.CopyID))
                {
                    MessageBox.Show("Copy is Reserved,Choose another Copy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                clsGlobal.CopyID = ctrlCopyDetailsWithFilter1.CopyID;

                if (!clsGlobal.IsCopyAvailable())
                {
                    MessageBox.Show("Copy is Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                btnSave.Enabled = true;
                tbCopyInfo.Enabled = false;
                tbRecordInfo.Enabled = true ;
                tbInfo.SelectedTab = tbInfo.TabPages["tbRecordInfo"];


            } else
           MessageBox.Show("Please Select a Copy", "Select a Copy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ctrlCopyDetailsWithFilter1.txtFocus();


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Record.UserID  = ctrlUserDetailsWithFilter1.UserID;
            _Record.CopyID = ctrlCopyDetailsWithFilter1.CopyID;
            _Record.BorrowingDate = dateTimePickerOfBorrowingDate.Value;
            _Record.DueDate = dateTimePickerOfDueDate.Value;
            _Record.ActualReturnDate = null;
            if (_Record.Save())
            {
                lblRecordID.Text = _Record.BorrowingRecordID.ToString();
                MessageBox.Show("Data Saved Successfully");
                _Mode = enMode.Update;
                lblTitle.Text = "Update Borrowing Record";
                this.Text = "Update Borrowing Record";
                DataBack?.Invoke(this,_Record.BorrowingRecordID);
            }
            else
                MessageBox.Show("Record Failed To Save");
        }

    }
}
