using Bank_API_Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_API_Business
{
    /// <summary>
    /// Represents the transfer log in the banking system, including information about transactions and operations for managing transfer logs.
    /// </summary>
    public class clsTransferLogs
    {
        public enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode;
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Represents the type of transfer associated with the transaction.
        /// This property indicates the specific nature of the transaction, which can be one of the following:
        /// <list type="bullet">
        /// <item><description><c>1</c>: Deposit - A transaction where funds are added to the account.</description></item>
        /// <item><description><c>2</c>: Withdrawal - A transaction where funds are taken out of the account.</description></item>
        /// <item><description><c>3</c>: Transfer - A transaction involving the movement of funds from this account to another account.</description></item>
        /// </list>
        /// </summary>
        /// <value>A byte value that specifies the type of transfer.</value>
        public byte Type { get; set; }
        public int ClientID { get; set; }

        /// <summary>
        /// Gets the Data Transfer Object (DTO) for the current transfer log, containing transfer data.
        /// </summary>
        public clsTransferLogDTO TDTO { get { return new clsTransferLogDTO(ID, Amount, Date, Type, ClientID); } }

        public clsTransferLogs(clsTransferLogDTO transferLogDTO)
        {
            Amount = transferLogDTO.Amount;
            Date = transferLogDTO.Date;
            Type = transferLogDTO.Type;
            ClientID = transferLogDTO.ClientID;

            _Mode = enMode.AddNew;
        }

        /// <summary>
        /// Retrieves all transfer logs from the database.
        /// </summary>
        /// <returns>A list of <see cref="clsTransferLogDTO"/> representing all transfer logs.</returns>
        static public List<clsTransferLogDTO> GetAllTransferLogs()
        {
            return clsTransferLogsDatabase.GetAllTransferLogs();
        }

        /// <summary>
        /// Retrieves all transfer logs by a specific client ID from the database.
        /// </summary>
        /// <param name="ClientID">The unique identifier for the client.</param>
        /// <returns>A list of <see cref="clsTransferLogDTO"/> representing all transfer logs for the specified client.</returns>
        static public List<clsTransferLogDTO> GetAllTransferLogsByClientID(int ClientID)
        {
            return clsTransferLogsDatabase.GetAllTranferLogsByClientID(ClientID);
        }

        /// <summary>
        /// Adds a new login activity transfer log to the database.
        /// </summary>
        /// <returns>True if the log is added successfully, otherwise false.</returns>
        bool _AddNewLoginActivity()
        {
            ID = clsTransferLogsDatabase.AddNewTrasferLog(TDTO);

            return (ID > 0);
        }

        /// <summary>
        /// Adds new money transfer logs to the database.
        /// </summary>
        /// <param name="transferLogDTO">The transfer log DTO representing the transfer data.</param>
        /// <param name="RecipientID">The unique identifier for the recipient of the transfer.</param>
        /// <returns>The unique identifier of the new transfer log for Recipient.</returns>
        static public  int AddNewMoneyTransferLog(ref clsTransferLogDTO transferLogDTO, int RecipientID)
        {
            return  clsTransferLogsDatabase.AddNewMoneyTransferLog(ref transferLogDTO, RecipientID);
        }

        /// <summary>
        /// Saves the transfer log to the database. Determines whether to add or update based on the current mode.
        /// </summary>
        /// <returns>True if the operation is successful, otherwise false.</returns>
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLoginActivity())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return false; // Update mode is not yet implemented, reserved for future use.
                default:
                    return false;
            }
        }
    }
}
