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

namespace SimpleLibraryWinForm.Reservations
{
    public partial class frmListReservations : Form
    {
        public frmListReservations()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DataTable _dtReservations = new DataTable();

        private void ListReservations_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            _dtReservations = clsReservations.GetAllReservations();
            dgvReservations.DataSource = _dtReservations;

            if (dgvReservations.Rows.Count > 0)
            {
                dgvReservations.Columns[0].HeaderText = "Reservation ID";
                dgvReservations.Columns[0].Width = 110;

                dgvReservations.Columns[1].HeaderText = "Name";
                dgvReservations.Columns[1].Width = 180;

                dgvReservations.Columns[2].HeaderText = "Title";
                dgvReservations.Columns[2].Width = 180;

                dgvReservations.Columns[3].HeaderText = "Genre";
                dgvReservations.Columns[3].Width = 150;

                dgvReservations.Columns[4].HeaderText = "Reservation Date";
                dgvReservations.Columns[4].Width = 180;

            }
            lblRecordsCount.Text = dgvReservations.Rows.Count.ToString();
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
                case "ReservationID":
                    FilterColumn = "ReservationID";
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
                _dtReservations.DefaultView.RowFilter = "";
                lblRecordsCount.Text = dgvReservations.Rows.Count.ToString();
                return;
            }

            if (cbFilters.Text == "ReservationID")
                _dtReservations.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
            else
                _dtReservations.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilter.Text.Trim());
            lblRecordsCount.Text = dgvReservations.Rows.Count.ToString();
        }
    }
}
