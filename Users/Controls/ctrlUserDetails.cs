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

namespace SimpleLibraryWinForm.Users.Controls
{
    public partial class ctrlUserDetails : UserControl
    {
        private clsUsers _User;

        public clsUsers User { get { return _User; } }

        private int _UserID = -1;

        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        public ctrlUserDetails()
        {
            InitializeComponent();
        }

        public void LoadUserDetails(int UserID)
        {
            _User = clsUsers.Find(UserID);

            if (_User == null)
            {
                MessageBox.Show("User is not Exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            _UserID = _User.UserID;
            lblUserID.Text = _User.UserID.ToString();
            lblName.Text = _User.Name;
            lblContactInformation.Text = _User.ContactInformation;
            lblLibraryCardNumber.Text = _User.LibraryCardNumber;
        }
    }
}
