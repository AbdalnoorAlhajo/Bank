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

namespace Bank_Desktop.Users.Users_Controllers
{
    public partial class cntrlUserInfo : UserControl
    {
        clsUsersDTO _userDTO;
        public cntrlUserInfo()
        {
            InitializeComponent();
        }

        private void cntrlUserInfo_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Updates the user information displayed in the control with the provided user data.
        /// </summary>
        /// <param name="UserDTO">The user data transfer object containing user information.</param>
        public void ChangeInfo(clsUsersDTO UserDTO)
        {
            // If the provided UserDTO is null, exit the method
            if (UserDTO == null)
                return;

            // Update the labels with user information
            lbID.Text = UserDTO.ID.ToString();
            lbPermissions.Text = UserDTO.Permissions.ToString();
            lbPersonID.Text = UserDTO.PersonID.ToString();
            lbUserName.Text = UserDTO.UserName.ToString();

            // Enable the update link if user information is valid
            linklbUpdateUser.Enabled = true;

            // Store the user data transfer object for future reference
            _userDTO = UserDTO;
        }

        /// <summary>
        /// Clears the user information displayed in the control.
        /// This resets the labels to their default state.
        /// </summary>
        public void ClearInfo()
        {
            // Reset labels to default values
            lbID.Text = "{???}";
            lbPermissions.Text = "{???}";
            lbPersonID.Text = "{???}";
            lbUserName.Text = "{???}";

            // Disable the update link as there is no user information to update
            linklbUpdateUser.Enabled = false;

            _userDTO = null;
        }

        private void linklbUpdateUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Show the update form with the current user information
            frmAddUpdateUser frm = new frmAddUpdateUser(_userDTO);
            frm.ShowDialog();

            // Refresh the user information displayed in the control after updating
            ChangeInfo(_userDTO);
        }
    }
}
