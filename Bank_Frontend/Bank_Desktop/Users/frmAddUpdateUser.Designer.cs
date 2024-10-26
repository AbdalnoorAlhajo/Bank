namespace Bank_Desktop.Users
{
    partial class frmAddUpdateUser
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
            lbTitle = new Label();
            gbUserInfo = new GroupBox();
            txtPersonID = new TextBox();
            txtPermissions = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            lbID = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            gbUserInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(287, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(217, 50);
            lbTitle.TabIndex = 2;
            lbTitle.Text = "Add User";
            // 
            // gbUserInfo
            // 
            gbUserInfo.Controls.Add(txtPersonID);
            gbUserInfo.Controls.Add(txtPermissions);
            gbUserInfo.Controls.Add(txtPassword);
            gbUserInfo.Controls.Add(txtUserName);
            gbUserInfo.Controls.Add(label5);
            gbUserInfo.Controls.Add(label4);
            gbUserInfo.Controls.Add(lbID);
            gbUserInfo.Controls.Add(label6);
            gbUserInfo.Controls.Add(label3);
            gbUserInfo.Controls.Add(label2);
            gbUserInfo.Location = new Point(63, 74);
            gbUserInfo.Name = "gbUserInfo";
            gbUserInfo.Size = new Size(695, 153);
            gbUserInfo.TabIndex = 3;
            gbUserInfo.TabStop = false;
            gbUserInfo.Text = "User Info";
            // 
            // txtPersonID
            // 
            txtPersonID.BackColor = SystemColors.InactiveCaption;
            txtPersonID.Location = new Point(591, 88);
            txtPersonID.Name = "txtPersonID";
            txtPersonID.Size = new Size(70, 27);
            txtPersonID.TabIndex = 31;
            txtPersonID.TextChanged += txtPersonID_TextChanged;
            txtPersonID.KeyPress += txtPersonID_KeyPress;
            // 
            // txtPermissions
            // 
            txtPermissions.BackColor = SystemColors.InactiveCaption;
            txtPermissions.Location = new Point(350, 88);
            txtPermissions.Name = "txtPermissions";
            txtPermissions.Size = new Size(70, 27);
            txtPermissions.TabIndex = 30;
            txtPermissions.KeyPress += txtPermissions_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.InactiveCaption;
            txtPassword.Location = new Point(482, 38);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(145, 27);
            txtPassword.TabIndex = 29;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.InactiveCaption;
            txtUserName.Location = new Point(169, 39);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(149, 27);
            txtUserName.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(350, 38);
            label5.Name = "label5";
            label5.Size = new Size(106, 28);
            label5.TabIndex = 27;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(469, 87);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 26;
            label4.Text = "PersonID:";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Segoe UI", 12F);
            lbID.Location = new Point(95, 87);
            lbID.Name = "lbID";
            lbID.Size = new Size(51, 28);
            lbID.TabIndex = 25;
            lbID.Text = "{???}";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 87);
            label6.Name = "label6";
            label6.Size = new Size(38, 28);
            label6.TabIndex = 24;
            label6.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(201, 87);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 23;
            label3.Text = "Permissions:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 38);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 22;
            label2.Text = "UserName:";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(355, 249);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(187, 60);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(571, 249);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(187, 60);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmAddUpdateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(831, 336);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(gbUserInfo);
            Controls.Add(lbTitle);
            Name = "frmAddUpdateUser";
            Text = "Add User";
            Load += frmAddUpdateUser_Load;
            gbUserInfo.ResumeLayout(false);
            gbUserInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private GroupBox gbUserInfo;
        private Button btnClose;
        private Button btnSave;
        private TextBox txtPersonID;
        private TextBox txtPermissions;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label5;
        private Label label4;
        private Label lbID;
        private Label label6;
        private Label label3;
        private Label label2;
    }
}