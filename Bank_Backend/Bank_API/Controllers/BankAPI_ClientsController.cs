using Bank_API_Business;
using Bank_API_Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank_API.Controllers
{
    /// <summary>
    /// API Controller for managing Clients in the Bank system.
    /// </summary>
    [Route("api/BankAPI_Clients")]
    [ApiController]
    public class BankAPI_ClientsController : ControllerBase
    {
        /// <summary>
        /// Retrieves all Clients.
        /// </summary>
        /// <returns>A list of <see cref="clsClientsDTO"/> or a 404 status if none are found.</returns>
        [HttpGet("All", Name = "GetAllClients")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<clsClientsDTO>> GetAllClients()
        {
            List<clsClientsDTO> clients = clsClients.GetAllClients();

            if(clients.Count == 0)
                return NotFound("No Client Found");

            return Ok(clients);
        }


        /// <summary>
        /// Retrieves a client by their unique identifier (ID).
        /// </summary>
        /// <param name="id">The ID of the client.</param>
        /// <returns>A <see cref="clsClientsDTO"/> object if found.</returns>
        [HttpGet("{id}", Name = "GetClientById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<clsClientsDTO> GetClientById(int id)
        {
            if (id < 1)
                return BadRequest($"Invalid ID: {id}. ID must be greater than 0.");

            clsClients FoundClient = clsClients.Find(id);

            if (FoundClient == null)
                return NotFound("Clinet Not found");

            return Ok(FoundClient.CDTO);
        }


        /// <summary>
        /// Adds a new client to the system.
        /// </summary>
        /// <param name="clientDTO">The data transfer object representing the client.</param>
        /// <returns>The created <see cref="clsClientsDTO"/> object if successful.</returns>
        [HttpPost(Name = "AddNewClient")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<clsClientsDTO> AddNewClient(clsClientsDTO clientDTO)
        {
            if (string.IsNullOrEmpty(clientDTO.Password) || clientDTO.PersonID < 1 || clientDTO.Savings < 0)
                return BadRequest("Invalid Client Data");

            if (clsPeople.Find(clientDTO.PersonID) == null)
                return BadRequest("Invalid PersonID");

            clsClients client = new clsClients(clientDTO);

            if (!client.Save())
                return StatusCode(500, "Error in Database");

            clientDTO.ID = client.ID;

            return CreatedAtRoute("GetClientById", new { id = client.ID }, clientDTO);
        }



        /// <summary>
        /// Updates an existing client in the system.
        /// </summary>
        /// <param name="id">The ID of the client to update.</param>
        /// <param name="clientDTO">The updated client data.</param>
        /// <returns>The updated <see cref="clsClientsDTO"/> object if successful.</returns>
        [HttpPut("{id}", Name = "UpdateClient")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<clsClientsDTO> UpdateClient(int id, clsClientsDTO clientDTO)
        {
            if (id < 1)
                return BadRequest($"Invalid ID: {id}. ID must be greater than 0.");

            clsClients UpdatedClient = clsClients.Find(id);

            if (UpdatedClient == null)
                return NotFound("Clinet Not found");

            UpdatedClient.Password = clientDTO.Password;

            if (!UpdatedClient.Save())
                return StatusCode(500, "Error in Database");

            return Ok(UpdatedClient.CDTO);
        }



        /// <summary>
        /// Deletes a client from the system by their ID.
        /// </summary>
        /// <param name="id">The ID of the client to delete.</param>
        /// <returns>A success message if the client is deleted.</returns>
        [HttpDelete("{id}", Name = "DeleteClient")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult DeleteClient(int id)
        {
            if (id < 1)
                return BadRequest($"Invalid ID: {id}. ID must be greater than 0.");

            if (clsClients.DeleteClient(id))
                return Ok("Client Deleted Successfully");
            else
                return NotFound("No Client Found");
        }
    }
}
