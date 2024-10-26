using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_API_Database
{
    /// <summary>
    /// Data Transfer Object (DTO) representing a transfer log entry.
    /// This class stores information related to a specific transfer transaction, including its ID, amount, date, type, and associated client.
    /// </summary>
    public class clsTransferLogDTO
    {
        public int ID { get; set; }
        public decimal Amount {  get; set; }
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


        public clsTransferLogDTO(int id,  decimal amount, DateTime date, byte type, int clientID)
        {
            ID = id;
            Amount = amount;
            Date = date;
            Type = type;
            ClientID = clientID;
        }
    }

    /// <summary>
    /// This class handles the database operations related to transfer logs.
    /// </summary>
    public class clsTransferLogsDatabase
    {
        /// <summary>
        /// Retrieves all transfer logs from the database.
        /// </summary>
        /// <returns>A list of all transfer logs as <see cref="clsTransferLogDTO"/> objects.</returns>
        static public List<clsTransferLogDTO> GetAllTransferLogs()
        {
            List<clsTransferLogDTO> TransferLogsDTOs = new List<clsTransferLogDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllTransferLogs", connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TransferLogsDTOs.Add(new clsTransferLogDTO
                                    (
                                        reader.GetInt32(reader.GetOrdinal("ID")),
                                        reader.GetDecimal(reader.GetOrdinal("Amount")),
                                        reader.GetDateTime(reader.GetOrdinal("Date")),
                                        reader.GetByte(reader.GetOrdinal("Type")),
                                        reader.GetInt32(reader.GetOrdinal("ClientID"))
                                    ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return TransferLogsDTOs;
        }

        /// <summary>
        /// Retrieves all transfer logs for a specific client by their ID.
        /// </summary>
        /// <param name="ClientID">The unique ID of the client.</param>
        /// <returns>A list of transfer logs related to the specified client.</returns>
        static public List<clsTransferLogDTO> GetAllTranferLogsByClientID(int ClientID)
        {
            List<clsTransferLogDTO> TransferLogsDTOs = new List<clsTransferLogDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllTransferLogsByClientID", connection))
                    {
                        command.Parameters.Add("@ClientID", System.Data.SqlDbType.Int).Value = ClientID;

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TransferLogsDTOs.Add(new clsTransferLogDTO
                                    (
                                        reader.GetInt32(reader.GetOrdinal("ID")),
                                        reader.GetDecimal(reader.GetOrdinal("Amount")),
                                        reader.GetDateTime(reader.GetOrdinal("Date")),
                                        reader.GetByte(reader.GetOrdinal("Type")),
                                        reader.GetInt32(reader.GetOrdinal("ClientID"))
                                    ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return TransferLogsDTOs;
        }

        /// <summary>
        /// Adds a new transfer log entry for a deposit or withdrawal transaction.
        /// </summary>
        /// <param name="transferLogDTO">The transfer log data.</param>
        /// <returns>The ID of the newly created transfer log, or -1 in case of an error.</returns>
        static public int AddNewTrasferLog(clsTransferLogDTO transferLogDTO)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddNewTransferLog", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter AmountParameter = command.Parameters.Add("@Amount", System.Data.SqlDbType.Decimal);
                        AmountParameter.Value = transferLogDTO.Amount;
                        AmountParameter.Precision = 12;
                        AmountParameter.Scale = 4;

                        command.Parameters.Add("Date", SqlDbType.DateTime).Value = transferLogDTO.Date;
                        command.Parameters.Add("Type", SqlDbType.TinyInt).Value = transferLogDTO.Type;
                        command.Parameters.Add("ClientID", SqlDbType.Int).Value = transferLogDTO.ClientID;

                        var outputIdParam = new SqlParameter("@NewTransferLogID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputIdParam);

                        connection.Open();
                        command.ExecuteNonQuery();

                        return (int)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
           
        }

        /// <summary>
        /// Adds a new transfer log for a money transfer between two clients.
        /// </summary>
        /// <param name="transferLogDTO">Transfer log data for the sender.</param>
        /// <param name="RecipientID">ID of the recipient.</param>
        /// <returns>Returns the ID of the new transfer log for both(Sender Receiver) or -1 in case of an error.</returns>
        static public  int AddNewMoneyTransferLog(ref clsTransferLogDTO transferLogDTO, int RecipientID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddNewTransferLog_MoneyTransfer", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter AmountParameter = command.Parameters.Add("@Amount", SqlDbType.Decimal);
                        AmountParameter.Value = transferLogDTO.Amount;
                        AmountParameter.Precision = 12;
                        AmountParameter.Scale = 4;

                        command.Parameters.Add("@Date", SqlDbType.DateTime).Value = transferLogDTO.Date;
                        command.Parameters.Add("@Type", SqlDbType.TinyInt).Value = transferLogDTO.Type;
                        command.Parameters.Add("@SenderID", SqlDbType.Int).Value = transferLogDTO.ClientID;  
                        command.Parameters.Add("@ReceivedPersonID", SqlDbType.Int).Value = RecipientID;      

                        var senderLogIdParam = new SqlParameter("@SenderTransferLogID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        var receiverLogIdParam = new SqlParameter("@ReceiverTransferLogID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(senderLogIdParam);
                        command.Parameters.Add(receiverLogIdParam);

                        connection.Open();
                        command.ExecuteNonQuery();

                        // Set the sender's transfer log ID
                        transferLogDTO.ID = (int)senderLogIdParam.Value;

                        return  (int)receiverLogIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                return (-1);
            }
        }

    }
}
