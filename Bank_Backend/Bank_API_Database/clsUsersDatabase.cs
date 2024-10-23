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
    /// Data Transfer Object (DTO) representing a user in the bank system.
    /// </summary>
    public class clsUsersDTO
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }
        public int PersonID { get; set; }

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
    /// Class responsible for database operations related to users.
    /// </summary>
    public class clsUsersDatabase
    {
        /// <summary>
        /// Retrieves all users from the database.
        /// </summary>
        /// <returns>A list of <see cref="clsUsersDTO"/> representing all users.</returns>
        static public List<clsUsersDTO> GetAllUsers()
        {
            List<clsUsersDTO> UsersDTOs = new List<clsUsersDTO>();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllUsers", connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                UsersDTOs.Add(new clsUsersDTO
                                    (
                                        reader.GetInt32(reader.GetOrdinal("ID")),
                                        reader.GetString(reader.GetOrdinal("UserName")),
                                        reader.GetString(reader.GetOrdinal("Password")),
                                        reader.GetInt32(reader.GetOrdinal("Permissions")),
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
            return UsersDTOs;
        }


        /// <summary>
        /// Retrieves a user by their unique identifier.
        /// </summary>
        /// <param name="Id">The unique identifier of the user.</param>
        /// <returns>A <see cref="clsUsersDTO"/> representing the user, or null if not found.</returns>
        static public clsUsersDTO GetUserById(int Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetUserById", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = Id;

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new clsUsersDTO
                                    (
                                        reader.GetInt32(reader.GetOrdinal("ID")),
                                        reader.GetString(reader.GetOrdinal("UserName")),
                                        reader.GetString(reader.GetOrdinal("Password")),
                                        reader.GetInt32(reader.GetOrdinal("Permissions")),
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
        /// Retrieves a user by their username.
        /// </summary>
        /// <param name="UserName">The username of the user.</param>
        /// <returns>A <see cref="clsUsersDTO"/> representing the user, or null if not found.</returns>
        static public clsUsersDTO GetUserByUserName(string UserName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetUserByUserName", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.Add("@UserName", System.Data.SqlDbType.NVarChar, 40).Value = UserName;

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new clsUsersDTO
                                    (
                                        reader.GetInt32(reader.GetOrdinal("ID")),
                                        reader.GetString(reader.GetOrdinal("UserName")),
                                        reader.GetString(reader.GetOrdinal("Password")),
                                        reader.GetInt32(reader.GetOrdinal("Permissions")),
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
        /// Retrieves a user by their username and password.
        /// </summary>
        /// <param name="UserName">The username of the user.</param>
        /// <param name="Password">The password of the user.</param>
        /// <returns>A <see cref="clsUsersDTO"/> representing the user, or null if not found.</returns>
        static public clsUsersDTO GetUserByUserNameAndPassword(string UserName, string Password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetUserByUserNameAndPassword", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.Add("@UserName", System.Data.SqlDbType.NVarChar, 40).Value = UserName;
                        command.Parameters.Add("@Password", System.Data.SqlDbType.NVarChar, 40).Value = Password;

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new clsUsersDTO
                                    (
                                        reader.GetInt32(reader.GetOrdinal("ID")),
                                        reader.GetString(reader.GetOrdinal("UserName")),
                                        reader.GetString(reader.GetOrdinal("Password")),
                                        reader.GetInt32(reader.GetOrdinal("Permissions")),
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
        /// Adds a new user to the database.
        /// </summary>
        /// <param name="UserDTO">The <see cref="clsUsersDTO"/> object containing user details.</param>
        /// <returns>The unique identifier of the newly created user, or -1 if the operation failed.</returns>
        public static int AddNewUser(clsUsersDTO UserDTO)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddBankUser", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@UserName", SqlDbType.NVarChar, 40).Value = UserDTO.UserName;
                        command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = UserDTO.Password;
                        command.Parameters.Add("@Permissions", SqlDbType.Int).Value = UserDTO.Permissions;
                        command.Parameters.Add("@PersonID", SqlDbType.Int).Value = UserDTO.PersonID;

                        var outputIdParam = new SqlParameter("@NewUserId", SqlDbType.Int)
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
        /// Updates an existing user's details in the database.
        /// </summary>
        /// <param name="UserDTO">The <see cref="clsUsersDTO"/> object containing updated user details.</param>
        /// <returns>True if the update was successful, false otherwise.</returns>
        static public bool UpdatePerson(clsUsersDTO UserDTO)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_UpdateBankUser", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = UserDTO.ID;
                        command.Parameters.Add("@UserName", SqlDbType.NVarChar, 40).Value = UserDTO.UserName;
                        command.Parameters.Add("@Password", SqlDbType.NVarChar, 40).Value = UserDTO.Password;
                        command.Parameters.Add("@Permissions", SqlDbType.Int).Value = UserDTO.Permissions;
                        command.Parameters.Add("@PersonID", SqlDbType.Int).Value = UserDTO.PersonID;

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
        /// Deletes a user from the database by their unique identifier.
        /// </summary>
        /// <param name="Id">The unique identifier of the user to delete.</param>
        /// <returns>True if the Delete was successful, false otherwise.</returns>
        static public bool DeleteUser(int Id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_DeleteBankUser", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = Id;


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
