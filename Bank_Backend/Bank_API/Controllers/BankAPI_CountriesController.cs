using Bank_API_Business;
using Bank_API_Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bank_API.Controllers
{
    /// <summary>
    /// API Controller for managing Countries in the Bank system.
    /// </summary>
    [Route("api/BankAPI_Countries")]
    [ApiController]
    public class BankAPI_CountriesController : ControllerBase
    {
        /// <summary>
        /// Retrieves all Countries.
        /// </summary>
        /// <returns>A list of <see cref="clsCountriesDTO"/> or a 404 status if none are found.</returns>
        [HttpGet("All", Name = "GetAllCountries")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<clsCountriesDTO>> GetAllCountries()
        {
            List<clsCountriesDTO> countriesDTOs = clsCountries.GetAllCountries();

            if (countriesDTOs.Count == 0)
                return NotFound("No Country Found");

            return Ok(countriesDTOs);

        }
    }
}
