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

namespace Bank_Desktop.Login_Activities
{
    public partial class frmManageLoginActivites : Form
    {
        public frmManageLoginActivites()
        {
            InitializeComponent();
        }

        private async void frmManageLoginActivites_Load(object sender, EventArgs e)
        {
            try
            {
                // Fetch the list of login activities from the API asynchronously.
                List<clsLoginActivitiesDTO> LoginActivitesDTO = await clsLoginActivities.GetLoginActivities();

                // Create a DataTable to hold the login activity data.
                DataTable dtLoginActivites = new DataTable();
                dtLoginActivites.Columns.Add("ID", typeof(int));
                dtLoginActivites.Columns.Add("Date", typeof(DateTime));
                dtLoginActivites.Columns.Add("UserID", typeof(int));

                // Populate the DataTable with the fetched login activity data.
                foreach (var LoginActivity in LoginActivitesDTO)
                {
                    dtLoginActivites.Rows.Add(LoginActivity.ID, LoginActivity.Date, LoginActivity.UserID);
                }

                // Bind the DataTable to the DataGridView to display the login activities.
                dgvLoginActivites.DataSource = dtLoginActivites;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in fetching Login Activites: " + ex.Message);
            }
        }
    }
}
