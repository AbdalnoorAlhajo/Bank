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
    /// Data Transfer Object (DTO) representing a person.
    /// </summary>
    public class clsPeopleDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string CountryName { get; set; }

        /// <summary>
        /// Gets the full name of the person, combining first name and surname.
        /// </summary>
        public string FullName { get {return Name + " " + Surname; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="clsPeopleDTO"/> class.
        /// </summary>
        /// <param name="id">The ID of the person.</param>
        /// <param name="name">The first name of the person.</param>
        /// <param name="surname">The surname of the person.</param>
        /// <param name="gender">The gender of the person.</param>
        /// <param name="phone">The phone number of the person.</param>
        /// <param name="Email">The email address of the person.</param>
        /// <param name="address">The address of the person.</param>
        /// <param name="BirthDate">The BirthDate of the person.</param>
        /// <param name="countryName">The country name of the person.</param>
        public clsPeopleDTO(int id, string name, string surname, string gender, string phone, string Email
            , string address, DateTime BirthDate, string countryName)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Gender = gender;
            Phone = phone;
            this.Email = Email;
            Address = address;
            this.BirthDate = BirthDate;
            CountryName = countryName;
        }
    }

    /// <summary>
    /// Class responsible for handling People-related operations via API calls.
    /// </summary>
    public class clsPeople
    {
        // Static instance of HttpClient to communicate with the API.
        static readonly HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// Static constructor to initialize the base address of the HttpClient.
        /// </summary>
        static clsPeople()
        {
            // Base address of the API endpoint for People-related operations.
            _httpClient.BaseAddress = new Uri("https://localhost:0000/api/BankAPI_People/");
        }


        /// <summary>
        /// Retrieves a person by their ID from the API.
        /// </summary>
        /// <param name="ID">The ID of the person to retrieve.</param>
        /// <returns>A <see cref="clsPeopleDTO"/> object representing the person, or null if an error occurs.</returns>
        static public async Task<clsPeopleDTO> GetPersonByID(int ID)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{ID}");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<clsPeopleDTO>();

                    return content;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetPersonByID(int ID): " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Retrieves all people from the API.
        /// </summary>
        /// <returns>A list of <see cref="clsPeopleDTO"/> objects representing all people, or null if an error occurs.</returns>
        static public async Task<List<clsPeopleDTO>> GetAllPeople()
        {
            try
            {
                var response = await _httpClient.GetAsync($"All");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<List<clsPeopleDTO>>();

                    return content;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetAllPeople(): " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Adds a new person via the API.
        /// </summary>
        /// <param name="PersonDTO">The person to add.</param>
        /// <returns>The newly created <see cref="clsPeopleDTO"/> object, or null if an error occurs.</returns>
        static public async Task<clsPeopleDTO> AddNewPerson(clsPeopleDTO PersonDTO)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("", PersonDTO);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<clsPeopleDTO>();

                    return content;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in AddNewPerson(clsPeopleDTO PersonDTO): " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Updates an existing person's details via the API.
        /// </summary>
        /// <param name="PersonDTO">The updated person data. The Person ID will be extracted from the <see cref="clsPeopleDTO"/> object 
        /// and sent along with the update request. </param>
        /// <returns>The updated <see cref="clsPeopleDTO"/> object, or null if an error occurs or if the person does not exist.</returns>
        static public async Task<clsPeopleDTO> UpdatePerson(clsPeopleDTO PersonDTO)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{PersonDTO.Id}", PersonDTO);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<clsPeopleDTO>();

                    return content;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in UpdatePerson(clsPeopleDTO PersonDTO): " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Deletes a person by their ID via the API.
        /// </summary>
        /// <param name="id">The ID of the person to delete.</param>
        /// <returns>True if the person was successfully deleted, otherwise false.</returns>
        static public async Task<bool> DeletePerson(int id)
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
                Console.WriteLine("Error in DeletePerson(int id): " + ex.Message);
                return false;
            }
        }
    }

}
