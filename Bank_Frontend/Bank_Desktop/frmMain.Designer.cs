namespace Bank_Desktop
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            msMain = new MenuStrip();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            showAllPeopleToolStripMenuItem = new ToolStripMenuItem();
            findPersonToolStripMenuItem = new ToolStripMenuItem();
            addPersonToolStripMenuItem = new ToolStripMenuItem();
            deletePersonToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            showAllUsersToolStripMenuItem = new ToolStripMenuItem();
            findUserToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            deleteUserToolStripMenuItem = new ToolStripMenuItem();
            ClientsToolStripMenuItem = new ToolStripMenuItem();
            showAllClientsToolStripMenuItem = new ToolStripMenuItem();
            findClientToolStripMenuItem = new ToolStripMenuItem();
            addClientToolStripMenuItem = new ToolStripMenuItem();
            deleteClientToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            showAllTransferLogsToolStripMenuItem = new ToolStripMenuItem();
            addTransferLogToolStripMenuItem = new ToolStripMenuItem();
            withdrawalToolStripMenuItem = new ToolStripMenuItem();
            moneyTransferToolStripMenuItem = new ToolStripMenuItem();
            currencyExchangeToolStripMenuItem = new ToolStripMenuItem();
            showAllCurrenciesToolStripMenuItem = new ToolStripMenuItem();
            currencyConviertingToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            updateCurrentUserToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            loginActivitesToolStripMenuItem = new ToolStripMenuItem();
            showLoginActivitesToolStripMenuItem = new ToolStripMenuItem();
            msMain.SuspendLayout();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.BackColor = Color.Silver;
            msMain.ImageScalingSize = new Size(20, 20);
            msMain.Items.AddRange(new ToolStripItem[] { peopleToolStripMenuItem, usersToolStripMenuItem, ClientsToolStripMenuItem, transactionsToolStripMenuItem, currencyExchangeToolStripMenuItem, loginActivitesToolStripMenuItem, settingsToolStripMenuItem });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(1777, 46);
            msMain.TabIndex = 0;
            msMain.Text = "menuStrip1";
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showAllPeopleToolStripMenuItem, findPersonToolStripMenuItem, addPersonToolStripMenuItem, deletePersonToolStripMenuItem });
            peopleToolStripMenuItem.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(119, 42);
            peopleToolStripMenuItem.Text = "People";
            peopleToolStripMenuItem.Click += peopleToolStripMenuItem_Click;
            // 
            // showAllPeopleToolStripMenuItem
            // 
            showAllPeopleToolStripMenuItem.Name = "showAllPeopleToolStripMenuItem";
            showAllPeopleToolStripMenuItem.Size = new Size(320, 42);
            showAllPeopleToolStripMenuItem.Text = "Show All People";
            showAllPeopleToolStripMenuItem.Click += showAllPeopleToolStripMenuItem_Click;
            // 
            // findPersonToolStripMenuItem
            // 
            findPersonToolStripMenuItem.Name = "findPersonToolStripMenuItem";
            findPersonToolStripMenuItem.Size = new Size(320, 42);
            findPersonToolStripMenuItem.Text = "Find Person";
            findPersonToolStripMenuItem.Click += findPersonToolStripMenuItem_Click;
            // 
            // addPersonToolStripMenuItem
            // 
            addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            addPersonToolStripMenuItem.Size = new Size(320, 42);
            addPersonToolStripMenuItem.Text = "Add Person";
            addPersonToolStripMenuItem.Click += addPersonToolStripMenuItem_Click;
            // 
            // deletePersonToolStripMenuItem
            // 
            deletePersonToolStripMenuItem.Name = "deletePersonToolStripMenuItem";
            deletePersonToolStripMenuItem.Size = new Size(320, 42);
            deletePersonToolStripMenuItem.Text = "Delete Person";
            deletePersonToolStripMenuItem.Click += deletePersonToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showAllUsersToolStripMenuItem, findUserToolStripMenuItem, addUserToolStripMenuItem, deleteUserToolStripMenuItem });
            usersToolStripMenuItem.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(101, 42);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // showAllUsersToolStripMenuItem
            // 
            showAllUsersToolStripMenuItem.Name = "showAllUsersToolStripMenuItem";
            showAllUsersToolStripMenuItem.Size = new Size(302, 42);
            showAllUsersToolStripMenuItem.Text = "Show All Users";
            showAllUsersToolStripMenuItem.Click += showAllUsersToolStripMenuItem_Click;
            // 
            // findUserToolStripMenuItem
            // 
            findUserToolStripMenuItem.Name = "findUserToolStripMenuItem";
            findUserToolStripMenuItem.Size = new Size(302, 42);
            findUserToolStripMenuItem.Text = "Find User";
            findUserToolStripMenuItem.Click += findUserToolStripMenuItem_Click;
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(302, 42);
            addUserToolStripMenuItem.Text = "Add User";
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // deleteUserToolStripMenuItem
            // 
            deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            deleteUserToolStripMenuItem.Size = new Size(302, 42);
            deleteUserToolStripMenuItem.Text = "Delete User";
            deleteUserToolStripMenuItem.Click += deleteUserToolStripMenuItem_Click;
            // 
            // ClientsToolStripMenuItem
            // 
            ClientsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showAllClientsToolStripMenuItem, findClientToolStripMenuItem, addClientToolStripMenuItem, deleteClientToolStripMenuItem });
            ClientsToolStripMenuItem.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem";
            ClientsToolStripMenuItem.Size = new Size(122, 42);
            ClientsToolStripMenuItem.Text = "Clients";
            ClientsToolStripMenuItem.Click += ClientsToolStripMenuItem_Click;
            // 
            // showAllClientsToolStripMenuItem
            // 
            showAllClientsToolStripMenuItem.Name = "showAllClientsToolStripMenuItem";
            showAllClientsToolStripMenuItem.Size = new Size(323, 42);
            showAllClientsToolStripMenuItem.Text = "Show All Clients";
            showAllClientsToolStripMenuItem.Click += showAllClientsToolStripMenuItem_Click;
            // 
            // findClientToolStripMenuItem
            // 
            findClientToolStripMenuItem.Name = "findClientToolStripMenuItem";
            findClientToolStripMenuItem.Size = new Size(323, 42);
            findClientToolStripMenuItem.Text = "Find Client";
            findClientToolStripMenuItem.Click += findClientToolStripMenuItem_Click;
            // 
            // addClientToolStripMenuItem
            // 
            addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            addClientToolStripMenuItem.Size = new Size(323, 42);
            addClientToolStripMenuItem.Text = "Add Client";
            addClientToolStripMenuItem.Click += addClientToolStripMenuItem_Click;
            // 
            // deleteClientToolStripMenuItem
            // 
            deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            deleteClientToolStripMenuItem.Size = new Size(323, 42);
            deleteClientToolStripMenuItem.Text = "Delete Client";
            deleteClientToolStripMenuItem.Click += deleteClientToolStripMenuItem_Click;
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showAllTransferLogsToolStripMenuItem, addTransferLogToolStripMenuItem, withdrawalToolStripMenuItem, moneyTransferToolStripMenuItem });
            transactionsToolStripMenuItem.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(193, 42);
            transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // showAllTransferLogsToolStripMenuItem
            // 
            showAllTransferLogsToolStripMenuItem.Name = "showAllTransferLogsToolStripMenuItem";
            showAllTransferLogsToolStripMenuItem.Size = new Size(406, 42);
            showAllTransferLogsToolStripMenuItem.Text = "Show All Transfer Logs";
            showAllTransferLogsToolStripMenuItem.Click += showAllTransferLogsToolStripMenuItem_Click;
            // 
            // addTransferLogToolStripMenuItem
            // 
            addTransferLogToolStripMenuItem.Name = "addTransferLogToolStripMenuItem";
            addTransferLogToolStripMenuItem.Size = new Size(406, 42);
            addTransferLogToolStripMenuItem.Text = "Deposit";
            addTransferLogToolStripMenuItem.Click += addTransferLogToolStripMenuItem_Click;
            // 
            // withdrawalToolStripMenuItem
            // 
            withdrawalToolStripMenuItem.Name = "withdrawalToolStripMenuItem";
            withdrawalToolStripMenuItem.Size = new Size(406, 42);
            withdrawalToolStripMenuItem.Text = "Withdrawal";
            withdrawalToolStripMenuItem.Click += withdrawalToolStripMenuItem_Click;
            // 
            // moneyTransferToolStripMenuItem
            // 
            moneyTransferToolStripMenuItem.Name = "moneyTransferToolStripMenuItem";
            moneyTransferToolStripMenuItem.Size = new Size(406, 42);
            moneyTransferToolStripMenuItem.Text = "Money transfer";
            moneyTransferToolStripMenuItem.Click += moneyTransferToolStripMenuItem_Click;
            // 
            // currencyExchangeToolStripMenuItem
            // 
            currencyExchangeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showAllCurrenciesToolStripMenuItem, currencyConviertingToolStripMenuItem });
            currencyExchangeToolStripMenuItem.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            currencyExchangeToolStripMenuItem.Name = "currencyExchangeToolStripMenuItem";
            currencyExchangeToolStripMenuItem.Size = new Size(279, 42);
            currencyExchangeToolStripMenuItem.Text = "Currency Exchange";
            // 
            // showAllCurrenciesToolStripMenuItem
            // 
            showAllCurrenciesToolStripMenuItem.Name = "showAllCurrenciesToolStripMenuItem";
            showAllCurrenciesToolStripMenuItem.Size = new Size(386, 42);
            showAllCurrenciesToolStripMenuItem.Text = "Show All Currencies";
            showAllCurrenciesToolStripMenuItem.Click += showAllCurrenciesToolStripMenuItem_Click;
            // 
            // currencyConviertingToolStripMenuItem
            // 
            currencyConviertingToolStripMenuItem.Name = "currencyConviertingToolStripMenuItem";
            currencyConviertingToolStripMenuItem.Size = new Size(386, 42);
            currencyConviertingToolStripMenuItem.Text = "Currency Convierting";
            currencyConviertingToolStripMenuItem.Click += currencyConviertingToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { updateCurrentUserToolStripMenuItem, toolStripMenuItem1, logoutToolStripMenuItem });
            settingsToolStripMenuItem.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(138, 42);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // updateCurrentUserToolStripMenuItem
            // 
            updateCurrentUserToolStripMenuItem.Name = "updateCurrentUserToolStripMenuItem";
            updateCurrentUserToolStripMenuItem.Size = new Size(376, 42);
            updateCurrentUserToolStripMenuItem.Text = "Update Current User";
            updateCurrentUserToolStripMenuItem.Click += updateCurrentUserToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(373, 6);
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(376, 42);
            logoutToolStripMenuItem.Text = "Log-out";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // loginActivitesToolStripMenuItem
            // 
            loginActivitesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showLoginActivitesToolStripMenuItem });
            loginActivitesToolStripMenuItem.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginActivitesToolStripMenuItem.Name = "loginActivitesToolStripMenuItem";
            loginActivitesToolStripMenuItem.Size = new Size(225, 42);
            loginActivitesToolStripMenuItem.Text = "Login Activites";
            // 
            // showLoginActivitesToolStripMenuItem
            // 
            showLoginActivitesToolStripMenuItem.Name = "showLoginActivitesToolStripMenuItem";
            showLoginActivitesToolStripMenuItem.Size = new Size(382, 42);
            showLoginActivitesToolStripMenuItem.Text = "Show Login Activites";
            showLoginActivitesToolStripMenuItem.Click += showLoginActivitesToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = Properties.Resources.Login1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1777, 843);
            Controls.Add(msMain);
            DoubleBuffered = true;
            IsMdiContainer = true;
            MainMenuStrip = msMain;
            Name = "frmMain";
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMain;
        private ToolStripMenuItem ClientsToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem currencyExchangeToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem findUserToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ToolStripMenuItem updateCurrentUserToolStripMenuItem;
        private ToolStripMenuItem deleteUserToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private ToolStripMenuItem showAllPeopleToolStripMenuItem;
        private ToolStripMenuItem showAllUsersToolStripMenuItem;
        private ToolStripMenuItem showAllClientsToolStripMenuItem;
        private ToolStripMenuItem findPersonToolStripMenuItem;
        private ToolStripMenuItem addPersonToolStripMenuItem;
        private ToolStripMenuItem deletePersonToolStripMenuItem;
        private ToolStripMenuItem findClientToolStripMenuItem;
        private ToolStripMenuItem addClientToolStripMenuItem;
        private ToolStripMenuItem deleteClientToolStripMenuItem;
        private ToolStripMenuItem showAllTransferLogsToolStripMenuItem;
        private ToolStripMenuItem addTransferLogToolStripMenuItem;
        private ToolStripMenuItem withdrawalToolStripMenuItem;
        private ToolStripMenuItem moneyTransferToolStripMenuItem;
        private ToolStripMenuItem showAllCurrenciesToolStripMenuItem;
        private ToolStripMenuItem currencyConviertingToolStripMenuItem;
        private ToolStripMenuItem loginActivitesToolStripMenuItem;
        private ToolStripMenuItem showLoginActivitesToolStripMenuItem;
    }
}