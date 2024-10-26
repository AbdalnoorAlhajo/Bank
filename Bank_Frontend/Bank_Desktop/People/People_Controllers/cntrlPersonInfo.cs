using Bank_Desktop.Users;
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

namespace Bank_Desktop.People.People_Controllers
{
    public partial class cntrlPersonInfo : UserControl
    {
        clsPeopleDTO _personDTO;
        public cntrlPersonInfo()
        {
            InitializeComponent();
        }

        private void cntrlPersonInfo_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Updates the person information displayed in the control with the provided person data.
        /// </summary>
        /// <param name="personDTO">The person data transfer object containing person information.</param>
        public void ChangeInfo(clsPeopleDTO personDTO)
        {
            // If the provided personDTO is null, exit the method
            if (personDTO == null)
                return;

            // Update the labels with person information
            lbPersonID.Text = personDTO.Id.ToString();
            lbFullName.Text = personDTO.FullName;
            lbEmail.Text = personDTO.Email;
            lbPhone.Text = personDTO.Phone;
            lbGender.Text = personDTO.Gender;
            lbCountryName.Text = personDTO.CountryName;
            lbAddress.Text = personDTO.Address;
            lbBirthOfDate.Text = personDTO.BirthDate.ToShortDateString();

            // Store the Person data transfer object for future reference
            _personDTO = personDTO;

            // Enable the update link if person information is valid
            linklbUpdatePerson.Enabled = true;
        }

        /// <summary>
        /// Clears the person information displayed in the control.
        /// This resets the labels to their default state.
        /// </summary>
        public void ClearInfo()
        {
            // Reset labels to default values
            lbPersonID.Text = "{???}";
            lbFullName.Text = "{???}";
            lbEmail.Text = "{???}";
            lbPhone.Text = "{???}";
            lbGender.Text = "{???}";
            lbCountryName.Text = "{???}";
            lbAddress.Text = "{???}";
            lbBirthOfDate.Text = "{???}";

            _personDTO = null;

            // Disable the person link as there is no person information to update
            linklbUpdatePerson.Enabled = false;
        }

        private void linklbUpdatePerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open a new form to update the person's information
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_personDTO);

            // Subscribe to the DataBack event to get the updated information
            frm.DataBack += UpdatePerson_DataBack;
            frm.ShowDialog();
            
            // To Update current Form affter we call changeInfo
            ChangeInfo(_personDTO);
        }

        private void UpdatePerson_DataBack(object sender, clsPeopleDTO peopleDTO)
        {
            // Update the private field with the new person data
            _personDTO = peopleDTO;
        }
    }
}
