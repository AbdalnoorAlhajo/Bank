using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace Bank_API_Database
{
    /// <summary>
    /// Data Transfer Object representing a Person in the system.
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

        public clsPeopleDTO (int id, string name, string surname, string gender, string phone, string Email
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
    /// A class that interacts with the database to perform CRUD operations on People data.
    /// </summary>
    public class clsPeopleDatabase
    {
        /// <summary>
        /// Retrieves a list of all people from the database.
        /// </summary>
        /// <returns>A list of <see cref="clsPeopleDTO"/> objects representing all people in the database.</returns>
        static public List<clsPeopleDTO> GetAllPeople()
        {
            List<clsPeopleDTO> peopleDTOs = new List<clsPeopleDTO>();
            try
            { 
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllPeople", connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                peopleDTOs.Add(new clsPeopleDTO
                                    (
                                        reader.GetInt32(reader.GetOrdinal("ID")),
                                        reader.GetString(reader.GetOrdinal("Name")),
                                        reader.GetString(reader.GetOrdinal("Surname")),
                                        reader.GetString(reader.GetOrdinal("Gender")),
                                        reader.GetString(reader.GetOrdinal("Phone")),
                                        reader.GetString(reader.GetOrdinal("Email")),
                                        reader.GetString(reader.GetOrdinal("Address")),
                                        reader.GetDateTime(reader.GetOrdinal("BirthDate")),
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
            return peopleDTOs;
        }

        /// <summary>
        /// Retrieves a person from the database by their ID.
        /// </summary>
        /// <param name="ID">The ID of the person to retrieve.</param>
        /// <returns>A <see cref="clsPeopleDTO"/> object representing the person, or null if not found.</returns>
        static public clsPeopleDTO GetPersonByID(int ID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetPersonByID", connection))
                    {
                        connection.Open();
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.Add("@PersonID", System.Data.SqlDbType.Int).Value = ID;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new clsPeopleDTO
                                    (
                                        reader.GetInt32(reader.GetOrdinal("ID")),
                                        reader.GetString(reader.GetOrdinal("Name")),
                                        reader.GetString(reader.GetOrdinal("Surname")),
                                        reader.GetString(reader.GetOrdinal("Gender")),
                                        reader.GetString(reader.GetOrdinal("Phone")),
                                        reader.GetString(reader.GetOrdinal("Email")),
                                        reader.GetString(reader.GetOrdinal("Address")),
                                        reader.GetDateTime(reader.GetOrdinal("BirthDate")),
                                        reader.GetString(reader.GetOrdinal("CountryName"))
                                    );
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }


        // Future enhancement: The GetCountryIdByCountryName function, along with related methods, 
        // should be refactored into the clsCountriesDatabase class to improve separation of concerns 
        // and maintain consistency within the data access layer.
        static public int GetCountryIdByCountryName(string countryName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetCountryIdByName", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.Add("@CountryName", System.Data.SqlDbType.NVarChar, 40).Value = countryName;

                        var outputIdParam = new SqlParameter("@CountryId", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputIdParam);

                        connection.Open();
                        command.ExecuteNonQuery();

                        return (int)outputIdParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        /// <summary>
        /// Adds a new person to the database.
        /// </summary>
        /// <param name="PersonDTO">A <see cref="clsPeopleDTO"/> object containing the details of the person to add.</param>
        /// <returns>The ID of the newly added person, or -1 in case of an error.</returns>
        static public int AddNewPerson(clsPeopleDTO PersonDTO)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddPerson", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar, 40).Value = PersonDTO.Name;
                        command.Parameters.Add("@Surname", System.Data.SqlDbType.NVarChar, 40).Value = PersonDTO.Surname;
                        command.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar, 40).Value = PersonDTO.Email;
                        command.Parameters.Add("@Phone", System.Data.SqlDbType.NVarChar, 20).Value = PersonDTO.Phone;
                        command.Parameters.Add("@Address", System.Data.SqlDbType.NVarChar, 100).Value = PersonDTO.Address;
                        command.Parameters.Add("@BirthDate", System.Data.SqlDbType.Date).Value = PersonDTO.BirthDate;

                        // Gender is sotred as bit in database( 1 for Male, 0 for Female)
                        command.Parameters.Add("@Gender", System.Data.SqlDbType.Bit).Value = (PersonDTO.Gender == "Male") ? 1 : 0;

                        // In the Database (People Table), we do not store the countyName rather we store the countryID 
                        command.Parameters.Add("@CountryId", System.Data.SqlDbType.Int).Value = GetCountryIdByCountryName(PersonDTO.CountryName);

                        var outputIdParam = new SqlParameter("@NewPersonId", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        command.Parameters.Add(outputIdParam);

                        connection.Open();
                        command.ExecuteNonQuery();

                        return (int)outputIdParam.Value;
                    }
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }

        }

        /// <summary>
        /// Updates the information of an existing person in the database.
        /// </summary>
        /// <param name="PersonDTO">A <see cref="clsPeopleDTO"/> object containing the updated details of the person.</param>
        /// <returns>True if the update was successful, false otherwise.</returns>
        static public bool UpdatePerson(clsPeopleDTO PersonDTO)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdatePerson", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = PersonDTO.Id;
                        command.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar, 40).Value = PersonDTO.Name;
                        command.Parameters.Add("@Surname", System.Data.SqlDbType.NVarChar, 40).Value = PersonDTO.Surname;
                        command.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar, 40).Value = PersonDTO.Email;
                        command.Parameters.Add("@Phone", System.Data.SqlDbType.NVarChar, 20).Value = PersonDTO.Phone;
                        command.Parameters.Add("@Address", System.Data.SqlDbType.NVarChar, 100).Value = PersonDTO.Address;
                        command.Parameters.Add("@BirthDate", System.Data.SqlDbType.Date).Value = PersonDTO.BirthDate;

                        // Gender is stored as a bit in the database, where: 1 represents Male, 0 represents Female
                        command.Parameters.Add("@Gender", System.Data.SqlDbType.Bit).Value = (PersonDTO.Gender == "Male") ? 1 : 0;

                        // In the Database (People Table), we do not store the country name directly.
                        // Instead, we store the corresponding CountryID, which acts as a foreign key referencing the Country table.
                        // The method GetCountryIdByCountryName retrieves the appropriate CountryID based on the provided country name.
                        command.Parameters.Add("@CountryId", System.Data.SqlDbType.Int).Value = GetCountryIdByCountryName(PersonDTO.CountryName);


                        connection.Open();
                        command.ExecuteNonQuery();

                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }

        /// <summary>
        /// Deletes a person from the database.
        /// </summary>
        /// <param name="ID">The ID of the person to delete.</param>
        /// <returns>True if the deletion was successful, false otherwise.</returns>
        static public bool DeletePerson(int ID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_DeletePerson", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ID", ID);

                        connection.Open();
                        int rowsAffected = (int)command.ExecuteScalar();
                        return (rowsAffected == 1);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
