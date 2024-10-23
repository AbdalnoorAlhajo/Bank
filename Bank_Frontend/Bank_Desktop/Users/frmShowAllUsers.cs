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
    public partial class frmShowAllUsers : Form
    {
        public frmShowAllUsers()
        {
            InitializeComponent();
        }

        private async void frmShowAllUsers_Load(object sender, EventArgs e)
        {
            try
            {
                // Asynchronously fetch all users from the server.
                List<clsUsersDTO> usersDTOs = await clsUsers.GetAllUsers();

                // Create a new DataTable to store users information for display.
                DataTable dtUsers = new DataTable();
                dtUsers.Columns.Add("ID", typeof(int));
                dtUsers.Columns.Add("UserName", typeof(string));
                dtUsers.Columns.Add("Permissions", typeof(string));
                dtUsers.Columns.Add("PersonID", typeof(int));

                // fill data table with users
                foreach (var user in usersDTOs)
                {
                    dtUsers.Rows.Add(user.ID, user.UserName, user.Permissions, user.PersonID);
                }

                // Bind the DataTable to the DataGridView to display all users.
                dgvUsers.DataSource = dtUsers;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in fetching Users: " + ex.Message);
            }
        }
    }
}
