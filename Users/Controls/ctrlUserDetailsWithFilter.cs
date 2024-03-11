using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLibraryWinForm.Users.Controls
{
    public partial class ctrlUserDetailsWithFilter : UserControl
    {
        public int UserID
        {
            get { return ctrlUserDetails1.UserID; }
        }

        private bool _FilteredEnabled = true;
        public bool FilteredEnabled
        {
            get { return _FilteredEnabled; }
            set {
                _FilteredEnabled = value;
                 gpFilter.Enabled = _FilteredEnabled;
            }
        }
        public ctrlUserDetailsWithFilter()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID)
        {
            txtFilterBy.Text = UserID.ToString();
            ctrlUserDetails1.LoadUserDetails(UserID);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            ctrlUserDetails1.LoadUserDetails(int.Parse(txtFilterBy.Text));
        }

        public void frmDataBack(object sender, int UserID)
        {
            txtFilterBy.Text = UserID.ToString();
            ctrlUserDetails1.LoadUserDetails(UserID);
        }
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.DataBack += frmDataBack;
            frm.ShowDialog();

        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void txtFocus()
        {
            txtFilterBy.Focus();
        }

    }
}
