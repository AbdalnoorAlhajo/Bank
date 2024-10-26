using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_API_Database
{
    /// <summary>
    /// Data Transfer Object (DTO) for representing a country in the system.
    /// </summary>
    public class clsCountriesDTO
    {
        public int ID { get; set; }
        public string CountryName { get; set; }
        public clsCountriesDTO(int iD, string countryName)
        {
            ID = iD;
            CountryName = countryName;
        }
    }

    /// <summary>
    /// Class responsible for interacting with the database to perform country-related operations.
    /// </summary>
    public class clsCountriesDatabase
    {
        /// <summary>
        /// Retrieves a list of all countries from the database.
        /// </summary>
        /// <returns>A list of <see cref="clsCountriesDTO"/> objects representing all countries.</returns>
        static public List<clsCountriesDTO> GetAllCountries()
        {
            List<clsCountriesDTO> CountriesDTOs = new List<clsCountriesDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllCountries", connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CountriesDTOs.Add(new clsCountriesDTO
                                    (
                                        reader.GetInt32(reader.GetOrdinal("CountryID")),
                                        reader.GetString(reader.GetOrdinal("CountryName"))
                                    ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return CountriesDTOs;
        }
    }
}
