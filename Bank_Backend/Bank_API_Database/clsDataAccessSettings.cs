using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_API_Database
{
    /// <summary>
    /// A static class that stores the database connection settings
    /// </summary>
    static public class clsDataAccessSettings
    {
        /// <summary>
        /// The connection string used to connect to the SQL Server database.
        /// </summary>
        static public string ConnectionString = "Server = .; DataBase = Bank; User Id = sa; password = sa123456;Encrypt=False;TrustServerCertificate=True;Connection Timeout=30;";
    }
}
