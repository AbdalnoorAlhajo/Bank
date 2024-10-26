using Bank_Desktop_DataAccess;
using System.Net.Http;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Newtonsoft.Json;
using Bank_Desktop.Utilities;

namespace Bank_Desktop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("UserName/Password Field should not be empty", "Empty Filelds"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Disable button during login process
                btnLogin.Enabled = false;

                // Attempt to retrieve user information
                clsGlobal.GlobalUserDTO = await clsUsers.GetUser(txtUserName.Text, txtPassword.Text);
                btnLogin.Enabled = true;

                // Check if login was unsuccessful
                if (clsGlobal.GlobalUserDTO == null)
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Remember user credentials if "Remember Me" box is checked
                if (chRememberMe.Checked)
                    clsUtilities.RememberUserNameAndPassword(txtUserName.Text, txtPassword.Text);
                else
                    clsUtilities.RememberUserNameAndPassword("", "");

                

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error in Login: " + ex.Message);
            }


            // Notify user of successful login
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                //Load Login Activity if User logined in successfully
                clsLoginActivitiesDTO loginActivityDTO = await clsLoginActivities.AddNewLoginActivity(
                    new clsLoginActivitiesDTO(-1, DateTime.Now, clsGlobal.GlobalUserDTO.ID));
                    
            }
            catch( Exception ex )
            {
                Console.WriteLine("Error in adding Login activity: " + ex.Message);
            }

            // Open the main form and hide the login form
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            // Attempt to retrieve stored credentials if the user previously checked the "Remember Me" box
            if (clsUtilities.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                chRememberMe.Checked = true;
            }
            else
                chRememberMe.Checked = false;
        }
    }
}
