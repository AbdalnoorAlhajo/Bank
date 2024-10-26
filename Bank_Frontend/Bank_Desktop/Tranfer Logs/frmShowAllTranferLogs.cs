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

namespace Bank_Desktop.TranferLogs
{
    public partial class frmShowAllTranferLogs : Form
    {
        // DataTable to hold transfer log data to be displayed in the DataGridView
        DataTable dtTransferLogs;
        public frmShowAllTranferLogs()
        {
            InitializeComponent();
        }

        private async void frmShowAllTranferLogs_Load(object sender, EventArgs e)
        {
            try
            {
                // Asynchronously fetch all transfer logs using the API
                List<clsTransferLogDTO> TransferLogsDTOs = await clsTransferLogs.GetAllTransferLogs();

                // Create a new DataTable to store the transfer log data
                dtTransferLogs = new DataTable();
                dtTransferLogs.Columns.Add("Transfer Log ID", typeof(int));
                dtTransferLogs.Columns.Add("Amount", typeof(decimal));
                dtTransferLogs.Columns.Add("Date", typeof(DateTime));
                dtTransferLogs.Columns.Add("Type", typeof(Byte));
                dtTransferLogs.Columns.Add("ClientID", typeof(int));

                // Populate the DataTable with the data fetched from the API
                foreach (var TransferLog in TransferLogsDTOs)
                {
                    dtTransferLogs.Rows.Add(TransferLog.ID, TransferLog.Amount, TransferLog.Date, TransferLog.Type, TransferLog.ClientID);
                }

                // Bind the populated DataTable to the DataGridView for display
                dgvTransferLogs.DataSource = dtTransferLogs;

                // Set the default filter selection.
                cbFillterBy.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in fetching TransferLogs: " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Create a DataView to apply filtering to the DataTable
            DataView dataView = new DataView(dtTransferLogs);

            // If the search text is a valid number, filter the DataTable based on the selected column and search value.
            if (int.TryParse(txtSearch.Text, out int Num))
                dataView.RowFilter = cbFillterBy.Text + "  = " + Num;

            // Update the DataGridView to show the filtered results.
            dgvTransferLogs.DataSource = dataView;
        }
    }
}
