using Bank_API_Business;
using Bank_API_Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank_API.Controllers
{
    /// <summary>
    /// API Controller for managing transfer logs in the Bank system.
    /// </summary>
    [Route("api/BankAPI_TransferLogs")]
    [ApiController]
    public class BankAPI_TransferLogsController : ControllerBase
    {
        /// <summary>
        /// Retrieves all transfer logs.
        /// </summary>
        /// <returns>A list of all transfer logs or a 404 status if none are found.</returns>
        [HttpGet("All", Name = "GetAllTransferLogs")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<clsTransferLogDTO>> GetAllTransferLogs()
        {
            List<clsTransferLogDTO> TransferLogsDTOs = clsTransferLogs.GetAllTransferLogs();

            if (TransferLogsDTOs.Count == 0)
                return NotFound("No Login Found");

            return Ok(TransferLogsDTOs);

        }


        /// <summary>
        /// Retrieves all transfer logs by a specific ClientID.
        /// </summary>
        /// <param name="ClientID">The ID of the client whose transfer logs should be retrieved.</param>
        /// <returns>A list of transfer logs for the given client, or an error response if none are found.</returns>
        [HttpGet("{ClientID}", Name = "GetTransferLogsByClientID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<clsTransferLogDTO>> GetTransferLogsByClientID(int ClientID)
        {
            if (ClientID < 1)
                return BadRequest($"Invalid ClientID: {ClientID}. ClientID must be greater than 0.");

            List<clsTransferLogDTO> TransferLogsDTOs = clsTransferLogs.GetAllTransferLogsByClientID(ClientID);

            if (TransferLogsDTOs.Count == 0)
                return NotFound("No Login Found");

            return Ok(TransferLogsDTOs);
        }



        /// <summary>
        /// Adds a new transfer log.
        /// </summary>
        /// <param name="TransferLogDTO">Transfer log data to be added.</param>
        /// <returns>The newly created transfer log with a 201 status, or an error response if the operation fails.</returns>
        [HttpPost(Name = "AddNewTransferLog")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<clsTransferLogDTO> AddNewTransferLog(clsTransferLogDTO TransferLogDTO)
        {
            if (TransferLogDTO.ClientID < 1 || TransferLogDTO.Type < 0 || TransferLogDTO.Type > 3)
                return BadRequest("Invalid TransferLog Data");

            if (clsClients.Find(TransferLogDTO.ClientID) == null)
                return BadRequest("ClientID not exists");

            clsTransferLogs TransferLog = new clsTransferLogs(TransferLogDTO);

            if (!TransferLog.Save())
                return StatusCode(500, "Error in Database");

            TransferLogDTO.ID = TransferLog.ID;

            return CreatedAtRoute("GetTransferLogsByClientID", new { ClientID = TransferLogDTO.ClientID }, TransferLogDTO);

        }


        /// <summary>
        /// Adds new money transfer logs.
        /// </summary>
        /// <param name="TransferLogDTO">Transfer log data for the sender.</param>
        /// <param name="RecipientID">The ID of the recipient of the money transfer.</param>
        /// <returns>Logs for both the sender and recipient, or an error response if the operation fails.</returns>
        [HttpPost("MoneyTransfer/{RecipientID}", Name = "AddNewMoneyTransferLog")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<clsTransferLogDTO>> AddNewMoneyTransferLog(clsTransferLogDTO TransferLogDTO , int RecipientID)
        {
            if (TransferLogDTO.ClientID < 1 || TransferLogDTO.Type < 0 || TransferLogDTO.Type > 3 || RecipientID < 1)
                return BadRequest("Invalid TransferLog Data");

            if (clsClients.Find(TransferLogDTO.ClientID) == null)
                return BadRequest("SenderID not exists");

            if (clsClients.Find(RecipientID) == null)
                return BadRequest("RecipientID not exists");

            // Ensuring that the type is set to 3 (Money Transfer)
            TransferLogDTO.Type = 3; 

            int RecipientTransferLogID = clsTransferLogs.AddNewMoneyTransferLog(ref TransferLogDTO, RecipientID);

            if (RecipientTransferLogID == -1)
                return StatusCode(500, "Error in Database");

            // Creating a list of transfer logs for both sender and recipient

            List<clsTransferLogDTO> transferLogDTOs = new List<clsTransferLogDTO>
            {
                 // Sender's transfer log
                 TransferLogDTO,

                 // Recipient's transfer log
                    new clsTransferLogDTO(RecipientTransferLogID, TransferLogDTO.Amount
                             , TransferLogDTO.Date, TransferLogDTO.Type, RecipientID)
            };


            return Ok( transferLogDTOs);

        }
    }
}
