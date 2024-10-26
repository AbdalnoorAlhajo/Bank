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

namespace Bank_Desktop.Users
{
    public partial class frmAddUpdatePerson : Form
    {
        // Delegate definition for passing back data when a person is added or updated.
        public delegate void DataBackEventHandler(object sender, clsPeopleDTO personDTO);

        // Event triggered when a person is added or updated, passing back the data.
        public event DataBackEventHandler DataBack;

        /// <summary>
        /// Holds the information about the person being added or updated.
        /// </summary>
        clsPeopleDTO _personDTO;

        /// <summary>
        /// Enum to define the form's mode (AddNew or Update).
        /// </summary>
        public enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        // Constructor used for adding a new person.
        public frmAddUpdatePerson()
        {
            InitializeComponent();
        }

        // Constructor used for updating an existing person.
        public frmAddUpdatePerson(clsPeopleDTO personDTO)
        {
            InitializeComponent();
            _personDTO = personDTO;
        }

        private async void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            // Load all countries into the country combo box.
            List<clsCountriesDTO> countriesDTOs = await clsCountries.GetAllCountries();
            foreach (var countryDTO in countriesDTOs)
            {
                cbCountries.Items.Add(countryDTO.CountryName);
            }

            // If _personDTO is not null, fill the form with the person's information.
            if (_personDTO != null)
                _FillInfo(_personDTO);
            else
            {
                // Set default values for gender and country selection.
                cbCountries.SelectedIndex = 0;
                cbGender.SelectedIndex = 0;
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and backspace.
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 8);
        }

        /// <summary>
        /// Asynchronously adds a new person to the system by calling the API.
        /// </summary>
        async void _AddNewPerson()
        {
            try
            {
                // Disaple Save button for waiting resopnse from API
                btnSave.Enabled = false;

                _personDTO = await clsPeople.AddNewPerson(_personDTO);
                if (_personDTO == null)
                {
                    MessageBox.Show("Failed to add Person", "Internal Error"
                             , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = true;
                    return;
                }

                MessageBox.Show("Person added Successfully", "Process Completed "
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

                lbPersonID.Text = _personDTO.Id.ToString();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error in Adding Person: " + ex.Message);
            }
        }


        /// <summary>
        /// Asynchronously updates the existing person data in the system by calling the API.
        /// </summary>
        async void _UpdatePerson()
        {
            try
            {
                // Set the ID from the label to ensure the person is updated correctly.
                _personDTO.Id = int.Parse(lbPersonID.Text);

                // Disaple Save button for waiting resopnse from API
                btnSave.Enabled = false;
                _personDTO = await clsPeople.UpdatePerson(_personDTO);
                if (_personDTO == null)
                {
                    MessageBox.Show("Failed to update Person", "Internal Error"
                             , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSave.Enabled = true;
                    return;
                }

                MessageBox.Show("Person updated Successfully", "Process Completed "
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error in updating Person: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if required fields are empty.
            if (string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtSurName.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtAddress.Text) )
            {
                MessageBox.Show("All Fileds Should be filled", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new clsPeopleDTO object with the entered data.
            _personDTO = new clsPeopleDTO(-1, txtName.Text, txtSurName.Text, cbGender.Text, txtPhone.Text
                    , txtEmail.Text, txtAddress.Text, dtpBirthOfDate.Value, cbCountries.Text);

            // Add or update the person based on the mode.
            if (_Mode == enMode.AddNew)
                _AddNewPerson();
            else
                _UpdatePerson();

            // Raise the DataBack event to pass the person data back to the calling form.
            DataBack?.Invoke(this, _personDTO);
        }

        /// <summary>
        /// Fills the form with the person's details for updating.
        /// </summary>
        void _FillInfo(clsPeopleDTO PersonDTO)
        {
            // Populate the form fields with the person's data.
            txtName.Text = PersonDTO.Name;
            txtSurName.Text = PersonDTO.Surname;
            txtPhone.Text = PersonDTO.Phone;
            txtEmail.Text = PersonDTO.Email;
            lbPersonID.Text = PersonDTO.Id.ToString();
            cbGender.Text = PersonDTO.Gender.ToString();
            cbCountries.Text = PersonDTO.CountryName;
            txtAddress.Text = PersonDTO.Address;
            dtpBirthOfDate.Value = PersonDTO.BirthDate;

            // Update the form title and mode for updating the person.
            lbTitle.Text = "Update Person";
            _Mode = enMode.Update;

        }
    }
}
