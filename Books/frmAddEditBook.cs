using SimpleLibraryBusinessLayer;
using SimpleLibraryWinForm.Custom_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SimpleLibraryWinForm.Books
{
    public partial class frmAddEditBook : Form
    {
        clsBooks _Book;

        private int _BookID = -1;
        public frmAddEditBook()
        {
            InitializeComponent();
        }

        public frmAddEditBook(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadData()
        {
            if (_BookID == -1)
            {
                lblTitle.Text = "Add New Book";
                _Book = new clsBooks();
                return;
            }
            else
            {
                lblTitle.Text = "Update Book";
                _Book = clsBooks.Find(_BookID);
                if (_Book == null)
                {
                    MessageBox.Show("Book doesn't Exist");
                    return;
                }
                txtTitle.Text = _Book.Title;
                txtISBN.Text = _Book.ISBN;
                dateTimePicker1.Value = _Book.PublicationDate;
                cbGenre.Text = _Book.Genre;
                txtAdditionalDetails.Text = _Book.AdditionalDetails;
            }
        }

        private void frmAddEditBook_Load(object sender, EventArgs e)
        {
            cbGenre.SelectedIndex = 0;
            dateTimePicker1.MaxDate = DateTime.Parse(clsFormat.DateToShort(DateTime.Now));
            _LoadData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Book.Title = txtTitle.Text;
            _Book.ISBN = txtISBN.Text;
            _Book.PublicationDate = dateTimePicker1.Value;
            _Book.Genre = cbGenre.Text;
            _Book.AdditionalDetails = txtAdditionalDetails.Text;
            if (_Book.Save())
            {
                MessageBox.Show("Data Saved Successfully");
                lblUserID.Text = _Book.BookID.ToString();
            }
            else
            {
                MessageBox.Show("Book Failed To Save");
            }
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTitle, "Title cannot be empty");
            }
            else
                errorProvider1.SetError(txtTitle, "");
        }

        private void txtISBN_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtISBN.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtISBN, "ISBN cannot be empty");
            }
            else
                errorProvider1.SetError(txtISBN, "");
        }
    }
}
