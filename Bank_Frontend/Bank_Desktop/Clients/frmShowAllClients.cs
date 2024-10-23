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
    public partial class frmShowAllClients : Form
    {
        public frmShowAllClients()
        {
            InitializeComponent();
        }

        private async void frmShowAllClients_Load(object sender, EventArgs e)
        {
            try
            {
                // Asynchronously fetch the list of all clients from the API
                List<clsClientsDTO> clientDTO = await clsClients.GetAllClients();

                // Create a DataTable to hold the data for displaying clients information
                DataTable dtClients = new DataTable();
                dtClients.Columns.Add("ID", typeof(int));
                dtClients.Columns.Add("Savings", typeof(decimal));
                dtClients.Columns.Add("PersonID", typeof(int));

                // Populate the DataTable with the list of clients received from the API
                foreach (var client in clientDTO)
                {
                    dtClients.Rows.Add(client.ID, client.Savings, client.PersonID);
                }

                // Bind the populated DataTable to the DataGridView for displays
                dgvClients.DataSource = dtClients;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in fetching Clients: " + ex.Message);
            }
        }
    }
}
