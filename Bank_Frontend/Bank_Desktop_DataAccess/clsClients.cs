using System.Net.Http.Json;

namespace Bank_Desktop_DataAccess
{
    /// <summary>
    /// Data Transfer Object (DTO) representing a Client.
    /// </summary>
    public class clsClientsDTO
    {
        // Properties representing Client information.
        public int ID { get; set; }
        public decimal Savings { get; set; }
        public string Password { get; set; }
        public int PersonID { get; set; }

        public clsClientsDTO(int ID, decimal Savings, string Password, int PersonID)
        {
            this.ID = ID;
            this.Savings = Savings;
            this.Password = Password;
            this.PersonID = PersonID;
        }
    }

    /// <summary>
    /// Class responsible for handling Clients-related operations via API calls.
    /// </summary>
    public class clsClients
    {
        // Static instance of HttpClient to communicate with the API.
        static readonly HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// Static constructor to initialize the base address of the HttpClient.
        /// </summary>
        static clsClients()
        {
            // Base address of the API endpoint for Clients-related operations.
            _httpClient.BaseAddress = new Uri("https://localhost:7207/api/BankAPI_Clients/");
        }

        /// <summary>
        /// Retrieves a Client by their ID from the API.
        /// </summary>
        /// <param name="ID">The ID of the Client to retrieve.</param>
        /// <returns>A <see cref="clsClientsDTO"/> object representing the Client, or null if an error occurs.</returns>
        static public async Task<clsClientsDTO> GetClientByID(int ID)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{ID}");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync < clsClientsDTO>();

                    return content;

                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetClientByID(int ID): " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Retrieves all clients from the API.
        /// </summary>
        /// <returns>A list of <see cref="clsClientsDTO"/> objects representing all clients, or null if an error occurs.</returns>
        static public async Task<List<clsClientsDTO>> GetAllClients()
        {
            try
            {
                var response = await _httpClient.GetAsync($"All");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<List<clsClientsDTO>>();

                    return content;

                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetAllClients(): " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Adds a new Client via the API.
        /// </summary>
        /// <param name="ClientDTO">The <see cref="clsClientsDTO"/> object representing the client to add.</param>
        /// <returns>The newly created <see cref="clsClientsDTO"/> object, or null if an error occurs.</returns>
        static public async Task<clsClientsDTO> AddNewClient(clsClientsDTO ClientDTO)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("", ClientDTO);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<clsClientsDTO>();

                    return content;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in AddNewClient(clsClientsDTO ClientDTO): " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Updates an existing client's details via the API.
        /// </summary>
        /// <param name="ClientDTO">The updated client data. The client ID will be extracted from the <see cref="clsClientsDTO"/> object and sent along with the update request.</param>
        /// <returns>The updated <see cref="clsClientsDTO"/> object, or null if an error occurs or if the client does not exist.</returns>
        static public async Task<clsClientsDTO> UpdateClient(clsClientsDTO ClientDTO)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{ClientDTO.ID}", ClientDTO);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<clsClientsDTO>();

                    return content;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in UpdateClient(clsClientsDTO ClientDTO): " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Deletes a client by their ID via the API.
        /// </summary>
        /// <param name="id">The ID of the client to delete.</param>
        /// <returns>True if the client was successfully deleted, otherwise false.</returns>
        static public async Task<bool> DeleteClient(int id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"{id}");

                if (response.IsSuccessStatusCode)
                    return response.StatusCode == System.Net.HttpStatusCode.OK;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in DeleteClient(int id): " + ex.Message);
                return false;
            }
        }
    }
}
