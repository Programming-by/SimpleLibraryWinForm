using SimpleLibraryBusinessLayer;
using SimpleLibraryWinForm.Borrowing_Records;
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
    public partial class frmListBorrowingRecords : Form
    {
        public frmListBorrowingRecords()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DataTable _dtRecords = new DataTable();

        private void frmListBorrowingRecords_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            _dtRecords = clsBorrowingRecords.GetAllBorrowingRecords();
            dgvRecords.DataSource = _dtRecords;

            if (dgvRecords.Rows.Count > 0)
            {
                dgvRecords.Columns[0].HeaderText = "Borrowing Record ID";
                dgvRecords.Columns[0].Width = 110;

                dgvRecords.Columns[1].HeaderText = "Name";
                dgvRecords.Columns[1].Width = 180;

                dgvRecords.Columns[2].HeaderText = "Title";
                dgvRecords.Columns[2].Width = 140;

                dgvRecords.Columns[3].HeaderText = "Genre";
                dgvRecords.Columns[3].Width = 150;

                dgvRecords.Columns[4].HeaderText = "Borrowing Date";
                dgvRecords.Columns[4].Width = 140;

                dgvRecords.Columns[5].HeaderText = "Due Date";
                dgvRecords.Columns[5].Width = 140;

                dgvRecords.Columns[6].HeaderText = "Actual Return Date";
                dgvRecords.Columns[6].Width = 140;


            }
            lblRecordsCount.Text = dgvRecords.Rows.Count.ToString();
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
                case "BorrowingRecordID":
                    FilterColumn = "BorrowingRecordID";
                    break;
                case "Name":
                    FilterColumn = "Name";
                    break;
                case "Title":
                    FilterColumn = "Title";
                    break;
                case "Genre":
                    FilterColumn = "Genre";
                    break;
            }

            if (cbFilters.Text == "None" || txtFilter.Text.Trim() == "")
            {
                _dtRecords.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvRecords.Rows.Count.ToString();
                return;
            }

            if (cbFilters.Text == "BorrowingRecordID")
                _dtRecords.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
            else
                _dtRecords.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());
            lblRecordsCount.Text = dgvRecords.Rows.Count.ToString();
        }

        private void btnAddNewRecord_Click(object sender, EventArgs e)
        {
               frmAddEditBorrowingRecord frm = new frmAddEditBorrowingRecord();
               frm.ShowDialog();
               frmListBorrowingRecords_Load(null, null);
        }

        private void addNewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditBorrowingRecord frm = new frmAddEditBorrowingRecord();
            frm.ShowDialog();
            frmListBorrowingRecords_Load(null, null);
        }

        private void editRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditBorrowingRecord frm = new frmAddEditBorrowingRecord((int)dgvRecords.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListBorrowingRecords_Load(null, null);
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            int RecordID = (int)dgvRecords.CurrentRow.Cells[0].Value;
            if (clsBorrowingRecords.DeleteBorrowingRecord(RecordID))
            {
                MessageBox.Show("Record Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmListBorrowingRecords_Load(null, null);
            }
            else
                MessageBox.Show("Record Failed to Delete", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
