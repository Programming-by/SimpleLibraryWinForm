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
        enum enMode { AddNew = 0 , Update = 1 }
        enMode _Mode;
        int _BookID = -1;

        clsCopies _Copy;
        public frmAddEditCopy(int BookID)
        {
            InitializeComponent();

            _BookID = BookID;

            if (_BookID == -1)
            {
                _Mode = enMode.AddNew;
            } else
            {
                _Mode = enMode.Update;
            }
        }

        private void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                _Copy = new clsCopies();
                lblTitle.Text = "Add New Copy";
                return;
            }


        }

        private void frmAddEditCopy_Activated(object sender, EventArgs e)
        {
            ctrlBookDetailsWithFilter1.txtFocus();
        }

        private void ctrlBookDetailsWithFilter1_OnBookSelected(int obj)
        {
            _BookID = obj;
            if (_BookID != -1)
            MessageBox.Show("Selected BookID is: " + _BookID);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbBookInfo.Enabled = false;
            tabControl1.SelectedTab = tbCopyInfo;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Copy.BookID = _BookID;
            _Copy.AvailabilityStatus = rbAvailable.Checked;

            if (_Copy.Save())
            {
                MessageBox.Show("Data Saved Successfully");
                lblCopyID.Text = _Copy.CopyID.ToString();

            }
            else
            {
                MessageBox.Show("Copy Failed To Save");
            }

        }

        private void frmAddEditCopy_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
