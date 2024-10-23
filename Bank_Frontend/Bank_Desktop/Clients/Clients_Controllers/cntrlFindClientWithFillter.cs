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

namespace Bank_Desktop.Clients.Clients_Controllers
{
    public partial class cntrlFindClientWithFillter : UserControl
    {
        // Define a custom event handler delegate with parameters
        public event Action<clsClientsDTO> OnSearchClicked;
        // Create a protected method to raise the event with a parameter
        protected virtual void ClientSelected(clsClientsDTO clientDTO)
        {
            Action<clsClientsDTO> handler = OnSearchClicked;
            if (handler != null)
            {
                handler(clientDTO); // Raise the event with the parameter
            }
        }
        public cntrlFindClientWithFillter()
        {
            InitializeComponent();
        }

        private void cntrlFindClientWithFillter_Load(object sender, EventArgs e)
        {
            cbFillterBy.Items.Add("ID"); // Add filtering option for ID
            cbFillterBy.SelectedIndex = 0; // Set default selection to "ID"
        }

        private async void pbSearch_Click(object sender, EventArgs e)
        {
            try
            {
                clsClientsDTO clientDTO;

                // Fetch the client by their ID using the search text
                clientDTO = await clsClients.GetClientByID(int.Parse(txtSearch.Text));

                // If the client is not found, clear the client information and show a warning message
                if (clientDTO == null)
                {
                    cntrlClientInfo1.ClearInfo();
                    MessageBox.Show("Client is not found", "Unfound Client", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    cntrlClientInfo1.ChangeInfo(clientDTO);

                OnSearchClicked?.Invoke(clientDTO);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Finding Client: " + ex.Message);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validate input for ID (only digits allowed)
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 8); // Allow backspace (ASCII 8)
        }
    }
}
