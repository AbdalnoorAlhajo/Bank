using Bank_Desktop_DataAccess;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Desktop
{
    /// <summary>
    /// A static class that contains the current user information and permission checking functionality.
    /// </summary>
    static public class clsGlobal
    {
        static public clsUsersDTO GlobalUserDTO;

        public enum enPermissions
        {
            eAll = -1,           // Full access to all system features
            pListClients = 1,     // Permission to list all clients
            pAddNewClient = 2,    // Permission to add a new client
            pDeleteClient = 4,    // Permission to delete a client
            pUpdateClients = 8,   // Permission to update client information
            pFindClient = 16,     // Permission to search for a specific client
            pTranactions = 32,    // Permission to perform transactions
            pManageUsers = 64,    // Permission to manage user accounts
            pShowLogInRegister = 128 // Permission to view login activities
        };

        /// <summary>
        /// Checks whether the current user has the specified permission.
        /// </summary>
        /// <param name="Permission">The permission to check, defined by the <see cref="enPermissions"/> enum.</param>
        /// <returns>
        /// Returns <c>true</c> if the user has the specified permission; otherwise, <c>false</c>.
        /// If the user has full access (<see cref="enPermissions.eAll"/>), the method returns <c>true</c>.
        /// </returns>
        /// <remarks>
        /// This method first checks if the <see cref="GlobalUserDTO"/> is null, which means 
        /// no user is logged in, and it returns <c>false</c>. If the user has the <c>eAll</c> 
        /// permission, it returns <c>true</c> immediately. Otherwise, the method performs 
        /// a bitwise comparison between the required permission and the user's assigned 
        /// permissions to determine access.
        /// </remarks>
        static public bool CheckAccessPermission(enPermissions Permission)
        {
            if(GlobalUserDTO == null)
                return false;

            // Grant access if the user has all permissions.
            if (GlobalUserDTO.Permissions == (int)enPermissions.eAll)
                return true;

            // Check if the user has the specific permission using bitwise AND.
            if (((int)Permission & GlobalUserDTO.Permissions) == (int)Permission)
                return true;

            // Return false if the user lacks the requested permission.
            return false;

        }
    }



}
