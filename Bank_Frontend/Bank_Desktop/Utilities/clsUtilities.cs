using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Desktop.Utilities
{
    /// <summary>
    /// A utility class that provides methods for storing and retrieving user credentials (username and password) 
    /// in the Windows Registry.
    /// </summary>
    static public class clsUtilities
    {
        /// <summary>
        /// Stores the provided username and password in the Windows Registry.
        /// </summary>
        /// <param name="userName">The username to be saved in the registry.</param>
        /// <param name="password">The password to be saved in the registry.</param>
        /// <returns>
        /// Returns <c>true</c> if the credentials were successfully saved; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// The method stores the credentials as string values in the registry, making it possible 
        /// to "remember" the user's login information for future sessions. If an error occurs while 
        /// writing to the registry, an error message is logged to the console, and the method returns <c>false</c>.
        /// </remarks>
        static public bool RememberUserNameAndPassword(string userName, string password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\Bank";

            try
            {
                // Store the username and password in the Windows Registry.
                Registry.SetValue(keyPath, "userName", userName, RegistryValueKind.String);
                Registry.SetValue(keyPath, "password", password, RegistryValueKind.String);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }


        /// <summary>
        /// Retrieves the stored username and password from the Windows Registry.
        /// </summary>
        /// <param name="userName">Reference to a string that will hold the retrieved username.</param>
        /// <param name="password">Reference to a string that will hold the retrieved password.</param>
        /// <returns>
        /// Returns <c>true</c> if both the username and password are successfully retrieved; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// The method checks the registry for stored credentials under the path "HKEY_CURRENT_USER\SOFTWARE\Bank". 
        /// If valid credentials are found, they are returned via the <paramref name="userName"/> and 
        /// <paramref name="password"/> parameters. If an error occurs during retrieval or the credentials 
        /// are missing, the method returns <c>false</c> and logs the error to the console.
        /// </remarks>
        static public bool GetStoredCredential(ref string userName, ref string password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\Bank";
            try
            {
                // Retrieve the stored username and password from the registry.
                userName = Registry.GetValue(keyPath, "userName", null) as string;
                password = Registry.GetValue(keyPath, "password", null) as string;

                // Return true if both username and password are non-empty, false otherwise.
                return (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }

        }

    }
}
