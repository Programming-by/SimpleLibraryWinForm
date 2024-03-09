using SimpleLibraryBusinessLayer;
using SimpleLibraryWinForm.BookCopies.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLibraryWinForm.Global_Classes
{
    public static class clsGlobal
    {
        private static int _CopyID;
        public static int CopyID
        {

            get { return _CopyID; }
            set { _CopyID = value; }
        }


        public static bool IsCopyAvailable()
        {
            clsCopies _Copy = clsCopies.Find(_CopyID);
            if (_Copy == null)
            {
                MessageBox.Show("Copy doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return _Copy.AvailabilityStatus == true ? true : false;
        }


    }
}
