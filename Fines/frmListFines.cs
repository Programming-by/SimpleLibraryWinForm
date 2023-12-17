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

namespace SimpleLibraryWinForm.Fines
{
    public partial class frmListFines : Form
    {
        public frmListFines()
        {
            InitializeComponent();
        }
        public DataTable _dtFines = new DataTable();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListFines_Load(object sender, EventArgs e)
        {

            cbFilters.SelectedIndex = 0;
            _dtFines = clsFines.GetAllFines();
            dgvFines.DataSource = _dtFines;

            if (dgvFines.Rows.Count > 0)
            {
                dgvFines.Columns[0].HeaderText = "Fine ID";
                dgvFines.Columns[0].Width = 110;

                dgvFines.Columns[1].HeaderText = "Name";
                dgvFines.Columns[1].Width = 180;

                dgvFines.Columns[2].HeaderText = "Title";
                dgvFines.Columns[2].Width = 140;

                dgvFines.Columns[3].HeaderText = "Borrowing Date";
                dgvFines.Columns[3].Width = 140;

                dgvFines.Columns[4].HeaderText = "Due Date";
                dgvFines.Columns[4].Width = 140;

                dgvFines.Columns[5].HeaderText = "Actual Return Date";
                dgvFines.Columns[5].Width = 140;

                dgvFines.Columns[6].HeaderText = "Number Of Late Days";
                dgvFines.Columns[6].Width = 110;

                dgvFines.Columns[7].HeaderText = "Fine Amount";
                dgvFines.Columns[7].Width = 120;

                dgvFines.Columns[8].HeaderText = "Payment Status";
                dgvFines.Columns[8].Width = 130;


            }
            lblRecordsCount.Text = dgvFines.Rows.Count.ToString();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (cbFilters.Text != "None");
            txtFilter.Text = "";
            txtFilter.Focus();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (cbFilters.Text)
            {
                case "FineID":
                    FilterColumn = "FineID";
                    break;
                case "Name":
                    FilterColumn = "Name";
                    break;
                case "Title":
                    FilterColumn = "Title";
                    break;
         
            }

            if (cbFilters.Text == "None" || txtFilter.Text.Trim() == "")
            {
                _dtFines.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvFines.Rows.Count.ToString();
                return;
            }

            if (cbFilters.Text == "FineID")
                _dtFines.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
            else
                _dtFines.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());
            lblRecordsCount.Text = dgvFines.Rows.Count.ToString();
        }

        private void btnAddNewFine_Click(object sender, EventArgs e)
        {

        }

        private void addNewFineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editFineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteFineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this fine?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            int FineID = (int)dgvFines.CurrentRow.Cells[0].Value;
            if (clsFines.DeleteFine(FineID))
            {
                MessageBox.Show("Fine Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListFines_Load(null, null);
            }
            else
                MessageBox.Show("Fine Failed to Delete", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilters.Text == "FineID")
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
