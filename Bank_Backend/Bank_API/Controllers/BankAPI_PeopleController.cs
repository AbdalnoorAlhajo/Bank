using Bank_API_Business;
using Bank_API_Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Bank_API.Controllers
{
    /// <summary>
    /// API controller for managing people in the banking system.
    /// Provides endpoints for creating, retrieving, updating, and deleting people.
    /// </summary>
    [Route("api/BankAPI_People")]
    [ApiController]
    public class BankAPI_PeopleController : ControllerBase
    {
        /// <summary>
        /// Retrieves all People from the system.
        /// </summary>
        /// <returns>A list of all people in the form of <see cref="clsPeopleDTO"/> objects.</returns>
        [HttpGet("All", Name = "GetAllPeople")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<clsPeopleDTO>> GetAllPeople()
        {
            List<clsPeopleDTO> PeopleList = clsPeople.GetAllPeople();

            if (PeopleList.Count == 0)
                return NotFound("No person found");

            return Ok(PeopleList);
        }



        /// <summary>
        /// Retrieves a person by their unique identifier (ID).
        /// </summary>
        /// <param name="id">The ID of the person.</param>
        /// <returns>A <see cref="clsPeopleDTO"/> object if found.</returns>
        [HttpGet("{id}", Name = "GetPersonByID")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<clsPeopleDTO> GetPersonByID(int id)
        {
            if (id < 1)
                return BadRequest($"Invalid ID: {id}. ID must be greater than 0.");

            clsPeople FoundPerson = clsPeople.Find(id);

            if (FoundPerson == null)
                return NotFound("No Person Found");

            return Ok(FoundPerson.PDTO);
        }



        /// <summary>
        /// Adds a new person to the system.
        /// </summary>
        /// <param name="NewPersonDTO">The data transfer object representing the person.</param>
        /// <returns>The created <see cref="clsPeopleDTO"/> object if successful.</returns>
        [HttpPost(Name = "AddNewPerson")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<clsPeopleDTO> AddNewPerson(clsPeopleDTO NewPersonDTO)
        {
            if (string.IsNullOrEmpty(NewPersonDTO.Name) || string.IsNullOrEmpty(NewPersonDTO.Surname) || string.IsNullOrEmpty(NewPersonDTO.Address)
                || string.IsNullOrEmpty(NewPersonDTO.Phone) || string.IsNullOrEmpty(NewPersonDTO.Email))
                return BadRequest("Invalid Person Data");

            string Gender = NewPersonDTO.Gender;
            Gender = char.ToUpper(Gender[0]) + Gender.Substring(1).ToLower();
            if (string.IsNullOrEmpty(Gender) || (Gender != "Male" && Gender != "Female"))
                return BadRequest("Gender should be either 'Male' or 'Female'");
            else
                NewPersonDTO.Gender = Gender;

            if (clsPeople.GetCountryIdByCountryName(NewPersonDTO.CountryName) < 1)
                return BadRequest("Invalid Country Name");


            clsPeople NewPerson = new clsPeople(NewPersonDTO);

            if (!NewPerson.Save())
                return StatusCode(500, "Error in Database");

            NewPersonDTO.Id = NewPerson.Id;

            return CreatedAtRoute("GetPersonByID", new { idsd = NewPersonDTO.Id }, NewPersonDTO);
        }



        /// <summary>
        /// Updates an existing person in the system.
        /// </summary>
        /// <param name="id">The ID of the person to update.</param>
        /// <param name="UpdatedPersonDTO">The updated person data.</param>
        /// <returns>The updated <see cref="clsPeopleDTO"/> object if successful.</returns>
        [HttpPut("{id}", Name = "UpdatePerson")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<clsPeopleDTO> UpdatePerson(int id, clsPeopleDTO UpdatedPersonDTO)
        {
            if (id < 1)
                return BadRequest($"Invalid ID: {id}. ID must be greater than 0.");

            clsPeople FoundPerson = clsPeople.Find(id);

            if (FoundPerson != null)
                NotFound("Person Not Found");

            if (string.IsNullOrEmpty(UpdatedPersonDTO.Name) || string.IsNullOrEmpty(UpdatedPersonDTO.Surname)
                || string.IsNullOrEmpty(UpdatedPersonDTO.Address) || string.IsNullOrEmpty(UpdatedPersonDTO.Phone)
                || string.IsNullOrEmpty(UpdatedPersonDTO.Email))
                return BadRequest("Invalid Person Data");

            string Gender = UpdatedPersonDTO.Gender;
            Gender = char.ToUpper(Gender[0]) + Gender.Substring(1).ToLower();
            if (string.IsNullOrEmpty(Gender) || (Gender != "Male" && Gender != "Female"))
                return BadRequest("Gender should be either 'Male' or 'Female'");
            else
                UpdatedPersonDTO.Gender = Gender;

            if (clsPeople.GetCountryIdByCountryName(UpdatedPersonDTO.CountryName) < 1)
                return BadRequest("Invalid Country Name");


            FoundPerson.Name = UpdatedPersonDTO.Name;
            FoundPerson.Surname = UpdatedPersonDTO.Surname;
            FoundPerson.Address = UpdatedPersonDTO.Address;
            FoundPerson.Gender = UpdatedPersonDTO.Gender;
            FoundPerson.Phone = UpdatedPersonDTO.Phone;
            FoundPerson.Email = UpdatedPersonDTO.Email;
            FoundPerson.CountryName = UpdatedPersonDTO.CountryName;
            FoundPerson.BirthDate = UpdatedPersonDTO.BirthDate;

            if (!FoundPerson.Save())
                return StatusCode(500, "Error in Database");

            UpdatedPersonDTO.Id = FoundPerson.Id;

            return Ok(UpdatedPersonDTO);
        }



        /// <summary>
        /// Deletes a person from the system by their ID.
        /// </summary>
        /// <param name="id">The ID of the person to delete.</param>
        /// <returns>A success message if the person is deleted.</returns>
        [HttpDelete("{id}", Name = "DeletePerson")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult DeletePerson(int id)
        {
            if (id < 1)
                return BadRequest($"Invalid ID: {id}. ID must be greater than 0.");

            clsPeople FoundPerson = clsPeople.Find(id);

            if (clsPeople.DeletePerson(id))
                return Ok("Person Deleted Successfully");
            else
                return NotFound("Person Not found");
        }

    }


}