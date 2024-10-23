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
using System.Xml.Linq;

namespace Bank_Desktop.Clients
{
    public partial class frmAddUpdateClient : Form
    {
        // Delegate definition for passing back data when a client is added or updated.
        public delegate void DataBackEventHandler(object sender, clsClientsDTO clientDTO);

        // Event triggered when a client is added or updated, passing back the data.
        public event DataBackEventHandler DataBack;

        /// <summary>
        /// Holds the information about the client being added or updated.
        /// </summary>
        clsClientsDTO _clientDTO;

        /// <summary>
        /// Enum to define the form's mode (AddNew or Update).
        /// </summary>
        public enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        // Constructor used for adding a new client.
        public frmAddUpdateClient()
        {
            InitializeComponent();

        }

        // Constructor used for updating an existing client.
        public frmAddUpdateClient(clsClientsDTO clientDTO)
        {
            InitializeComponent();
            _clientDTO = clientDTO;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Fills the form with the client's details for updating.
        /// </summary>
        void _FillInfo(clsClientsDTO clientDTO)
        {
            // Populate the form fields with the client's data.
            lbID.Text = clientDTO.ID.ToString();
            txtPassword.Text = clientDTO.Password;
            txtPersonID.Text = clientDTO.PersonID.ToString();
            txtSavings.Text = clientDTO.Savings.ToString();

            // Can not change these properties due to them senetivity (PersonID, Savings)
            txtSavings.Enabled = false;
            txtPersonID.Enabled = false;

            // Update the form title and mode for updating the client.
            lbTitle.Text = "Update Client";
            _Mode = enMode.Update;
        }

        private void frmAddUpdateClient_Load(object sender, EventArgs e)
        {
            // If _clientDTO is not null, fill the form with the client's information.
            if (_clientDTO != null)
                _FillInfo(_clientDTO);
        }

        private void txtPersonID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and backspace.
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 8);
        }

        private void txtSavings_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, dot(.) and backspace.
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46);
        }

        /// <summary>
        /// Asynchronously adds a new client to the system by calling the API.
        /// </summary>
        async void _AddNewClient()
        {
            try
            {
                // Disaple Save button for waiting resopnse from API
                btnSave.Enabled = false;
                _clientDTO = await clsClients.AddNewClient(_clientDTO);
                if (_clientDTO == null)
                {
                    MessageBox.Show("Failed to add Client", "Internal Error Or Unfound Person"
                             , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = true;
                    return;
                }

                MessageBox.Show("Client added Successfully", "Process Completed "
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                lbID.Text = _clientDTO.ID.ToString();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error in Adding Client: " + ex.Message);
            }
        }

        /// <summary>
        /// Asynchronously updates the existing client data in the system by calling the API.
        /// </summary>
        async void _UpdateClient()
        {
            try
            {
                // Set the ID from the label to ensure the client is updated correctly.
                _clientDTO.ID = int.Parse(lbID.Text);

                // Disaple Save button for waiting resopnse from API
                btnSave.Enabled = false;
                _clientDTO = await clsClients.UpdateClient(_clientDTO);
                if (_clientDTO == null)
                {
                    MessageBox.Show("Failed to update Client", "Internal Error"
                             , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = true;
                    return;
                }

                MessageBox.Show("Client updated Successfully", "Process Completed "
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error in updating Client: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if required fields are empty.
            if (string.IsNullOrEmpty(txtPersonID.Text) || string.IsNullOrEmpty(txtPassword.Text) ||
                  string.IsNullOrEmpty(txtSavings.Text) || string.IsNullOrEmpty(lbID.Text))
            {
                MessageBox.Show("All Fileds Should be filled", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new clsClientsDTO object with the entered data.
            _clientDTO = new clsClientsDTO(-1, Convert.ToDecimal(txtSavings.Text), txtPassword.Text, Convert.ToInt32(txtPersonID.Text));

            // Add or update the client based on the mode.
            if (_Mode == enMode.AddNew)
                _AddNewClient();
            else
                _UpdateClient();

            // Raise the DataBack event to pass the client data back to the calling form.
            DataBack?.Invoke(this, _clientDTO);
        }
    }
}
