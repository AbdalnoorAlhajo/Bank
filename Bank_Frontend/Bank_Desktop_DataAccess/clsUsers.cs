using Newtonsoft.Json;
using System.Net.Http.Json;


namespace Bank_Desktop_DataAccess
{
    /// <summary>
    /// Data Transfer Object (DTO) representing a user in the banking system.
    /// </summary>
    public class clsUsersDTO
    {
        // Properties representing user information.

        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// This property manages user permissions using a combination of binary values.
        /// If the user has full access to all features, the value will be set to -1. Otherwise, 
        /// permissions are assigned specific binary values, and the sum of these values represents 
        /// the user's permissions.
        /// </summary>
        // To check whether a user has a specific permission, the system uses the bitwise AND (&) operator. 
        // For example, if a user has permission to see the clients list, which has a value of 1 
        // (binary: 00000001), and their total permissions value is 3 (binary: 00000011, which 
        // corresponds to permissions for both viewing clients and adding new clients), the 
        // expression (3 & 1) results in 00000001. Since this matches the binary value for 
        // viewing clients, the user is allowed to perform that action.
        //
        // The following list shows the binary values assigned to each permission:
        // - -1: Permission to access all system features.
        // - 1: Permission to view the clients list.
        // - 2: Permission to add a new client.
        // - 4: Permission to delete a client.
        // - 8: Permission to update client information.
        // - 16: Permission to search for clients.
        // - 32: Permission to manage transactions.
        // - 128: Permission to view the login register.
        public int Permissions { get; set; }


        public int PersonID { get; set; }

        /// <summary>
        /// Constructor to initialize a new instance of <see cref="clsUsersDTO"/> class.
        /// </summary>
        /// <param name="iD">Unique user ID.</param>
        /// <param name="userName">Username of the user.</param>
        /// <param name="password">Password of the user.</param>
        /// <param name="permissions">Permission level of the user.</param>
        /// <param name="personID">Associated Person ID of the user.</param>
        public clsUsersDTO(int iD, string userName, string password, int permissions, int personID)
        {
            ID = iD;
            UserName = userName;
            Password = password;
            Permissions = permissions;
            PersonID = personID;
        }

    }

    /// <summary>
    /// Class responsible for handling user-related operations via API calls.
    /// </summary>
    public class clsUsers
    {
        // Static HttpClient instance for making API requests.
        static readonly HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// Static constructor to initialize the base address for the HttpClient.
        /// </summary>
        static clsUsers()
        {
            // Base address of the API endpoint for Users-related operations.
            _httpClient.BaseAddress = new Uri("https://localhost:0000/api/BankAPI_Users/");
        }


        /// <summary>
        /// Retrieves a user by their username and password from the API.
        /// </summary>
        /// <param name="userName">The username of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <returns>Returns the matching user or null if not found.</returns>
        static public async Task<clsUsersDTO> GetUser(string userName, string password)
        {

            try
            {
                var response = await _httpClient.GetAsync($"GetUserByUserNameAndPassword/{userName},{password}");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<clsUsersDTO>();

                    return content;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetUser(string userName, string password): " + ex.Message);
                return null;
            }
        }


        /// <summary>
        /// Retrieves a user by their username from the API.
        /// </summary>
        /// <param name="userName">The username of the user.</param>
        /// <returns>Returns the matching user or null if not found.</returns>
        static public async Task<clsUsersDTO> GetUser(string userName)
        {
            try
            {
                var response = await _httpClient.GetAsync($"GetUserByUserName/{userName}");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<clsUsersDTO>();

                    return content;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetUser(string userName): " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Retrieves a user by their ID from the API.
        /// </summary>
        /// <param name="ID">The unique UserID of the user.</param>
        /// <returns>Returns the matching user or null if not found.</returns>
        static public async Task<clsUsersDTO> GetUser(int ID)
        {
            try
            {
                var response = await _httpClient.GetAsync($"GetUserById/{ID}");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<clsUsersDTO>();

                    return content;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetUser(int ID): " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Retrieves all users from the API.
        /// </summary>
        /// <returns>Returns a list of users or null if an error occurs.</returns>
        static public async Task<List<clsUsersDTO>> GetAllUsers()
        {
            try
            {
                var response = await _httpClient.GetAsync($"All");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<List<clsUsersDTO>>();

                    return content;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetUser(string userName): " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Adds a new user to the system via the API.
        /// </summary>
        /// <param name="userDTO">The user data to be added.</param>
        /// <returns>Returns the newly created user or null if an error occurs.</returns>
        static public async Task<clsUsersDTO> AddNewUser(clsUsersDTO userDTO)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("", userDTO);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<clsUsersDTO>();

                    return content;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in AddNewUser(clsUsersDTO userDTO): " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Updates an existing user's details via the API.
        /// </summary>
        /// <param name="userDTO">
        /// The updated user data. The user ID will be extracted from the userDTO object and sent along with the update request.
        /// </param>
        /// <returns>
        /// Returns the updated user or null if an error occurs or if the user does not exist.
        /// </returns>
        static public async Task<clsUsersDTO> UpdateUser( clsUsersDTO userDTO)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{userDTO.ID}", userDTO);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<clsUsersDTO>();

                    return content;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in UpdateUser(int id, clsUsersDTO userDTO): " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Deletes a user by their ID via the API.
        /// </summary>
        /// <param name="id">The ID of the user to delete.</param>
        /// <returns>Returns true if the deletion is successful, otherwise false.</returns>
        static public async Task<bool> DeleteUser(int id)
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
                Console.WriteLine("Error in DeleteUser(int id): " + ex.Message);
                return false;
            }
        }
    }
}
