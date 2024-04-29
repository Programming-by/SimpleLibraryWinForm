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

namespace SimpleLibraryWinForm.Available_Book_Copies
{
    public partial class frmListAvailableBookCopies : Form
    {
        public frmListAvailableBookCopies()
        {
            InitializeComponent();
        }
        public DataTable _dtAvailableCopies = new DataTable();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAvailableBookCopies_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            _dtAvailableCopies = clsCopies.GetAvailableCopies();
            dgvAvailableCopies.DataSource = _dtAvailableCopies;

            if (dgvAvailableCopies.Rows.Count > 0)
            {

                dgvAvailableCopies.Columns[0].HeaderText = "Book ID";
                dgvAvailableCopies.Columns[0].Width = 150;

                dgvAvailableCopies.Columns[1].HeaderText = "Title";
                dgvAvailableCopies.Columns[1].Width = 150;

                dgvAvailableCopies.Columns[2].HeaderText = "Genre";
                dgvAvailableCopies.Columns[2].Width = 130;

                dgvAvailableCopies.Columns[3].HeaderText = "Available Copies";
                dgvAvailableCopies.Columns[3].Width = 120;
            }
            lblRecordsCount.Text = dgvAvailableCopies.Rows.Count.ToString();
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
            switch(cbFilters.Text)
            {
                case "BookID":
                    FilterColumn = "BookID";
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
                _dtAvailableCopies.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvAvailableCopies.Rows.Count.ToString();
                return;
            }

            if (cbFilters.Text == "BookID")
            {
                _dtAvailableCopies.DefaultView.RowFilter = string.Format("[{0}] = {1}" , FilterColumn , txtFilter.Text.Trim());
            }else
            {
                _dtAvailableCopies.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());
            }
            lblRecordsCount.Text = dgvAvailableCopies.Rows.Count.ToString();

        }
    }
}
;