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
    public partial class ctrlBookDetailsWithFilter : UserControl
    {
        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get { return _FilterEnabled; }

            set { _FilterEnabled = value; }
        }

        private int _BookID;
        public int BookID
        {
            get { return ctrlBookDetails1.BookID; }
        }

        public clsBooks _SelectedBookInfo
        {
            get { return ctrlBookDetails1.SelectedBookInfo; }

        }
        public ctrlBookDetailsWithFilter()
        {
            InitializeComponent();
        }


        public event Action<int> OnBookSelected;
        protected virtual void BookSelected(int BookID)
        {
            Action<int> handler = OnBookSelected;

            if (handler != null)
                handler(BookID);
        }
        
        public void LoadBookInfo(int BookID)
        {
            cbFilters.SelectedIndex = 0;
            txtFilterBy.Text = BookID.ToString();
            FindNow();
        }
        public void FindNow()
        {
            switch (cbFilters.Text)
            {
                case "BookID":
                    ctrlBookDetails1.LoadBookInfo(int.Parse(txtFilterBy.Text));
                    break;
                case "Genre":
                    ctrlBookDetails1.LoadBookInfo(txtFilterBy.Text);
                    break;
            }
            if (OnBookSelected != null && FilterEnabled)
                BookSelected(ctrlBookDetails1.BookID);
        }
        
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FindNow();

        }
        private void ctrlBookDetailsWithFilter_Load(object sender, EventArgs e)
        {
            cbFilters.SelectedIndex = 0;
            txtFilterBy.Focus();
        }

        public void txtFocus()
        {
            txtFilterBy.Focus();
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            frmAddEditBook frm = new frmAddEditBook();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }

        private void cbFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterBy.Text = "";
            txtFilterBy.Focus();
        }

        private void txtFilterBy_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterBy.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterBy, "text cannot be empty");
            } else
                errorProvider1.SetError(txtFilterBy, "");
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnFind.PerformClick();
            }


            if (cbFilters.Text == "BookID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
  
    
        public void DataBackEvent(object sender, int BookID)
        {
            cbFilters.SelectedIndex = 0;
            txtFilterBy.Text = BookID.ToString();
            ctrlBookDetails1.LoadBookInfo(BookID);
        }
    
    }
}
