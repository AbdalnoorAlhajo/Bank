using Bank_Desktop_DataAccess;
using ExchangeRate_Online_API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Desktop.CurrenciesExchange
{
    public partial class frmManageCurrenciesRates : Form
    {
        public frmManageCurrenciesRates()
        {
            InitializeComponent();
        }

        private async void frmManageCurrenciesExchange_Load(object sender, EventArgs e)
        {
            // Fetch the latest currency exchange rates from an external API.
            clsCurrencyDTO CurrencyExchange = await clsRates.Import();

            // If no data is retrieved (CurrencyExchange is null), display an error message to the user 
            // indicating that the currency exchange rates could not be fetched due to an external error, 
            // then exit the method to prevent further processing.
            if (CurrencyExchange == null)
            {
                MessageBox.Show("Failed to fetch Currency exchange rates", "External Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a DataTable to hold the currency exchange data.
            DataTable dtCurrencies = new DataTable();
            dtCurrencies.Columns.Add("ID", typeof(int));
            dtCurrencies.Columns.Add("Currency Code", typeof(string));
            dtCurrencies.Columns.Add("Rate", typeof(double));

            int i = 0;

            // Populate the DataTable with the fetched exchange rate data.
            foreach (var rate in CurrencyExchange.conversion_rates)
            {
                dtCurrencies.Rows.Add(++i, rate.Key, rate.Value);
            }

            // Bind the DataTable to the DataGridView to display the currency exchange rates.
            dgvCurrenciesExchange.DataSource = dtCurrencies;
        }

        private void lbCurrenciesExchange_Click(object sender, EventArgs e)
        {

        }
    }
}
