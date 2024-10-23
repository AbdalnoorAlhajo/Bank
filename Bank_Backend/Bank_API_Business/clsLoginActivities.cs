using Bank_API_Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_API_Business
{
    /// <summary>
    /// Represents the login activities in the banking system.
    /// Handles operations for managing login activity records.
    /// </summary>
    public class clsLoginActivities
    {
        /// <summary>
        /// Enumeration to specify whether the login activity is being added (AddNew) or updated (Update).
        /// </summary>
        public enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode;
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public int UserID { get; set; }

        /// <summary>
        /// Gets the Data Transfer Object (DTO) for the login activity, containing its details.
        /// </summary>
        public clsLoginActivitiesDTO LDTO { get {return new clsLoginActivitiesDTO(ID, Date, UserID); } }

        public clsLoginActivities( clsLoginActivitiesDTO dto)
        {
            UserID = dto.UserID;

            Date = DateTime.Now;

            _Mode = enMode.AddNew;
        }

        /// <summary>
        /// Retrieves all login activities from the database.
        /// </summary>
        /// <returns>A list of <see cref="clsLoginActivitiesDTO"/> representing all login activities.</returns>
        static public List<clsLoginActivitiesDTO> GetLoginActivities()
        {
            return clsLoginActivitiesDatabase.GetLoginActivities();
        }

        /// <summary>
        /// Retrieves all login activities by a specific user ID.
        /// </summary>
        /// <param name="UserID">The unique identifier of the user.</param>
        /// <returns>A list of <see cref="clsLoginActivitiesDTO"/> representing the user's login activities.</returns>
        static public List<clsLoginActivitiesDTO> GetLoginActivitiesByUserID(int UserID)
        {
            return clsLoginActivitiesDatabase.GetLoginActivitiesByUserID(UserID);
        }

        /// <summary>
        /// Adds a new login activity to the database.
        /// </summary>
        /// <returns>True if the login activity is added successfully, otherwise false.</returns>
        bool _AddNewLoginActivity()
        {
            ID = clsLoginActivitiesDatabase.AddNewLoginActivity(LDTO);

            return (ID > 0);
        }

        /// <summary>
        /// Saves the login activity to the database. Determines whether to add or update based on the current mode.
        /// </summary>
        /// <returns>True if the operation is successful, otherwise false.</returns>
        public bool Save()
        {
            switch( _Mode)
            {
                case enMode.AddNew:
                    if(_AddNewLoginActivity())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                case enMode.Update:
                    return false; // Return false for now, reserved for future use when the system expands.
                default:
                    return false;
            }
        }

        /// <summary>
        /// Retrieves a login activity by its unique identifier.
        /// </summary>
        /// <param name="LoginActivityID">The unique identifier of the login activity.</param>
        /// <returns>A <see cref="clsLoginActivitiesDTO"/> object representing the login activity if found, otherwise null.</returns>
        static public clsLoginActivitiesDTO GetLoginActivityByID(int LoginActivityID)
        {
            return clsLoginActivitiesDatabase.GetLoginActivityByID(LoginActivityID);
        }
    }
}
