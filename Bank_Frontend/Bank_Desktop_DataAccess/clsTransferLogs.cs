using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;


namespace Bank_Desktop_DataAccess
{
    /// <summary>
    /// Data Transfer Object (DTO) representing a transfer log entry in the banking system.
    /// </summary>
    public class clsTransferLogDTO
    {
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
        /// Initializes a new instance of the <see cref="clsTransferLogDTO"/> class.
        /// </summary>
        /// <param name="id">The unique identifier for the transfer log.</param>
        /// <param name="amount">The amount of money transferred.</param>
        /// <param name="type">The type of transfer.</param>
        /// <param name="clientID">The associated client ID.</param>
        public clsTransferLogDTO(int id, decimal amount, byte type, int clientID)
        {
            ID = id;
            Amount = amount;
            Date = DateTime.Now;
            Type = type;
            ClientID = clientID;
        }
    }


    /// <summary>
    /// Class responsible for handling transfer log-related operations via API calls.
    /// </summary>
    public class clsTransferLogs
    {
        // Static instance of HttpClient to communicate with the API.
        static readonly HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// Static constructor to initialize the base address of the HttpClient.
        /// </summary>
        static clsTransferLogs()
        {
            // Base address of the API endpoint for TransferLogs-related operations.
            _httpClient.BaseAddress = new Uri("https://localhost:7207/api/BankAPI_TransferLogs/");
        }

        /// <summary>
        /// Retrieves all transfer logs from the API.
        /// </summary>
        /// <returns>A list of <see cref="clsTransferLogDTO"/> representing all transfer logs or null if an error occurs.</returns>
        static public async Task<List<clsTransferLogDTO>> GetAllTransferLogs()
        {
            try
            {
                var response = await _httpClient.GetAsync($"All");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<List<clsTransferLogDTO>>();

                    return content;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetAllTransferLogs(): " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Retrieves all transfer logs associated with a specific client ID from the API.
        /// </summary>
        /// <param name="ClientID">The unique identifier of the client.</param>
        /// <returns>A list of <see cref="clsTransferLogDTO"/> representing the client's transfer logs or null if an error occurs.</returns>
        static public async Task<List<clsTransferLogDTO>> GetAllTranferLogsByClientID(int ClientID)

        {
            try
            {
                var response = await _httpClient.GetAsync($"{ClientID}");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<List<clsTransferLogDTO>>();

                    return content;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetAllTranferLogsByClientID(int ClientID): " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Adds a new transfer log entry to the system via the API.
        /// </summary>
        /// <param name="transferLogDTO">The transfer log data to be added.</param>
        /// <returns>The newly created <see cref="clsTransferLogDTO"/> or null if an error occurs.</returns>
        static public async Task<clsTransferLogDTO> AddNewTrasferLog(clsTransferLogDTO transferLogDTO)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("", transferLogDTO);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<clsTransferLogDTO>();

                    return content;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in AddNewTrasferLog(clsTransferLogDTO transferLogDTO): " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Adds new money transfer logs for both the sender and the recipient.
        /// </summary>
        /// <param name="transferLogDTO">The transfer log data to be added for the sender. This information will also be used for the recipient.</param>
        /// <param name="RecipientID">The ID of the recipient of the funds.</param>
        /// <returns>A list of <see cref="clsTransferLogDTO"/> representing the added transfer logs for both the sender and recipient, or null if an error occurs.</returns>
        static public async Task<List<clsTransferLogDTO>> AddNewMoneyTransferLog(clsTransferLogDTO transferLogDTO, int RecipientID)

        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync($"MoneyTransfer/{RecipientID}", transferLogDTO);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<List<clsTransferLogDTO>>();

                    return content;

                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in AddNewMoneyTransferLog(transferLogDTO, RecipientID): " + ex.Message);
                return null;
            }
        }
    }

}
