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
    public partial class ctrlBookDetails : UserControl
    {
        clsBooks _Book;
        public ctrlBookDetails()
        {
            InitializeComponent();
        }

        public void LoadBookInfo(int BookID)
        {
            _Book = clsBooks.Find(BookID);
            if (_Book == null )
            {
                MessageBox.Show("Book doesn't exist","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            _Book.BookID = BookID;
            lblBookID.Text = _Book.BookID.ToString();
            lblTitle.Text = _Book.Title;
            lblISBN.Text = _Book.ISBN;
            lblPublicationDate.Text = _Book.PublicationDate.ToString();
            lblGenre.Text = _Book.Genre;
            lblAdditionalDetails.Text = _Book.AdditionalDetails;
            
        }
    }
}
