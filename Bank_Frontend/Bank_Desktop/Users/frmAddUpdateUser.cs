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
    public partial class frmAddUpdateUser : Form
    {
        /// <summary>
        /// Holds the user data transfer object for the user being added or updated.
        /// </summary>
        clsUsersDTO _userDTO;

        /// <summary>
        /// Enum for specifying the form mode: AddNew or Update.
        /// </summary>
        public enum enMode { AddNew = 0, Update = 1 }

        // Holds the current mode (Add or Update) of the form.
        enMode _Mode = enMode.AddNew;

        // Constructor used for adding a new user.
        public frmAddUpdateUser()
        {
            InitializeComponent();
        }

        // Constructor used for updating an existing user.
        public frmAddUpdateUser(clsUsersDTO usersDTO)
        {
            InitializeComponent();
            _userDTO = usersDTO;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Asynchronously adds a new user to the system by calling the API.
        /// </summary>
        async void _AddNewUser()
        {
            try
            {
                // Disable the Save button to avoid multiple clicks while waiting for the API response.
                btnSave.Enabled = false;

                // Check if the username is already in use.
                _userDTO = await clsUsers.GetUser(txtUserName.Text);
                if (_userDTO != null)
                {
                    MessageBox.Show("This UserName is already reserved for another user", "Invalid UserName"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = true; // Re-enable the button for retry.
                    return;
                }

                _userDTO = new clsUsersDTO(-1, txtUserName.Text, txtPassword.Text
                    , int.Parse(txtPermissions.Text), int.Parse(txtPersonID.Text));

                // Disaple Save button for waiting resopnse from API
                btnSave.Enabled = false;

                // Call the API to add the new user.
                _userDTO = await clsUsers.AddNewUser(_userDTO);
                if (_userDTO == null)
                {
                    MessageBox.Show("Failed to add user", "Internal Error"
                             , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = true; // Re-enable the button for retry.
                    return;
                }

                MessageBox.Show("User added Successfully", "Process Completed "
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Display the newly added user ID.
                lbID.Text = _userDTO.ID.ToString();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error in Adding User: " + ex.Message);
            }
        }

        /// <summary>
        /// Asynchronously updates the existing user data in the system by calling the API.
        /// </summary>
        async void _UpdateUser()
        {
            try
            {
                _userDTO = new clsUsersDTO(_userDTO.ID, txtUserName.Text, txtPassword.Text
                     , int.Parse(txtPermissions.Text), int.Parse(txtPersonID.Text));

                // Disable the Save button to avoid multiple clicks while waiting for the API response.
                btnSave.Enabled = false;

                // Call the API to update the user.
                _userDTO = await clsUsers.UpdateUser(_userDTO);

                // Check if the user was successfully updated.
                if (_userDTO == null)
                {
                    MessageBox.Show("Failed to update user", "Internal Error"
                             , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = true; // Re-enable the button for retry.
                    return;
                }

                MessageBox.Show("User updated Successfully", "Process Completed "
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                // If the updated user is the currently logged-in user, update global user information.
                clsGlobal.GlobalUserDTO = _userDTO;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error in updating User: " + ex.Message);
            }
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled.
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtPersonID.Text) || string.IsNullOrEmpty(txtPermissions.Text))
            {
                MessageBox.Show("All Fileds Should be filled", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Determine whether to add a new user or update an existing one based on the current mode.
            if (_Mode == enMode.AddNew)
                _AddNewUser();
            else
                _UpdateUser();
        }

        private void txtPersonID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and backspace.
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 8);
        }

        private void txtPermissions_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, backspace, and the hyphen (-) character.
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 45);
        }

        /// <summary>
        /// Fills the form fields with the information of the user to be updated.
        /// </summary>
        /// <param name="userDTO">The user data transfer object representing the user to be updated.</param>
        void _FillInfo(clsUsersDTO userDTO)
        {
            // Populate the fields with the user's existing information.
            txtPassword.Text = userDTO.Password;
            txtPermissions.Text = userDTO.Permissions.ToString();
            txtPersonID.Text = userDTO.PersonID.ToString();
            txtUserName.Text = userDTO.UserName;
            lbID.Text = userDTO.ID.ToString();

            // Update the form title and mode for updating the user.
            lbTitle.Text = "Update User";
            this.Text = "Update User";
            _Mode = enMode.Update;

            // Disable editing the Person ID field for updates.
            txtPersonID.Enabled = false;

        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            // If a user object is provided, fill the form with its information.
            if (_userDTO != null)
                _FillInfo(_userDTO);
        }

        private void txtPersonID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
