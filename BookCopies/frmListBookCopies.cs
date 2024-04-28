using SimpleLibraryBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLibraryWinForm.BookCopies
{
    public partial class frmListBookCopies : Form
    {
        public frmListBookCopies()
        {
            InitializeComponent();
        }

        public DataTable _dtCopies = new DataTable();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListBookCopies_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            _dtCopies = clsCopies.GetAllCopies();
            dgvCopies.DataSource = _dtCopies;

            if (dgvCopies.Rows.Count > 0)
            {
                dgvCopies.Columns[0].HeaderText = "Copy ID";
                dgvCopies.Columns[0].Width = 110;

                dgvCopies.Columns[1].HeaderText = "Title";
                dgvCopies.Columns[1].Width = 180;

                dgvCopies.Columns[2].HeaderText = "ISBN";
                dgvCopies.Columns[2].Width = 140;

                dgvCopies.Columns[3].HeaderText = "Genre";
                dgvCopies.Columns[3].Width = 150;

                dgvCopies.Columns[4].HeaderText = "Availability Status";
                dgvCopies.Columns[4].Width = 130;


            }
            lblRecordsCount.Text = dgvCopies.Rows.Count.ToString();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilters.Text == "None")
            {
                txtFilter.Visible = false;
                cbAvailabilityStatus.Visible = false;
            }
            else
            {
                if (cbFilters.Text == "Availability Status")
                {
                    txtFilter.Visible = false;
                    cbAvailabilityStatus.Visible = true;
                    cbAvailabilityStatus.SelectedIndex = 0;
                    return;
                }
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
                case "CopyID":
                    FilterColumn = "CopyID";
                    break;
                case "Title":
                    FilterColumn = "Title";
                    break;
                case "Genre":
                    FilterColumn = "Genre";
                    break;
                case " Availability Status":
                    FilterColumn = "AvailabilityStatus";
                    break;
            }

            if (cbFilters.Text == "None" || txtFilter.Text.Trim() == "")
            {
                _dtCopies.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvCopies.Rows.Count.ToString();
                return;
            }

            if (cbFilters.Text == "CopyID")
                _dtCopies.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
            else
                _dtCopies.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());
            lblRecordsCount.Text = dgvCopies.Rows.Count.ToString();
        }

        private void cbAvailabilityStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "AvailabilityStatus";
            bool FilterResult = false;
            switch (cbAvailabilityStatus.Text)
            {
                case "All":
                    break;
                case "Yes":
                    FilterResult = true;
                    break;
                case "Genre":
                    FilterResult = false;
                    break;
            }

            if (cbAvailabilityStatus.Text == "All")
                _dtCopies.DefaultView.RowFilter = "";
            else
                _dtCopies.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterResult);
           
            lblRecordsCount.Text = dgvCopies.Rows.Count.ToString();
        }

        private void btnAddNewCopy_Click(object sender, EventArgs e)
        {
            frmAddEditCopy frm = new frmAddEditCopy();
            frm.ShowDialog();
            frmListBookCopies_Load(null, null);
        }
        private void showCopyDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCopyDetails frm = new frmCopyDetails((int)dgvCopies.CurrentRow.Cells[0].Value);
            frm.ShowDialog();   
        }
        private void addNewCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditCopy frm = new frmAddEditCopy();
            frm.ShowDialog();
            frmListBookCopies_Load(null, null);
        }

        private void editCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditCopy frm = new frmAddEditCopy((int)dgvCopies.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListBookCopies_Load(null,null);
        }

        private void deleteCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this copy?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            int CopyID = (int)dgvCopies.CurrentRow.Cells[0].Value;
            if (clsCopies.DeleteCopies(CopyID))
            {
                MessageBox.Show("Copy Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListBookCopies_Load(null, null);
            }
            else
                MessageBox.Show("Copy Failed to Delete", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvCopies_DoubleClick(object sender, EventArgs e)
        {
            frmCopyDetails frm = new frmCopyDetails((int)dgvCopies.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }
    }
}
