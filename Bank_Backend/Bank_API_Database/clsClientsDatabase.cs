using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_API_Database
{
    /// <summary>
    /// Data Transfer Object (DTO) representing a bank client.
    /// </summary>
    public class clsClientsDTO
    {
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
    /// Handles database operations for bank clients, such as retrieval, addition, updating, and deletion.
    /// </summary>
    public class clsClientsDatabase
    {
        /// <summary>
        /// Retrieves all bank clients from the database.
        /// </summary>
        /// <returns>A list of <see cref="clsClientsDTO"/> representing all clients.</returns>
        static public List<clsClientsDTO> GetAllClients()
        {
            List<clsClientsDTO> clientsDTOs = new List<clsClientsDTO>();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllClients", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                clientsDTOs.Add(new clsClientsDTO
                                    (
                                    reader.GetInt32(reader.GetOrdinal("ID")),
                                    reader.GetDecimal(reader.GetOrdinal("Savings")),
                                    reader.GetString(reader.GetOrdinal("Password")),
                                    reader.GetInt32(reader.GetOrdinal("PersonID"))
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
            return clientsDTOs;
        }

        /// <summary>
        /// Retrieves a specific client by their ID.
        /// </summary>
        /// <param name="Id">The unique identifier of the client.</param>
        /// <returns>A <see cref="clsClientsDTO"/> object representing the client.</returns>
        static public clsClientsDTO GetClientById(int Id)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetClientById", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = Id;

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        
                        {
                            if(reader.Read())
                            {
                                return new clsClientsDTO
                                  (
                                  reader.GetInt32(reader.GetOrdinal("ID")),
                                  reader.GetDecimal(reader.GetOrdinal("Savings")),
                                  reader.GetString(reader.GetOrdinal("Password")),
                                  reader.GetInt32(reader.GetOrdinal("PersonID"))
                                  );
                            }
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        /// <summary>
        /// Adds a new client to the database.
        /// </summary>
        /// <param name="clientDTO">A <see cref="clsClientsDTO"/> object representing the new client.</param>
        /// <returns>The newly created client's ID or -1 if an error occurs.</returns>
        static public int AddNewClient(clsClientsDTO clientDTO)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddBankClient", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;


                        SqlParameter savingsParameter = command.Parameters.Add("@Savings", System.Data.SqlDbType.Decimal);
                        savingsParameter.Value = clientDTO.Savings;
                        savingsParameter.Precision = 12;
                        savingsParameter.Scale = 4;

                        command.Parameters.Add("@Password", System.Data.SqlDbType.NVarChar, 40).Value = clientDTO.Password ;
                        command.Parameters.Add("@PersonID", System.Data.SqlDbType.Int).Value = clientDTO.PersonID;

                        var outputIdParam = new SqlParameter("@NewClientId", SqlDbType.Int)
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
        /// Updates a client's password in the database.
        /// </summary>
        /// <param name="clientDTO">A <see cref="clsClientsDTO"/> object containing updated client information.</param>
        /// <returns>True if the update is successful; otherwise, false.</returns>
        static public bool UpdateClient(clsClientsDTO clientDTO)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateBankClient", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        /* This method calls the SP_UpdateBankClient stored procedure to update a client's 
                          password based on their unique ID. 

                        * Note: Only the password field is allowed to be updated. 
                        * Updates to other sensitive information such as Savings or PersonID are strictly prohibited due to data sensitivity and security risks.
                        * These fields are immutable to ensure data integrity and comply with banking security policies.*/

                        command.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = clientDTO.ID;
                        command.Parameters.Add("@Password", System.Data.SqlDbType.NVarChar, 40).Value = clientDTO.Password;

                        connection.Open();
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Deletes a client from the database by their ID.
        /// </summary>
        /// <param name="ID">The unique identifier of the client to be deleted.</param>
        /// <returns>True if the deletion is successful; otherwise, false.</returns>
        static public bool DeleteClient(int ID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_DeleteBankClient", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = ID;

                        connection.Open();
                        int RowAffected = (int)command.ExecuteScalar();

                        return (RowAffected == 1);
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
