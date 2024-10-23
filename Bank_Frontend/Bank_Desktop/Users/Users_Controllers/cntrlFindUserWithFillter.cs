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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank_Desktop.Users.Users_Controllers
{
    public partial class cntrlFindUserWithFillter : UserControl
    {
        // Define a custom event handler delegate with parameters
        public event Action<clsUsersDTO> OnSearchClicked;
        // Create a protected method to raise the event with a parameter
        protected virtual void UserSelected(clsUsersDTO userDTO)
        {
            Action<clsUsersDTO> handler = OnSearchClicked;
            if (handler != null)
            {
                handler(userDTO); // Raise the event with the parameter
            }
        }

        public cntrlFindUserWithFillter()
        {
            InitializeComponent();
        }

        private void cntrlFindUserWithFillter_Load(object sender, EventArgs e)
        {
            cbFillterBy.Items.Add("ID"); // Add filtering option for ID
            cbFillterBy.Items.Add("UserName"); // Add filtering option for Username
            cbFillterBy.SelectedIndex = 0; // Set default selection to "ID"
        }

        private async void pbSearch_Click(object sender, EventArgs e)
        {
            try
            {
                clsUsersDTO userDTO;

                // Determine the search criteria based on the selected filter
                if (cbFillterBy.Text.Equals("ID"))
                    userDTO = await clsUsers.GetUser(int.Parse(txtSearch.Text));
                else
                    userDTO = await clsUsers.GetUser(txtSearch.Text);

                // Check if the user was unfound
                if (userDTO == null)
                {
                    cntrlUserInfo1.ClearInfo();
                    MessageBox.Show("User is not found", "Unfound User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    cntrlUserInfo1.ChangeInfo(userDTO);

                // Raise the search clicked event with the found userDTO
                OnSearchClicked?.Invoke(userDTO);
            }
            catch(Exception ex)
            {
                Console.WriteLine( "Error in Finding User: "+ ex.Message);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            // Validate input for ID (only digits allowed)
            if (cbFillterBy.Text.Equals("ID"))
                e.Handled = (!char.IsDigit(c) && c != 8); // Allow backspace (ASCII 8)

            // Validate input for Username (letters and digits allowed)
            else if (cbFillterBy.Text.Equals("UserName"))
                e.Handled = (!char.IsDigit(c) && !char.IsLetter(c) && c != 8);
        }

        private void cbFillterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = ""; // Clear the search textbox
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
