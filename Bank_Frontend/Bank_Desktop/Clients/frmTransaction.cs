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
    public partial class frmTransaction : Form
    {
        byte TransferType;

        public frmTransaction(byte Type)
        {
            InitializeComponent();
            TransferType = Type;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            string stTransferType = "";
            switch (TransferType)
            {
                // 1 represets Deposit
                case 1:
                    stTransferType = "Deposit";
                    break;

                // 2 represets Withdrawal
                case 2:
                    stTransferType = "Withdrawal";
                    break;

                // 3 represets Money Transfer
                case 3:
                    stTransferType = "Money Transfer";
                    txtRecipientID.Visible = true;
                    lbRecipientID.Visible = true;
                    break;

            }

            lbTitle.Text = stTransferType;
            gbTransactionInfo.Text = stTransferType + " Info";
            this.Text = stTransferType;

            // It would be More Clear to Convert SenderID to ClientID in case Trasfer Operation is Deposit(1) or Withdrawal(2)
            if (TransferType != 3)
                lbSenderID.Text = "ClientID";

            lbType.Text = stTransferType;
        }

        async Task< bool> _TransferMoney(clsTransferLogDTO transferLogDTO)
        {
            try
            {
                List<clsTransferLogDTO> transferLogDTOs = await clsTransferLogs.AddNewMoneyTransferLog(transferLogDTO
                        , int.Parse(txtRecipientID.Text));

                if (transferLogDTOs == null)
                    return false;

                lbID.Text = transferLogDTOs[1].ID.ToString();
                lbID.Text += ", " +  transferLogDTOs[0].ID.ToString();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmount.Text) || string.IsNullOrEmpty(txtSenderID.Text))
            {
                MessageBox.Show("All Fileds Should be filled", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // if the Transaction operation is Money Transfer (3) RecipientID should also be filed
            if (TransferType == 3)
            {
                if (string.IsNullOrEmpty(txtRecipientID.Text))
                {
                    MessageBox.Show("RecipientID Filed Should be filled", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(int.Parse(txtRecipientID.Text) == int.Parse(txtSenderID.Text))
                {
                    MessageBox.Show("RecipientID is same as SenderID", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                // Disaple Save button for waiting resopnse from API
                btnSave.Enabled = false;
                clsTransferLogDTO transferLogDTO = new clsTransferLogDTO(-1, decimal.Parse(txtAmount.Text), TransferType
                    , int.Parse(txtSenderID.Text));

                // Amount should be converted to negive if Transaction operation is Withdrawal
                if (TransferType == 2)
                    transferLogDTO.Amount *= -1;
                
                bool DidTrasferLogAddedSuccessfully = false;

                if (TransferType == 3)
                {
                    DidTrasferLogAddedSuccessfully = await _TransferMoney(transferLogDTO);
                }
                else
                {
                    transferLogDTO = await clsTransferLogs.AddNewTrasferLog(transferLogDTO);
                    if(transferLogDTO != null)
                    {
                        DidTrasferLogAddedSuccessfully = true;
                        lbID.Text = transferLogDTO.ID.ToString();
                    }
                }

                if (!DidTrasferLogAddedSuccessfully)
                {
                    MessageBox.Show("Failed to add transfer Log", "Internal Error"
                             , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = true;
                    return;
                }

                MessageBox.Show("Transfer Log added Successfully", "Process Completed "
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error in Adding Trasfer Log: " + ex.Message);
            }

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46);
        }
    }
}
