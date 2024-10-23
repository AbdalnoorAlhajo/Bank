using Bank_API_Business;
using Bank_API_Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank_API.Controllers
{
    /// <summary>
    /// API controller for managing users in the banking system.
    /// Provides endpoints for creating, retrieving, updating, and deleting users.
    /// </summary>
    [Route("api/BankAPI_Users")]
    [ApiController]
    public class BankAPI_UsersController : ControllerBase
    {
        /// <summary>
        /// Retrieves all users from the system.
        /// </summary>
        /// <returns>A list of all users in the form of <see cref="clsUsersDTO"/> objects.</returns>
        [HttpGet("All", Name = "GetAllUsers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<clsUsersDTO>> GetAllUsers()
        {
            List<clsUsersDTO> users = clsUsers.GetAllUsers();

            if (users.Count == 0)
                return NotFound("No User Found");

            return Ok(users);
        }


        /// <summary>
        /// Retrieves a user by their unique identifier (ID).
        /// </summary>
        /// <param name="id">The ID of the user.</param>
        /// <returns>A <see cref="clsUsersDTO"/> object if found.</returns>
        [HttpGet("GetUserById/{id}", Name = "GetUserById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<clsUsersDTO> GetUserById(int id)
        {
            if (id < 1)
                return BadRequest($"Invalid ID: {id}. ID must be greater than 0.");

            clsUsers FoundUser = clsUsers.Find(id);

            if (FoundUser == null)
                return NotFound("User not found");

            return Ok(FoundUser.UDTO);
        }


        /// <summary>
        /// Retrieves a user by their username.
        /// </summary>
        /// <param name="UserName">The username of the user.</param>
        /// <returns>A <see cref="clsUsersDTO"/> object if found.</returns>
        [HttpGet("GetUserByUserName/{UserName}", Name = "GetUserByUserName")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<clsUsersDTO> GetUserByUserName(string UserName)
        {
            clsUsers FoundUser = clsUsers.Find(UserName);

            if (FoundUser == null)
                return NotFound("User not found");

            return Ok(FoundUser.UDTO);
        }



        /// <summary>
        /// Retrieves a user by their username and password.
        /// </summary>
        /// <param name="UserName">The username of the user.</param>
        /// <param name="Password">The password of the user.</param>
        /// <returns>A <see cref="clsUsersDTO"/> object if found.</returns>
        [HttpGet("GetUserByUserNameAndPassword/{UserName},{Password}", Name = "GetUserByUserNameAndPassword")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<clsUsersDTO> GetUserByUserNameAndPassword(string UserName, string Password)
        {
            clsUsers FoundUser = clsUsers.Find(UserName, Password);

            if (FoundUser == null)
                return NotFound("User not found");

            return Ok(FoundUser.UDTO);
        }



        /// <summary>
        /// Adds a new user to the system.
        /// </summary>
        /// <param name="userDTO">The data transfer object representing the user.</param>
        /// <returns>The created <see cref="clsUsersDTO"/> object if successful.</returns>
        [HttpPost(Name = "AddNewUser")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<clsUsersDTO> AddNewUser(clsUsersDTO userDTO)
        {
            if (string.IsNullOrEmpty(userDTO.UserName) || string.IsNullOrEmpty(userDTO.Password)
               || userDTO.PersonID < 0)
                return BadRequest("Invalid user data");

            if (clsPeople.Find(userDTO.PersonID) == null)
                return BadRequest("Invalid PersonID");

            if (clsUsers.Find(userDTO.UserName) != null)
                return BadRequest("Invalid UserName");

            clsUsers NewUser = new clsUsers(userDTO);

            if (!NewUser.Save())
                return StatusCode(500, "Error in Database");

            userDTO.ID = NewUser.ID;

            return CreatedAtRoute("GetUserById", new { id = NewUser.ID }, userDTO);
        }



        /// <summary>
        /// Updates an existing user in the system.
        /// </summary>
        /// <param name="id">The ID of the user to update.</param>
        /// <param name="user">The updated user data.</param>
        /// <returns>The updated <see cref="clsUsersDTO"/> object if successful.</returns>

        [HttpPut("{id}", Name = "UpdateUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<clsUsersDTO> UpdateUser(int id, clsUsersDTO user)
        {
            if (id < 1)
                return BadRequest($"Invalid ID: {id}. ID must be greater than 0.");

            if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password)
               || user.PersonID < 0)
                return BadRequest("Invalid user data");

            clsUsers UpdatedUser = clsUsers.Find(id);

            if(UpdatedUser == null)
                return NotFound("Given User is not found");

            UpdatedUser.UserName = user.UserName;
            UpdatedUser.Password = user.Password;
            UpdatedUser.Permissions = user.Permissions;
           

            if (!UpdatedUser.Save())
                return StatusCode(500, "Error in Database");

            return Ok(UpdatedUser.UDTO);
        }



        /// <summary>
        /// Deletes a user from the system by their ID.
        /// </summary>
        /// <param name="id">The ID of the user to delete.</param>
        /// <returns>A success message if the user is deleted.</returns>
        [HttpDelete("{id}", Name = "DeleteUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult DeleteUser(int id)
        {
            if (id < 1)
                return BadRequest($"Invalid ID: {id}. ID must be greater than 0.");

            if (clsUsers.DeleteUser(id))
                return Ok("User Deleted Successfuly");
            else
                return NotFound("User not found");
        }

    }
}
