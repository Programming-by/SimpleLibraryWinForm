using SimpleLibraryBusinessLayer;
using SimpleLibraryWinForm.Books;
using SimpleLibraryWinForm.Custom_Classes;
using SimpleLibraryWinForm.Global_Classes;
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
    public partial class frmAddEditReservation : Form
    {
        enum enMode { AddNew = 0 , Update = 1 }
        enMode _Mode;
        clsReservations _Reservation;

        private int _ReservationID;
        public frmAddEditReservation()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditReservation(int ReservationID)
        {
            InitializeComponent();
            _ReservationID = ReservationID;
            _Mode = enMode.Update;
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Reservation";
                this.Text = lblTitle.Text;
                _Reservation = new clsReservations();
            }
            else
            {
                lblTitle.Text = "Update Reservation";
                this.Text = lblTitle.Text;
            }
            tbReservationInfo.Enabled = false;
         
        }
        private void _LoadData()
        {
            _Reservation = clsReservations.Find(_ReservationID);
            ctrlCopyDetailsWithFilter1.FilteredEnabled = false;
            if (_Reservation == null)
            {
                MessageBox.Show("This form will be closed because No Copy with ID = " + _ReservationID);
                this.Close();
                return;
            }
            ctrlCopyDetailsWithFilter1.LoadCopyInfo(_Reservation.CopyID);
            lblReservationID.Text = _ReservationID.ToString();
            numericUpDown1.Value = _Reservation.UserID;
            dateTimePicker1.Value = _Reservation.ReservationDate;

        }


        private void frmAddEditReservation_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (_Mode == enMode.Update)
            {
                btnSave.Enabled = true;
                tbReservationInfo.Enabled = true;
                tbInfo.SelectedTab = tbInfo.TabPages["tbReservationInfo"];
                return;
            }
          
            if (ctrlCopyDetailsWithFilter1.CopyID != -1)
            {
                clsGlobal.CopyID = ctrlCopyDetailsWithFilter1.CopyID;
                if (!clsGlobal.IsCopyAvailable())
                {
                    MessageBox.Show("Copy is not available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (clsReservations.IsReservationExistForCopyID(ctrlCopyDetailsWithFilter1.CopyID))
            {
                MessageBox.Show("Copy is Reserved,Choose another Copy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else
                {
                    btnSave.Enabled = true;
                    tbReservationInfo.Enabled = true;
                    tbInfo.SelectedTab = tbInfo.TabPages["tbReservationInfo"];
                }

            } else
            MessageBox.Show("Please Select a Copy", "Select a Copy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ctrlCopyDetailsWithFilter1.txtFocus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
        
            _Reservation.UserID = (int) numericUpDown1.Value;
            _Reservation.CopyID = ctrlCopyDetailsWithFilter1.CopyID;
            _Reservation.ReservationDate = dateTimePicker1.Value;

            if (_Reservation.Save())
            {
                _Mode = enMode.Update;
                MessageBox.Show("Data Saved Successfully");
                lblReservationID.Text = _Reservation.ReservationID.ToString();
                lblTitle.Text = "Update Reservation";
                this.Text = "Update Reservation";
            } else
            {
                MessageBox.Show("Reservation Failed To Save");
            }
        }
    }
}
