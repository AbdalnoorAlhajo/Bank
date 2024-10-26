namespace Bank_Desktop.Users.Users_Controllers
{
    partial class cntrlUserInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lbUserName = new Label();
            lbPersonID = new Label();
            label4 = new Label();
            lbID = new Label();
            label6 = new Label();
            linklbUpdateUser = new LinkLabel();
            lbPermissions = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 56);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 0;
            label1.Text = "UserName:";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 12F);
            lbUserName.Location = new Point(131, 56);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(51, 28);
            lbUserName.TabIndex = 1;
            lbUserName.Text = "{???}";
            // 
            // lbPersonID
            // 
            lbPersonID.AutoSize = true;
            lbPersonID.Font = new Font("Segoe UI", 12F);
            lbPersonID.Location = new Point(416, 56);
            lbPersonID.Name = "lbPersonID";
            lbPersonID.Size = new Size(51, 28);
            lbPersonID.TabIndex = 7;
            lbPersonID.Text = "{???}";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(293, 56);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 6;
            label4.Text = "PersonID:";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Segoe UI", 12F);
            lbID.Location = new Point(64, 9);
            lbID.Name = "lbID";
            lbID.Size = new Size(51, 28);
            lbID.TabIndex = 5;
            lbID.Text = "{???}";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 9);
            label6.Name = "label6";
            label6.Size = new Size(38, 28);
            label6.TabIndex = 4;
            label6.Text = "ID:";
            // 
            // linklbUpdateUser
            // 
            linklbUpdateUser.AutoSize = true;
            linklbUpdateUser.Enabled = false;
            linklbUpdateUser.Location = new Point(397, 17);
            linklbUpdateUser.Name = "linklbUpdateUser";
            linklbUpdateUser.Size = new Size(91, 20);
            linklbUpdateUser.TabIndex = 29;
            linklbUpdateUser.TabStop = true;
            linklbUpdateUser.Text = "Update User";
            linklbUpdateUser.LinkClicked += linklbUpdateUser_LinkClicked;
            // 
            // lbPermissions
            // 
            lbPermissions.AutoSize = true;
            lbPermissions.Font = new Font("Segoe UI", 12F);
            lbPermissions.Location = new Point(312, 10);
            lbPermissions.Name = "lbPermissions";
            lbPermissions.Size = new Size(51, 28);
            lbPermissions.TabIndex = 31;
            lbPermissions.Text = "{???}";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(168, 10);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 30;
            label3.Text = "Permissions:";
            // 
            // cntrlUserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(lbPermissions);
            Controls.Add(label3);
            Controls.Add(linklbUpdateUser);
            Controls.Add(lbPersonID);
            Controls.Add(label4);
            Controls.Add(lbID);
            Controls.Add(label6);
            Controls.Add(lbUserName);
            Controls.Add(label1);
            Name = "cntrlUserInfo";
            Size = new Size(515, 109);
            Load += cntrlUserInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbUserName;
        private Label lbPersonID;
        private Label label4;
        private Label lbID;
        private Label label6;
        private LinkLabel linklbUpdateUser;
        private Label lbPermissions;
        private Label label3;
    }
}
