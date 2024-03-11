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

namespace SimpleLibraryWinForm.BookCopies.Controls
{
    public partial class ctrlCopyDetailsWithFilter : UserControl
    {
        public int CopyID
        {
            get { return ctrlCopyDetails1.CopyID; }
        }

        private bool _FilteredEnabled = true;

        public bool FilteredEnabled
        {
            get { return _FilteredEnabled; }
            set
            {
                _FilteredEnabled = value;
                gpFilter.Enabled = _FilteredEnabled;
            }
        }

        public clsCopies CopyInfo
        {
            get { return ctrlCopyDetails1.SelectedCopyInfo; }

        }
        public ctrlCopyDetailsWithFilter()
        {
            InitializeComponent();
        }

        public event Action<int> OnCopySelected;
        
        protected virtual void CopySelected(int CopyID)
        {
            Action <int> handler = OnCopySelected;
            if (handler != null)
            {
                handler(CopyID);
            }
        }
        public void LoadCopyInfo(int CopyID)
        {
            txtFilterBy.Text = CopyID.ToString();
            ctrlCopyDetails1.LoadCopyInfo(CopyID);
        }
        private void ctrlCopyDetailsWithFilter_Load(object sender, EventArgs e)
        {
            txtFilterBy.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            ctrlCopyDetails1.LoadCopyInfo(int.Parse(txtFilterBy.Text));

            if (OnCopySelected != null && FilteredEnabled)
                CopySelected(CopyID);
        }
        public void txtFocus()
        {
            txtFilterBy.Focus();
        }

        private void btnAddNewCopy_Click(object sender, EventArgs e)
        {
            frmAddEditCopy frm = new frmAddEditCopy();
            frm.DataBack += DataBackEvent;
            frm.ShowDialog();
        }

        private void DataBackEvent(object sender , int CopyID)
        {
            txtFilterBy.Text = CopyID.ToString();
            ctrlCopyDetails1.LoadCopyInfo(CopyID);
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == (char) 13)
            {
                btnFind.PerformClick();
            }
        }

        private void txtFilterBy_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilterBy.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilterBy, "text cannot be empty");
            }
            else
                errorProvider1.SetError(txtFilterBy, "");
        }
   

    
    }
}
