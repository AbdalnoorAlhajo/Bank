using Bank_API_Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_API_Business
{
    /// <summary>
    /// Represents a user in the bank system, including their details and operations for managing users.
    /// </summary>
    public class clsUsers
    {
        /// <summary>
        /// Enumeration to specify whether the user is in AddNew or Update mode.
        /// </summary>
        public enum enMode { AddNew = 0, Update = 1 }

        public enMode _Mode;
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }
        public int PersonID { get; set; }

        /// <summary>
        /// Gets the Data Transfer Object (DTO) for the current user, containing user data.
        /// </summary>
        public clsUsersDTO UDTO
        {
            get { return new clsUsersDTO(ID, UserName, Password, Permissions, PersonID); }
        
        }

        clsUsers(clsUsersDTO userDTO, enMode Mode = enMode.Update)
        {
            ID = userDTO.ID;
            UserName = userDTO.UserName;
            Password = userDTO.Password;
            Permissions = userDTO.Permissions;
            PersonID = userDTO.PersonID;

            _Mode = Mode;
        }

        public clsUsers(clsUsersDTO userDTO)
        {
            ID = -1;
            UserName = userDTO.UserName;
            Password = userDTO.Password;
            Permissions = userDTO.Permissions;
            PersonID = userDTO.PersonID;

            _Mode = enMode.AddNew;
        }

        /// <summary>
        /// Retrieves all users from the database.
        /// </summary>
        /// <returns>A list of <see cref="clsUsersDTO"/> representing all users.</returns>
        static public List<clsUsersDTO> GetAllUsers()
        {
            return clsUsersDatabase.GetAllUsers();
        }

        /// <summary>
        /// Finds a user by their unique ID.
        /// </summary>
        /// <param name="Id">The user's unique identifier.</param>
        /// <returns>A <see cref="clsUsers"/> object representing the user if found, otherwise null.</returns>
        static public clsUsers Find(int Id)
        {
            clsUsersDTO userDTO = clsUsersDatabase.GetUserById(Id);

            if (userDTO == null)
                return null;

            return new clsUsers(userDTO, enMode.Update);
        }

        /// <summary>
        /// Finds a user by their username.
        /// </summary>
        /// <param name="UserName">The user's username.</param>
        /// <returns>A <see cref="clsUsers"/> object representing the user if found, otherwise null.</returns>
        static public clsUsers Find(string UserName)
        {
            clsUsersDTO userDTO = clsUsersDatabase.GetUserByUserName(UserName);

            if (userDTO == null)
                return null;

            return new clsUsers(userDTO, enMode.Update);
        }

        /// <summary>
        /// Finds a user by their username and password.
        /// </summary>
        /// <param name="UserName">The user's username.</param>
        /// <param name="Password">The user's password.</param>
        /// <returns>A <see cref="clsUsers"/> object representing the user if found, otherwise null.</returns>
        static public clsUsers Find(string UserName, string Password)
        {
            clsUsersDTO userDTO = clsUsersDatabase.GetUserByUserNameAndPassword(UserName, Password);

            if (userDTO == null)
                return null;

            return new clsUsers(userDTO, enMode.Update);
        }

        /// <summary>
        /// Adds a new user to the database.
        /// </summary>
        /// <returns>True if the user is added successfully, otherwise false.</returns>
        bool _AddNewUser()
        {
            ID = clsUsersDatabase.AddNewUser(UDTO);

            return (ID > 0);
        }

        /// <summary>
        /// Updates an existing user's information in the database.
        /// </summary>
        /// <returns>True if the update is successful, otherwise false.</returns>
        bool _UpdateUser()
        {
            return clsUsersDatabase.UpdatePerson(UDTO);
        }

        /// <summary>
        /// Saves the user to the database. Determines whether to add or update based on the current mode.
        /// </summary>
        /// <returns>True if the operation is successful, otherwise false.</returns>
        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.Update:
                    return _UpdateUser();
                case enMode.AddNew:
                    if(_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Deletes a user from the database.
        /// </summary>
        /// <param name="Id">The unique identifier of the user to be deleted.</param>
        /// <returns>True if the deletion is successful, otherwise false.</returns>
        static public bool DeleteUser(int Id)
        {
            return clsUsersDatabase.DeleteUser(Id);
        }
    }
}
