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
                frmAddEditUser_Load(null, null);    
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
    }
}
