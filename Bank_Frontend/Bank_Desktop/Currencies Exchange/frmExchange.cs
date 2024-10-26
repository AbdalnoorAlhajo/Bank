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
    public partial class frmExchange : Form
    {
        public frmExchange()
        {
            InitializeComponent();
        }

        private async void frmExchange_Load(object sender, EventArgs e)
        {
            // Fetch all available currency exchange rates asynchronously
            clsCurrencyDTO CurrencyExchange = await clsRates.Import();

            // If no data is retrieved, exit the method without any further processing
            if (CurrencyExchange == null)
                return;

            // Populate both combo boxes with the available currency codes from the fetched rates
            foreach (var rate in CurrencyExchange.conversion_rates)
            {
                cbBaseCode.Items.Add(rate.Key); // Add to Base currency combo box
                cbTargetCode.Items.Add(rate.Key); // Add to Target currency combo box
            }

            // Set default selected indices for both combo boxes
            cbBaseCode.SelectedIndex = 0;
            cbTargetCode.SelectedIndex = 0;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Restrict input in the amount textbox to only digits, backspace, and decimal points
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46); // 8 = backspace, 46 = decimal point
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            // Check if the amount textbox is empty and display an error if it is
            if (string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Amount should be filed", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Fetch the conversion rate between the selected base and target currencies
            clsPairConversionDTO pairConversion = await clsRates.Import(cbBaseCode.Text, cbTargetCode.Text);

            // If no conversion data is retrieved, exit the method
            if (pairConversion == null) return;

            // Try parsing the entered amount, and if successful, calculate and display the result
            if (double.TryParse(txtAmount.Text, out double amount))
            {
                lbResult.Text = (pairConversion.conversion_rate * amount).ToString();
            }
        }
    }
}
