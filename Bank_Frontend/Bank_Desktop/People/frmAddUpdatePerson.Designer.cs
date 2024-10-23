namespace Bank_Desktop.Users
{
    partial class frmAddUpdatePerson
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
            btnClose = new Button();
            btnSave = new Button();
            gbPersonInfo = new GroupBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            dtpBirthOfDate = new DateTimePicker();
            cbGender = new ComboBox();
            txtPhone = new TextBox();
            txtSurName = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label10 = new Label();
            label12 = new Label();
            label7 = new Label();
            label9 = new Label();
            lbPersonID = new Label();
            label11 = new Label();
            label13 = new Label();
            cbCountries = new ComboBox();
            lbTitle = new Label();
            gbPersonInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(301, 379);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(187, 60);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(526, 379);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(187, 60);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // gbPersonInfo
            // 
            gbPersonInfo.Controls.Add(txtAddress);
            gbPersonInfo.Controls.Add(txtEmail);
            gbPersonInfo.Controls.Add(dtpBirthOfDate);
            gbPersonInfo.Controls.Add(cbGender);
            gbPersonInfo.Controls.Add(txtPhone);
            gbPersonInfo.Controls.Add(txtSurName);
            gbPersonInfo.Controls.Add(label2);
            gbPersonInfo.Controls.Add(txtName);
            gbPersonInfo.Controls.Add(label1);
            gbPersonInfo.Controls.Add(label8);
            gbPersonInfo.Controls.Add(label10);
            gbPersonInfo.Controls.Add(label12);
            gbPersonInfo.Controls.Add(label7);
            gbPersonInfo.Controls.Add(label9);
            gbPersonInfo.Controls.Add(lbPersonID);
            gbPersonInfo.Controls.Add(label11);
            gbPersonInfo.Controls.Add(label13);
            gbPersonInfo.Controls.Add(cbCountries);
            gbPersonInfo.Location = new Point(31, 74);
            gbPersonInfo.Name = "gbPersonInfo";
            gbPersonInfo.Size = new Size(711, 282);
            gbPersonInfo.TabIndex = 11;
            gbPersonInfo.TabStop = false;
            gbPersonInfo.Text = "Person Info";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(120, 218);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(557, 58);
            txtAddress.TabIndex = 56;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 175);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(161, 27);
            txtEmail.TabIndex = 55;
            // 
            // dtpBirthOfDate
            // 
            dtpBirthOfDate.Location = new Point(469, 173);
            dtpBirthOfDate.Name = "dtpBirthOfDate";
            dtpBirthOfDate.Size = new Size(208, 27);
            dtpBirthOfDate.TabIndex = 54;
            // 
            // cbGender
            // 
            cbGender.BackColor = SystemColors.InactiveCaption;
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(120, 85);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(161, 28);
            cbGender.TabIndex = 53;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(120, 126);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(161, 27);
            txtPhone.TabIndex = 52;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // txtSurName
            // 
            txtSurName.Location = new Point(460, 48);
            txtSurName.Name = "txtSurName";
            txtSurName.Size = new Size(174, 27);
            txtSurName.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(302, 46);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 50;
            label2.Text = "Surname:";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(161, 27);
            txtName.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 171);
            label1.Name = "label1";
            label1.Size = new Size(142, 28);
            label1.TabIndex = 47;
            label1.Text = "Birth of Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(302, 125);
            label8.Name = "label8";
            label8.Size = new Size(155, 28);
            label8.TabIndex = 45;
            label8.Text = "Country Name:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(19, 171);
            label10.Name = "label10";
            label10.Size = new Size(69, 28);
            label10.TabIndex = 43;
            label10.Text = "Email:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(19, 217);
            label12.Name = "label12";
            label12.Size = new Size(92, 28);
            label12.TabIndex = 41;
            label12.Text = "Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 85);
            label7.Name = "label7";
            label7.Size = new Size(86, 28);
            label7.TabIndex = 39;
            label7.Text = "Gender:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(19, 125);
            label9.Name = "label9";
            label9.Size = new Size(76, 28);
            label9.TabIndex = 37;
            label9.Text = "Phone:";
            // 
            // lbPersonID
            // 
            lbPersonID.AutoSize = true;
            lbPersonID.Font = new Font("Segoe UI", 12F);
            lbPersonID.Location = new Point(457, 85);
            lbPersonID.Name = "lbPersonID";
            lbPersonID.Size = new Size(51, 28);
            lbPersonID.TabIndex = 36;
            lbPersonID.Text = "{???}";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(302, 85);
            label11.Name = "label11";
            label11.Size = new Size(101, 28);
            label11.TabIndex = 35;
            label11.Text = "PersonID:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(22, 46);
            label13.Name = "label13";
            label13.Size = new Size(73, 28);
            label13.TabIndex = 33;
            label13.Text = "Name:";
            // 
            // cbCountries
            // 
            cbCountries.BackColor = SystemColors.InactiveCaption;
            cbCountries.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCountries.FormattingEnabled = true;
            cbCountries.Location = new Point(469, 129);
            cbCountries.Name = "cbCountries";
            cbCountries.Size = new Size(178, 28);
            cbCountries.TabIndex = 32;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(255, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(271, 50);
            lbTitle.TabIndex = 10;
            lbTitle.Text = "Add Person";
            // 
            // frmAddUpdatePerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(754, 449);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(gbPersonInfo);
            Controls.Add(lbTitle);
            Name = "frmAddUpdatePerson";
            Text = "frmAddUpdatePerson";
            Load += frmAddUpdatePerson_Load;
            gbPersonInfo.ResumeLayout(false);
            gbPersonInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnSave;
        private GroupBox gbPersonInfo;
        private ComboBox cbCountries;
        private Label lbTitle;
        private Label label1;
        private Label label8;
        private Label label10;
        private Label label12;
        private Label label7;
        private Label label9;
        private Label lbPersonID;
        private Label label11;
        private Label label13;
        private DateTimePicker dtpBirthOfDate;
        private ComboBox cbGender;
        private TextBox txtPhone;
        private TextBox txtSurName;
        private Label label2;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtEmail;
    }
}