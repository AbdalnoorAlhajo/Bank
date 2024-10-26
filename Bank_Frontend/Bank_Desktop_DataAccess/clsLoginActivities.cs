using Microsoft.VisualBasic.Logging;
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
    /// Data Transfer Object (DTO) representing a login activity.
    /// </summary>
    public class clsLoginActivitiesDTO
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int UserID { get; set; }

        public clsLoginActivitiesDTO(int ID, DateTime Date, int UserID)
        {
            this.ID = ID;
            this.Date = Date;
            this.UserID = UserID;
        }
    }

    /// <summary>
    /// Class responsible for handling login activity-related operations via API calls.
    /// </summary>
    public class clsLoginActivities
    {
        // Static HttpClient instance for making API requests.
        static readonly HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// Static constructor to initialize the base address for the HttpClient.
        /// </summary>
        static clsLoginActivities()
        {
            // Base address of the API endpoint for Login Activities-related operations.
            _httpClient.BaseAddress = new Uri("https://localhost:7207/api/BankAPI_LoginActivities/");
        }

        /// <summary>
        /// Retrieves all login activities.
        /// </summary>
        /// <returns>A list of <see cref="clsLoginActivitiesDTO"/> representing all login activities, or null if an error occurs.</returns>
        static public async Task<List<clsLoginActivitiesDTO>> GetLoginActivities()
        {
            try
            {
                var response = await _httpClient.GetAsync($"All");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<List<clsLoginActivitiesDTO>>();

                    return content;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetLoginActivities(): " + ex.Message);
                return null;
            }
        }


        /// <summary>
        /// Adds a new login activity.
        /// </summary>
        /// <param name="loginActivityDTO">The login activity information to add.</param>
        /// <returns>The newly created <see cref="clsLoginActivitiesDTO"/> object if the addition is successful; otherwise, null.</returns>
        static public async Task<clsLoginActivitiesDTO> AddNewLoginActivity(clsLoginActivitiesDTO loginActivityDTO)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync($"", loginActivityDTO);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<clsLoginActivitiesDTO>();

                    return content;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in AddNewLoginActivity(clsLoginActivitiesDTO loginActivityDTO): " + ex.Message);
                return null;
            }
        }
    }
}
