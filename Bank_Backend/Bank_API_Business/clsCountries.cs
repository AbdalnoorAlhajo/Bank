using Bank_API_Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_API_Business
{
    /// <summary>
    /// Represents Countries for handling operations related to countries.
    /// </summary>
    public class clsCountries
    {
        /// <summary>
        /// Retrieves a list of all countries from the database.
        /// </summary>
        /// <returns>A list of <see cref="clsCountriesDTO"/> representing all countries.</returns>
        static public List<clsCountriesDTO> GetAllCountries()
        {
            return clsCountriesDatabase.GetAllCountries();
        }
    }
}
