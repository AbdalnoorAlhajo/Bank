using Bank_Desktop.Users.Users_Controllers;
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

namespace Bank_Desktop.People.People_Controllers
{
    public partial class cntrlFindPersonWithFillter : UserControl
    {
        // Event that will be triggered when a person is found during a search
        // The event handler expects a clsPeopleDTO parameter to represent the selected person
        public event Action<clsPeopleDTO> OnSearchClicked;

        // Method to trigger the OnSearchClicked event with the selected person's information
        protected virtual void PersonSelected(clsPeopleDTO PersonDTO)
        { 
            // If there are any subscribers to the event, invoke it with the selected person
            Action<clsPeopleDTO> handler = OnSearchClicked;
            if (handler != null)
            {
                handler(PersonDTO); // Raise the event with the parameter
            }
        }

        public cntrlFindPersonWithFillter()
        {
            InitializeComponent();
        }

        private async void pbSearch_Click(object sender, EventArgs e)
        {
            try
            {
                clsPeopleDTO PersonDTO;

                // Fetch the person by their ID using the search text
                PersonDTO = await clsPeople.GetPersonByID(int.Parse(txtSearch.Text));

                // If the person is not found, clear the person information and show a warning message
                if (PersonDTO == null)
                {
                    cntrlPersonInfo1.ClearInfo();
                    MessageBox.Show("Person is not found", "Unfound Person", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // If the person is found, update the displayed information
                    cntrlPersonInfo1.ChangeInfo(PersonDTO);
                }

                OnSearchClicked?.Invoke(PersonDTO);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Finding Person: " + ex.Message);
            }
        }

        private void cbSearchFillter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = ""; // Clear the search textbox
        }

        private void cntrlFindPersonWithFillter_Load(object sender, EventArgs e)
        {
            cbSearchFillter.Items.Add("ID"); // Add filtering option for ID
            cbSearchFillter.SelectedIndex = 0; // Set default selection to "ID"
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validate input for ID (only digits allowed)
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 8); // Allow backspace (ASCII 8)
        }
    }
}
