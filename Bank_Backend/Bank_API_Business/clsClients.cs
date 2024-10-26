using Bank_API_Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bank_API_Business
{
    /// <summary>
    /// Represents the Clients in the banking system.
    /// Handles operations for managing Clients data.
    /// </summary>
    public class clsClients
    {
        /// <summary>
        /// Enumeration to define the mode for client operations, either AddNew or Update.
        /// </summary>
        public enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode;

        public int ID { get; set; }
        public decimal Savings { get; set; }
        public string Password { get; set; }
        public int PersonID { get; set; }

        /// <summary>
        /// Gets the Data Transfer Object (DTO) for the client, containing its data.
        /// </summary>
        public clsClientsDTO CDTO { get {return new clsClientsDTO(ID, Savings, Password, PersonID); } }

        public clsClients(clsClientsDTO clientDTO)
        {
            this.ID = -1;
            this.Savings = clientDTO.Savings;
            this.Password = clientDTO.Password;
            this.PersonID = clientDTO.PersonID;

            _Mode = enMode.AddNew;
        }

        clsClients(clsClientsDTO clientDTO, enMode Mode = enMode.Update)
        {
            this.ID = clientDTO.ID;
            this.Savings =  clientDTO.Savings;
            this.Password = clientDTO.Password;
            this.PersonID = clientDTO.PersonID;

            _Mode = Mode;
        }

        /// <summary>
        /// Retrieves all clients from the database.
        /// </summary>
        /// <returns>A list of all clients as <see cref="clsClientsDTO"/> objects.</returns>
        static public List<clsClientsDTO> GetAllClients()
        {
            return clsClientsDatabase.GetAllClients();
        }

        /// <summary>
        /// Finds a client by their unique identifier (ID).
        /// </summary>
        /// <param name="ID">The unique identifier of the client.</param>
        /// <returns>A <see cref="clsClients"/> object if found; otherwise, null.</returns>
        static public clsClients Find(int ID)
        {
            clsClientsDTO clientDTO = clsClientsDatabase.GetClientById(ID);

            if (clientDTO == null)
                return null;

            return new clsClients(clientDTO, enMode.Update);
        }

        /// <summary>
        /// Adds a new client to the database.
        /// </summary>
        /// <returns>True if the client was successfully added; otherwise, false.</returns>
        bool _AddNewClient()
        {
            ID = clsClientsDatabase.AddNewClient(CDTO);

            return (ID > 0);
        }

        /// <summary>
        /// Updates an existing client in the database.
        /// </summary>
        /// <returns>True if the client was successfully updated; otherwise, false.</returns>
        bool _UpdateClient()
        {
            return clsClientsDatabase.UpdateClient(CDTO);
        }

        /// <summary>
        /// Saves the Client to the database. Determines whether to add or update based on the current mode.
        /// </summary>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewClient())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateClient();

                default:
                    return false;
            }
        }

        /// <summary>
        /// Deletes a client from the database by their unique identifier (ID).
        /// </summary>
        /// <param name="ID">The unique identifier of the client to delete.</param>
        /// <returns>True if the client was successfully deleted; otherwise, false.</returns>
        static public bool DeleteClient(int ID)
        {
            return clsClientsDatabase.DeleteClient(ID);
        }
    }
}
