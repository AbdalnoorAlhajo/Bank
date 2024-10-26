using Bank_Desktop_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Desktop.People
{
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }

        private async void frmManagePeople_Load(object sender, EventArgs e)
        {
            try
            {
                // Asynchronously fetch the list of all people from the API
                List<clsPeopleDTO> peopleDTOs = await clsPeople.GetAllPeople();

                // Create a DataTable to hold the data for displaying people information
                DataTable dtPeople = new DataTable();
                dtPeople.Columns.Add("ID", typeof(int));
                dtPeople.Columns.Add("Name", typeof(string));
                dtPeople.Columns.Add("Surname", typeof(string));
                dtPeople.Columns.Add("Gender", typeof(string));
                dtPeople.Columns.Add("Phone", typeof(string));
                dtPeople.Columns.Add("Email", typeof(string));
                dtPeople.Columns.Add("Address", typeof(string));
                dtPeople.Columns.Add("BirthDate", typeof(DateTime));
                dtPeople.Columns.Add("CountryName", typeof(string));

                // Populate the DataTable with the list of people received from the API
                foreach (var person in peopleDTOs)
                {
                    dtPeople.Rows.Add(person.Id, person.Name, person.Surname, person.Gender, person.Phone
                        , person.Email, person.Address, person.BirthDate, person.CountryName);
                }

                // Bind the populated DataTable to the DataGridView for display
                dgvPeople.DataSource = dtPeople;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in fetching Users: " + ex.Message);
            }
        }
    }
}
