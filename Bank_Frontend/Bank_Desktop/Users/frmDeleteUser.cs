using Bank_Desktop_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Desktop.Users
{
    public partial class frmDeleteUser : Form
    {
        clsUsersDTO _userDTO;

        public frmDeleteUser()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // If _userDTO is null, exit the method as there is no user to delete.
                if (_userDTO == null)
                    return;

                // Disable the delete button to prevent multiple clicks.
                btnDelete.Enabled = false;

                bool isUserDeleted = await clsUsers.DeleteUser(_userDTO.ID);

                // Check if the user was deleted successfully.
                if (isUserDeleted)
                    MessageBox.Show("User Deleted Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Failed to Delete User", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnDelete.Enabled = true; // Re-enable the delete button for another attempt.
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Deleting User: " + ex.Message);
            }

        }

        private void cntrlFindUserWithFillter1_OnSearchClicked(Bank_Desktop_DataAccess.clsUsersDTO obj)
        {
            // If no user is found, disable the delete button.
            if (obj == null) 
                btnDelete.Enabled = false;

            // If a user is found, enable the delete button and store the user data in _userDTO.
            else
            {
                btnDelete.Enabled = true;
                _userDTO = obj;
            }

        }
    }
}
