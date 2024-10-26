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
    public partial class frmDeletePerson : Form
    {
        clsPeopleDTO _PersonDTO;
        public frmDeletePerson()
        {
            InitializeComponent();
        }

        private void cntrlFindPersonWithFillter1_OnSearchClicked(Bank_Desktop_DataAccess.clsPeopleDTO obj)
        {
            // If no person is found, disable the delete button.
            if (obj == null)
            {
                _PersonDTO = null;
                btnDelete.Enabled = false;
            }
            else
            {
                // If a person is found, enable the delete button and store the person data in _PersonDTO.
                _PersonDTO = obj;
                btnDelete.Enabled = true;
            }

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // If _PersonDTO is null, exit the method as there is no person to delete.
                if (_PersonDTO == null) 
                    return;

                // Disable the delete button to prevent multiple clicks.
                btnDelete.Enabled = false;

                bool IsPersonDeleted = await clsPeople.DeletePerson(_PersonDTO.Id);

                // Check if the person was deleted successfully.
                if (IsPersonDeleted)
                {
                    MessageBox.Show("Person Deleted Sueccessfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to delete Person(Internal problem)"
                        , "Undone", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnDelete.Enabled = true; // Re-enable the delete button for another attempt.
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error in Deleting Person: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
