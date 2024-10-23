namespace Bank_Desktop
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            txtUserName = new TextBox();
            lbUserName = new Label();
            lbPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnClose = new Button();
            chRememberMe = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Login1;
            pictureBox1.Location = new Point(71, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.WindowFrame;
            txtUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = SystemColors.HighlightText;
            txtUserName.Location = new Point(165, 216);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(194, 30);
            txtUserName.TabIndex = 1;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = SystemColors.ActiveBorder;
            lbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUserName.Location = new Point(12, 218);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(112, 28);
            lbUserName.TabIndex = 2;
            lbUserName.Text = "User Name:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.BackColor = SystemColors.ActiveBorder;
            lbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPassword.Location = new Point(12, 274);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(112, 28);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Password   :";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.WindowFrame;
            txtPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = SystemColors.HighlightText;
            txtPassword.Location = new Point(165, 272);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(194, 30);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Lime;
            btnLogin.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(88, 374);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(187, 60);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(88, 466);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(187, 60);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // chRememberMe
            // 
            chRememberMe.AutoSize = true;
            chRememberMe.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chRememberMe.ForeColor = SystemColors.ActiveCaption;
            chRememberMe.Location = new Point(97, 321);
            chRememberMe.Name = "chRememberMe";
            chRememberMe.Size = new Size(168, 27);
            chRememberMe.TabIndex = 8;
            chRememberMe.Text = "Remember Me";
            chRememberMe.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(385, 564);
            Controls.Add(chRememberMe);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(lbPassword);
            Controls.Add(txtPassword);
            Controls.Add(lbUserName);
            Controls.Add(txtUserName);
            Controls.Add(pictureBox1);
            Name = "frmLogin";
            Text = " Login";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUserName;
        private Label lbUserName;
        private Label lbPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnClose;
        private CheckBox chRememberMe;
    }
}
