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
    public partial class frmAddEditCopy : Form
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode;
        int _CopyID = -1;
        clsCopies _Copy;
        public frmAddEditCopy()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditCopy(int CopyID)
        {
            InitializeComponent();

            _CopyID = CopyID;

            _Mode = enMode.Update;
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                _Copy = new clsCopies();
                this.Text = "Add New Copy";
                lblTitle.Text = "Add New Copy";
            }
            else
            {
                this.Text = "Update Copy";
                lblTitle.Text = "Update Copy";
                //tbBookInfo.Enabled = false;
            }
            tbCopyInfo.Enabled = false;
            rbAvailable.Checked = true;
        }
        private void _LoadData()
        {
            _Copy = clsCopies.Find(_CopyID);
            ctrlBookDetailsWithFilter1.FilterEnabled = false;
            if (_Copy == null)
            {
                MessageBox.Show("This form will be closed because No Copy with ID = " + _CopyID);
                this.Close();
                return;
            }
            ctrlBookDetailsWithFilter1.LoadBookInfo(_Copy.BookID);
            lblCopyID.Text = _Copy.CopyID.ToString();
            rbAvailable.Checked = _Copy.AvailabilityStatus == true ? true : false;
        }
        private void frmAddEditCopy_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void frmAddEditCopy_Activated(object sender, EventArgs e)
        {
            ctrlBookDetailsWithFilter1.txtFocus();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlBookDetailsWithFilter1.BookID != -1)
            {
                tbBookInfo.Enabled = false;
                tbCopyInfo.Enabled = true;
                tbInfo.SelectedTab = tbInfo.TabPages["tbCopyInfo"];

                btnSave.Enabled = true;
            }
            else
                MessageBox.Show("Please Select a Book", "Select a Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ctrlBookDetailsWithFilter1.txtFocus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Copy.BookID = ctrlBookDetailsWithFilter1.BookID;
            _Copy.AvailabilityStatus = rbAvailable.Checked;

            if (_Copy.Save())
            {
                lblCopyID.Text = _Copy.CopyID.ToString();
                MessageBox.Show("Data Saved Successfully");
                _Mode = enMode.Update;
                lblTitle.Text = "Update Copy";
                this.Text = "Update Copy";
            }
            else
                MessageBox.Show("Copy Failed To Save");
        }
    }
}
    