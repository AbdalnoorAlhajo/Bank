using Bank_Desktop.Users;
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
    public partial class cntrlClientInfo : UserControl
    {
        clsClientsDTO _clientDTO;
        public cntrlClientInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates the client information displayed in the control with the provided client data.
        /// </summary>
        /// <param name="clientDTO">The client data transfer object containing client information.</param>
        public void ChangeInfo(clsClientsDTO clientDTO)
        {
            // If the provided clientDTO is null, exit the method
            if (clientDTO == null)
                return;

            // Update the labels with client information
            lbID.Text = clientDTO.ID.ToString();
            lbSavings.Text = clientDTO.Savings.ToString();
            lbPersonID.Text = clientDTO.PersonID.ToString();

            // Enable the update link if client information is valid
            linklbUpdateClient.Enabled = true;

            // Store the client data transfer object for future reference
            _clientDTO = clientDTO;
        }

        /// <summary>
        /// Clears the client information displayed in the control.
        /// This resets the labels to their default state.
        /// </summary>
        public void ClearInfo()
        {
            // Reset labels to default values
            lbID.Text = "{???}";
            lbPersonID.Text = "{???}";
            lbSavings.Text = "{???}";

            // Disable the update link as there is no client information to update
            linklbUpdateClient.Enabled = false;
            _clientDTO = null;
        }

        private void linklbUpdateClient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Show the update form with the current client information
            frmAddUpdateClient frm = new frmAddUpdateClient(_clientDTO);
            frm.ShowDialog();

            // Refresh the client information displayed in the control after updating
            ChangeInfo(_clientDTO);
        }
    }
}
