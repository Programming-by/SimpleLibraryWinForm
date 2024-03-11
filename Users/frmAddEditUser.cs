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

namespace SimpleLibraryWinForm.Users
{
    public partial class frmAddEditUser : Form
    {
        clsUsers _User;

        private int _UserID = -1;

        public delegate void DataBackHandler(object sender , int UserID);

        public DataBackHandler DataBack;
        public frmAddEditUser()
        {
            InitializeComponent();
        }

        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }
        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
        private void _LoadData()
        {
            if (_UserID == -1)
            {
            lblTitle.Text = "Add New User"; 
            _User = new clsUsers();
            return;
            }
            else
            {
            lblTitle.Text = "Update User";
            _User = clsUsers.Find(_UserID);
            if (_User == null)
                {
                    MessageBox.Show("User doesn't Exist");
                    return;
                }
                 txtName.Text = _User.Name;
                 txtContactInformation.Text = _User.ContactInformation;
                 txtLibraryCardNumber.Text = _User.LibraryCardNumber;
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _User.Name = txtName.Text;
            _User.ContactInformation = txtContactInformation.Text;
            _User.LibraryCardNumber = txtLibraryCardNumber.Text;

            if (_User.Save())
            {
                MessageBox.Show("Data Saved Successfully");
                lblUserID.Text = _User.UserID.ToString();
                DataBack?.Invoke(this,_User.UserID);
            } else
            {
                MessageBox.Show("User Failed To Save");
            }
        }

        private void txtLibraryCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == (char)13)
            {
                btnSave.PerformClick();
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtName, "Name cannot be empty");
            } else
                errorProvider1.SetError(txtName, "");

        }

        private void txtContactInformation_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtContactInformation.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtContactInformation, "Contact Information cannot be empty");
            }
            else
                errorProvider1.SetError(txtContactInformation, "");
        }

        private void txtLibraryCardNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLibraryCardNumber.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLibraryCardNumber, "Library Card Number cannot be empty");
            }
            else
                errorProvider1.SetError(txtLibraryCardNumber, "");
        }
    }
}
