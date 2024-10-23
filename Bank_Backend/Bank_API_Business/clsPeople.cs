using Bank_API_Database;
using Microsoft.VisualBasic;

namespace Bank_API_Business
{
    /// <summary>
    /// Represents a person in the banking system, including details such as name, contact info, and address.
    /// Handles operations for managing people's records.
    /// </summary>
    public class clsPeople
    {
        /// <summary>
        /// Enumeration to specify whether a person is being added (AddNew) or updated (Update).
        /// </summary>
        public enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string CountryName { get; set; }

        /// <summary>
        /// Gets the Data Transfer Object (DTO) for the person, containing all the person's details.
        /// </summary>
        public clsPeopleDTO PDTO 
        { 
            get { return new clsPeopleDTO(Id, Name, Surname, Gender, Phone, Email, Address, BirthDate, CountryName);} 
        }

        public clsPeople(clsPeopleDTO personDTO)
        {
            Name = personDTO.Name;
            Surname = personDTO.Surname;
            Gender = personDTO.Gender;
            Phone = personDTO.Phone;
            Email = personDTO.Email;
            Address = personDTO.Address;
            BirthDate = personDTO.BirthDate;
            CountryName = personDTO.CountryName;

            _Mode = enMode.AddNew;
        }

        clsPeople(clsPeopleDTO personDTO, enMode Mode = enMode.AddNew)
        {
            Id = personDTO.Id;
            Name = personDTO.Name;
            Surname = personDTO.Surname;
            Gender = personDTO.Gender;
            Phone = personDTO.Phone;
            Email = personDTO.Email;
            Address = personDTO.Address;
            BirthDate = personDTO.BirthDate;
            CountryName = personDTO.CountryName;

            _Mode = Mode;
        }

        /// <summary>
        /// Retrieves all people from the database.
        /// </summary>
        /// <returns>A list of <see cref="clsPeopleDTO"/> representing all people.</returns>
        static public List<clsPeopleDTO> GetAllPeople()
        {
            return clsPeopleDatabase.GetAllPeople();
        }

        /// <summary>
        /// Adds a new person to the database.
        /// </summary>
        /// <returns>True if the person is added successfully, otherwise false.</returns>
        bool _AddNewPerson()
        {
            Id = clsPeopleDatabase.AddNewPerson(PDTO);

            return (Id > 0);
        }

        /// <summary>
        /// Updates the person in the database.
        /// </summary>
        /// <returns>True if the person is updated successfully, otherwise false.</returns>
        bool _UpdatePerson()
        {
            return clsPeopleDatabase.UpdatePerson(PDTO);
        }

        /// <summary>
        /// Finds a person by their unique ID.
        /// </summary>
        /// <param name="ID">The unique identifier of the person.</param>
        /// <returns>A <see cref="clsPeople"/> object if the person is found, otherwise null.</returns>
        static public clsPeople Find(int ID)
        {
            clsPeopleDTO FoundPerson = clsPeopleDatabase.GetPersonByID(ID);

            return (FoundPerson != null) ? new clsPeople(FoundPerson, enMode.Update) : null;

        }

        /// <summary>
        /// Retrieves the country ID by the country name.
        /// </summary>
        /// <param name="countryName">The name of the country.</param>
        /// <returns>The unique ID of the country.</returns>
        static public int GetCountryIdByCountryName(string countryName)
        {
            return clsPeopleDatabase.GetCountryIdByCountryName(countryName);
        }

        /// <summary>
        /// Saves the person to the database. Determines whether to add or update based on the current mode.
        /// </summary>
        /// <returns>True if the operation is successful, otherwise false.</returns>
        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if(_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;
                    

                case enMode.Update:
                    return _UpdatePerson();

                default:
                    return false;
            }
        }

        /// <summary>
        /// Deletes a person from the database by their unique ID.
        /// </summary>
        /// <param name="ID">The unique identifier of the person to delete.</param>
        /// <returns>True if the person is deleted successfully, otherwise false.</returns>
        static public bool DeletePerson(int ID)
        {
            return clsPeopleDatabase.DeletePerson(ID);
        }
    }
}
