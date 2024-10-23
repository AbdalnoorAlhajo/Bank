using Bank_API_Business;
using Bank_API_Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank_API.Controllers
{
    /// <summary>
    /// API Controller for managing Login Activities in the Bank system.
    /// </summary>
    [Route("api/BankAPI_LoginActivities")]
    [ApiController]
    public class BankAPI_LoginActivitiesController : ControllerBase
    {
        /// <summary>
        /// Retrieves all Login Activities.
        /// </summary>
        /// <returns>A list of <see cref="clsLoginActivitiesDTO"/> or a 404 status if none are found.</returns>
        [HttpGet("All", Name = "GetAllLoginActivities")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<clsLoginActivitiesDTO>> GetAllLoginActivities()
        {
            List<clsLoginActivitiesDTO> LoginActivitiesDTOs = clsLoginActivities.GetLoginActivities();

            if (LoginActivitiesDTOs.Count == 0)
                return NotFound("No Login Found");

            return Ok(LoginActivitiesDTOs);

        }


        /// <summary>
        /// Retrieves all Login Activities by a specific UserID.
        /// </summary>
        /// <param name="UserID">The ID of the User whose Login Activity should be retrieved.</param>
        /// <returns>A list of <see cref="clsLoginActivitiesDTO"/> for the given User, or an error response if none are found.</returns>
        [HttpGet("GetLoginActivitiesByUserID/{UserID}", Name = "GetLoginActivitiesByUserID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<clsLoginActivitiesDTO>> GetLoginActivitiesByUserID(int UserID)
        {
            if (UserID < 1)
                return BadRequest($"Invalid UserID: {UserID}. UserID must be greater than 0.");

            List<clsLoginActivitiesDTO> LoginActivitiesDTOs = clsLoginActivities.GetLoginActivitiesByUserID(UserID);

            if (LoginActivitiesDTOs.Count == 0)
                return NotFound("No Login Found");

            return Ok(LoginActivitiesDTOs);
        }


        /// <summary>
        /// Retrieves a Login Activity by a specific LoginActivityID.
        /// </summary>
        /// <param name="LoginActivityID">The ID of the Login Activity.</param>
        /// <returns>A <see cref="clsLoginActivitiesDTO"/>, or an error response if none are found.</returns>
        [HttpGet("GetLoginActivityByID/{LoginActivityID}", Name = "GetLoginActivityByID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<clsLoginActivitiesDTO> GetLoginActivityByID(int LoginActivityID)
        {
            if (LoginActivityID < 1)
                return BadRequest($"Invalid UserID: {LoginActivityID}. UserID must be greater than 0.");

            clsLoginActivitiesDTO LoginActivityDTOs = clsLoginActivities.GetLoginActivityByID(LoginActivityID);

            if (LoginActivityDTOs == null)
                return NotFound("No Login Found");

            return Ok(LoginActivityDTOs);
        }



        /// <summary>
        /// Adds a new Login Activity.
        /// </summary>
        /// <param name="loginActivityDTO">Login Activity data to be added.</param>
        /// <returns>The newly created Login Activity with a 201 status, or an error response if the operation fails.</returns>
        [HttpPost(Name = "AddNewLoginActivity")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<clsLoginActivitiesDTO> AddNewLoginActivity(clsLoginActivitiesDTO loginActivityDTO)
        {
            if (loginActivityDTO.UserID < 1)
                return BadRequest("Invalid LoginActivity Data");

            if (clsUsers.Find(loginActivityDTO.UserID) == null)
                return BadRequest("UserID not exists");

            clsLoginActivities LoginActivity = new clsLoginActivities(loginActivityDTO);

            if (!LoginActivity.Save())
                return StatusCode(500, "Error in Database");

            loginActivityDTO.ID = LoginActivity.ID;

            return CreatedAtRoute("GetLoginActivitiesByID", new { LoginActivityID = loginActivityDTO.ID }, LoginActivity.LDTO);

        }
    }
}
