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

namespace SimpleLibraryWinForm.Books
{
    public partial class frmListBooks : Form
    {
        public frmListBooks()
        {
            InitializeComponent();
        }

        private DataTable _dtBooks = new DataTable();


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            _dtBooks = clsBooks.GetAllBooks();
            dgvBooks.DataSource = _dtBooks;

            if (dgvBooks.Rows.Count > 0)
            {
                dgvBooks.Columns[0].HeaderText = "Book ID";
                dgvBooks.Columns[0].Width = 110;

                dgvBooks.Columns[1].HeaderText = "Title";
                dgvBooks.Columns[1].Width = 180;

                dgvBooks.Columns[2].HeaderText = "ISBN";
                dgvBooks.Columns[2].Width = 140;

                dgvBooks.Columns[3].HeaderText = "Publication Date";
                dgvBooks.Columns[3].Width = 180;

                dgvBooks.Columns[4].HeaderText = "Genre";
                dgvBooks.Columns[4].Width = 150;

                dgvBooks.Columns[5].HeaderText = "Additional Details";
                dgvBooks.Columns[5].Width = 170;
            }
            lblRecordsCount.Text = dgvBooks.Rows.Count.ToString();

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
                case "BookID":
                    FilterColumn = "BookID";
                    break;
                case "Title":
                    FilterColumn = "Title";
                    break;
                case "ISBN":
                    FilterColumn = "ISBN";
                    break;
                case "Genre":
                    FilterColumn = "Genre";
                    break;
            }

            if (cbFilters.Text == "None" || txtFilter.Text.Trim() == "")
            {
                _dtBooks.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvBooks.Rows.Count.ToString();
                return;
            }

            if (cbFilters.Text == "BookID")
                _dtBooks.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
            else
                _dtBooks.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());
            lblRecordsCount.Text = dgvBooks.Rows.Count.ToString();
        }
    }
}
