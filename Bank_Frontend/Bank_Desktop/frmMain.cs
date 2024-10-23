using Bank_Desktop.Clients;
using Bank_Desktop.CurrenciesExchange;
using Bank_Desktop.Login_Activities;
using Bank_Desktop.People;
using Bank_Desktop.TranferLogs;
using Bank_Desktop.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Desktop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckAccessPermission(clsGlobal.enPermissions.pManageUsers))
            {
                frmFindUser frm = new frmFindUser();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have the Permissions to Find User", "Invalid Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckAccessPermission(clsGlobal.enPermissions.pManageUsers))
            {
                frmAddUpdateUser frm = new frmAddUpdateUser();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have the Permissions to Add User", "Invalid Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateCurrentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckAccessPermission(clsGlobal.enPermissions.pManageUsers))
            {
                frmAddUpdateUser frm = new frmAddUpdateUser(clsGlobal.GlobalUserDTO);
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have the Permissions to Update User", "Invalid Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckAccessPermission(clsGlobal.enPermissions.pManageUsers))
            {
                frmDeleteUser frm = new frmDeleteUser();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have the Permissions to Delete User", "Invalid Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showAllPeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckAccessPermission(clsGlobal.enPermissions.eAll))
            {
                frmManagePeople frm = new frmManagePeople();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have the Permissions to see all people", "Invalid Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showAllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckAccessPermission(clsGlobal.enPermissions.pManageUsers))
            {
                frmShowAllUsers frm = new frmShowAllUsers();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have the Permissions to See all Users", "Invalid Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showAllClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckAccessPermission(clsGlobal.enPermissions.pListClients))
            {
                frmShowAllClients frm = new frmShowAllClients();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have the Permissions to See all Clients", "Invalid Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckAccessPermission(clsGlobal.enPermissions.eAll))
            {
                frmFindPerson frm = new frmFindPerson();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have the Permissions to Find Person", "Invalid Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckAccessPermission(clsGlobal.enPermissions.eAll))
            {
                frmAddUpdatePerson frm = new frmAddUpdatePerson();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have the Permissions to Add Person", "Invalid Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckAccessPermission(clsGlobal.enPermissions.eAll))
            {
                frmDeletePerson frm = new frmDeletePerson();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have the Permissions to Delete Person", "Invalid Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckAccessPermission(clsGlobal.enPermissions.pFindClient))
            {
                frmFindClient frm = new frmFindClient();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have the Permissions to Find Client", "Invalid Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckAccessPermission(clsGlobal.enPermissions.pAddNewClient))
            {
                frmAddUpdateClient frm = new frmAddUpdateClient();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have the Permissions to add Client", "Invalid Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckAccessPermission(clsGlobal.enPermissions.pDeleteClient))
            {
                frmDeleteClient frm = new frmDeleteClient();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have the Permissions to delete Client", "Invalid Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showAllTransferLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckAccessPermission(clsGlobal.enPermissions.pTranactions))
            {
                frmShowAllTranferLogs frm = new frmShowAllTranferLogs();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have the Permissions to See All Tranfer Logs", "Invalid Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addTransferLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckAccessPermission(clsGlobal.enPermissions.pTranactions))
            {
                // 1 represets Deposit
                frmTransaction frm = new frmTransaction(1);
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have the Permissions to Deposit", "Invalid Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void withdrawalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckAccessPermission(clsGlobal.enPermissions.pTranactions))
            {
                // 2 represets Withdrawal
                frmTransaction frm = new frmTransaction(2);
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have the Permissions to Withdrawal", "Invalid Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void moneyTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckAccessPermission(clsGlobal.enPermissions.pTranactions))
            {
                // 3 represets MoneyTransfer
                frmTransaction frm = new frmTransaction(3);
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have the Permissions to Money Transfer", "Invalid Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showAllCurrenciesToolStripMenuItem_Click(object sender, EventArgs e)
        {


            frmManageCurrenciesRates frm = new frmManageCurrenciesRates();
            frm.MdiParent = this;
            frm.Show();

        }

        private void currencyConviertingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExchange frm = new frmExchange();
            frm.MdiParent = this;
            frm.Show();

        }

        private void showLoginActivitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckAccessPermission(clsGlobal.enPermissions.pManageUsers))
            {
                frmManageLoginActivites frm = new frmManageLoginActivites();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have the Permissions to See all Login Activites", "Invalid Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
