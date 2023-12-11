using SimpleLibraryBusinessLayer;
using SimpleLibraryWinForm.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLibraryWinForm
{
    public partial class frmListUsers : Form
    {
        public frmListUsers()
        {
            InitializeComponent();
        }

        private DataTable _dtUsers = new DataTable();
        private void frmListUsers_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            _dtUsers = clsUsers.GetAllUsers();
            dgvUsers.DataSource = _dtUsers;

            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns[0].HeaderText = "User ID";
                dgvUsers.Columns[0].Width = 120;

                dgvUsers.Columns[1].HeaderText = "Name";
                dgvUsers.Columns[1].Width = 180;

                dgvUsers.Columns[2].HeaderText = "Contact Information";
                dgvUsers.Columns[2].Width = 160;

                dgvUsers.Columns[3].HeaderText = "Library Card Number";
                dgvUsers.Columns[3].Width = 180;
            }
                lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
            

        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.Text == "None")
            {
                txtFilter.Visible = false;
            }
            else
            {
                txtFilter.Text = "";
                txtFilter.Visible = true;
                txtFilter.Focus();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilters.Text)
            {
                case "UserID":
                    FilterColumn = "UserID";
                    break;
                case "Name":
                    FilterColumn = "Name";
                    break;
                case "Contact Information":
                    FilterColumn = "ContactInformation";
                    break;
                case "Library Card Number":
                    FilterColumn = "LibraryCardNumber";
                    break;
            }

            if (cbFilters.Text == "None" || txtFilter.Text.Trim() == "")
            {
                _dtUsers.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();
                return;
            }

            if (cbFilters.Text == "UserID")
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
            else
                _dtUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());
            lblRecordsCount.Text = dgvUsers.Rows.Count.ToString();

        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();   
            frmListUsers_Load(null,null);
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListUsers_Load(null, null);
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            if (clsUsers.DeleteUsers(UserID))
            {
            MessageBox.Show("User Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmListUsers_Load(null, null);
            } else
                MessageBox.Show("User Failed to Delete", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
