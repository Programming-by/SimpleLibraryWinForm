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

            lblFineID.Text = _Fine.FineID.ToString();
            numericUpDownUserID.Value = _Fine.UserID;
            numericUpDownRecordID.Value = _Fine.BorrowingRecordID;
            lblNumberOfLateDays.Text = _Fine.NumberOfLateDays.ToString();
            lblFineAmount.Text = _Fine.FineAmount.ToString() + "$";
            chkPaymentStatus.Checked = _Fine.PaymentStatus;
      
        }

        private void frmAddEditFine_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
            numericUpDownRecordID_ValueChanged(null, null);
        }

     
        private void numericUpDownRecordID_ValueChanged(object sender, EventArgs e)
        {
            clsBorrowingRecords _Record = clsBorrowingRecords.Find((int)numericUpDownRecordID.Value);

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
                    MessageBox.Show("Cannot Add Fine to this Record because its not late");
                    btnSave.Enabled = false;
                    return;
                }
            } 
            else
            {
                return;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Fine.UserID = (int) numericUpDownUserID.Value;
            _Fine.BorrowingRecordID = (int) numericUpDownRecordID.Value;
            _Fine.NumberOfLateDays = int.Parse(lblNumberOfLateDays.Text);
            _Fine.FineAmount = int.Parse(lblFineAmount.Text);
            _Fine.PaymentStatus = false;

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
