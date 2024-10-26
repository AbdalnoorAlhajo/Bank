using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Desktop_DataAccess
{
    /// <summary>
    /// Data Transfer Object (DTO) representing a country.
    /// </summary>
    public class clsCountriesDTO
    {
        // Properties representing Country information.
        public int ID { get; set; }
        public string CountryName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="clsCountriesDTO"/> class.
        /// </summary>
        /// <param name="iD">The ID of the country.</param>
        /// <param name="countryName">The name of the country.</param>
        public clsCountriesDTO(int iD, string countryName)
        {
            ID = iD;
            CountryName = countryName;
        }
    }

    /// <summary>
    /// Handles the communication with the API to manage countries.
    /// </summary>
    public class clsCountries
    {
        // Static HttpClient instance for making API requests.
        static readonly HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// Static constructor to initialize the base address of the HttpClient.
        /// </summary>
        static clsCountries()
        {
            // Base address of the API endpoint for country-related operations.
            _httpClient.BaseAddress = new Uri("https://localhost:7207/api/BankAPI_Countries/");
        }

        /// <summary>
        /// Retrieves all countries from the API.
        /// </summary>
        /// <returns>A list of <see cref="clsCountriesDTO"/> objects representing all countries, or null if an error occurs.</returns>
        static public async Task<List<clsCountriesDTO>> GetAllCountries()
        {
            try
            {
                var response = await _httpClient.GetAsync($"All");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<List<clsCountriesDTO>>();

                    return content;

                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetAllCountries(): " + ex.Message);
                return null;
            }
        }
    }
}
