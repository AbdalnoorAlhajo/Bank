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

namespace Bank_Desktop.Clients
{
    public partial class frmDeleteClient : Form
    {
        clsClientsDTO _clientDTO;
        public frmDeleteClient()
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
                // If _clientDTO is null, exit the method as there is no client to delete.
                if (_clientDTO == null)
                    return;

                // Disable the delete button to prevent multiple clicks.
                btnDelete.Enabled = false;
                bool isClientDeleted = await clsClients.DeleteClient(_clientDTO.ID);

                // Check if the client was deleted successfully.
                if (isClientDeleted)
                    MessageBox.Show("Client Deleted Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Failed to Delete Client", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnDelete.Enabled = true; // Re-enable the delete button for another attempt.
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Deleting Client: " + ex.Message);
            }
        }

        private void cntrlFindClientWithFillter1_OnSearchClicked(clsClientsDTO obj)
        {
            // If no client is found, disable the delete button.
            if (obj == null)
                btnDelete.Enabled = false;
            else
            {
                // If a client is found, enable the delete button and store the client data in _clientDTO.
                btnDelete.Enabled = true;
                _clientDTO = obj;
            }
        }
    }
}
