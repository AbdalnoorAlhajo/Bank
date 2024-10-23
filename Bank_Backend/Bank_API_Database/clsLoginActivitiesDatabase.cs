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
    /// Data Transfer Object representing a login activity.
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
    /// A class that interacts with the database to perform CRUD operations on login activities.
    /// </summary>
    public class clsLoginActivitiesDatabase
    {
        /// <summary>
        /// Retrieves all login activities for all users from the database.
        /// </summary>
        /// <returns>A list of <see cref="clsLoginActivitiesDTO"/> objects representing all login activities.</returns>
        static public List<clsLoginActivitiesDTO> GetLoginActivities()
        {
            List<clsLoginActivitiesDTO> LoginActivitiesDTOs = new List<clsLoginActivitiesDTO>();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetAllLoginActivities", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                LoginActivitiesDTOs.Add(new clsLoginActivitiesDTO
                                    (
                                    reader.GetInt32(reader.GetOrdinal("ID")),
                                    reader.GetDateTime(reader.GetOrdinal("Date")),
                                    reader.GetInt32(reader.GetOrdinal("UserID"))
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
            return LoginActivitiesDTOs;
        }


        /// <summary>
        /// Retrieves all login activities for a specific user based on their UserID.
        /// </summary>
        /// <param name="UserID">The ID of the user to retrieve login activities for.</param>
        /// <returns>A list of <see cref="clsLoginActivitiesDTO"/> objects representing login activities for the specified user.</returns>
        static public List<clsLoginActivitiesDTO> GetLoginActivitiesByUserID(int UserID)
        {
            List<clsLoginActivitiesDTO> LoginActivitiesDTOs = new List<clsLoginActivitiesDTO>();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetLoginActivitiesByUserID", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.Add("@UserID", System.Data.SqlDbType.Int).Value = UserID;

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                LoginActivitiesDTOs.Add(new clsLoginActivitiesDTO
                                    (
                                    reader.GetInt32(reader.GetOrdinal("ID")),
                                    reader.GetDateTime(reader.GetOrdinal("Date")),
                                    reader.GetInt32(reader.GetOrdinal("UserID"))
                                    ));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return LoginActivitiesDTOs;
        }

        /// <summary>
        /// Retrieves a specific login activity from the database based on its ID.
        /// </summary>
        /// <param name="LoginActivityID">The ID of the login activity to retrieve.</param>
        /// <returns>A <see cref="clsLoginActivitiesDTO"/> object representing the login activity, or null if not found.</returns>
        static public clsLoginActivitiesDTO GetLoginActivityByID(int LoginActivityID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_GetLoginActivitiesById", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.Add("@ID", System.Data.SqlDbType.Int).Value = LoginActivityID;

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new clsLoginActivitiesDTO
                                    (
                                    reader.GetInt32(reader.GetOrdinal("ID")),
                                    reader.GetDateTime(reader.GetOrdinal("Date")),
                                    reader.GetInt32(reader.GetOrdinal("UserID"))
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
        /// Adds a new login activity to the database.
        /// </summary>
        /// <param name="clsLoginActivityDTO">A <see cref="clsLoginActivitiesDTO"/> object containing the details of the login activity to add.</param>
        /// <returns>The ID of the newly added login activity, or -1 in case of an error.</returns>
        static public int AddNewLoginActivity(clsLoginActivitiesDTO clsLoginActivityDTO)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("SP_AddBankLoginActivity", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;

                        command.Parameters.Add("@Date", System.Data.SqlDbType.DateTime).Value = clsLoginActivityDTO.Date;
                        command.Parameters.Add("@UserID", System.Data.SqlDbType.Int).Value = clsLoginActivityDTO.UserID;

                        var outputIdParam = new SqlParameter("@NewLoginActivityId", SqlDbType.Int)
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
    }


}
