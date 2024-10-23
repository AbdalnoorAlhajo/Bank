namespace Bank_Desktop.Clients
{
    partial class frmAddUpdateClient
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
            gbClientInfo = new GroupBox();
            txtPersonID = new TextBox();
            txtSavings = new TextBox();
            txtPassword = new TextBox();
            label5 = new Label();
            label4 = new Label();
            lbID = new Label();
            label6 = new Label();
            label3 = new Label();
            lbTitle = new Label();
            gbClientInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(232, 253);
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
            btnSave.Location = new Point(448, 253);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(187, 60);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // gbClientInfo
            // 
            gbClientInfo.Controls.Add(txtPersonID);
            gbClientInfo.Controls.Add(txtSavings);
            gbClientInfo.Controls.Add(txtPassword);
            gbClientInfo.Controls.Add(label5);
            gbClientInfo.Controls.Add(label4);
            gbClientInfo.Controls.Add(lbID);
            gbClientInfo.Controls.Add(label6);
            gbClientInfo.Controls.Add(label3);
            gbClientInfo.Location = new Point(52, 74);
            gbClientInfo.Name = "gbClientInfo";
            gbClientInfo.Size = new Size(599, 151);
            gbClientInfo.TabIndex = 11;
            gbClientInfo.TabStop = false;
            gbClientInfo.Text = "Client Info";
            // 
            // txtPersonID
            // 
            txtPersonID.BackColor = SystemColors.InactiveCaption;
            txtPersonID.Location = new Point(498, 92);
            txtPersonID.Name = "txtPersonID";
            txtPersonID.Size = new Size(70, 27);
            txtPersonID.TabIndex = 31;
            txtPersonID.KeyPress += txtPersonID_KeyPress;
            // 
            // txtSavings
            // 
            txtSavings.BackColor = SystemColors.InactiveCaption;
            txtSavings.Location = new Point(154, 91);
            txtSavings.Name = "txtSavings";
            txtSavings.Size = new Size(147, 27);
            txtSavings.TabIndex = 30;
            txtSavings.KeyPress += txtSavings_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.InactiveCaption;
            txtPassword.Location = new Point(424, 38);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(145, 27);
            txtPassword.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(292, 38);
            label5.Name = "label5";
            label5.Size = new Size(106, 28);
            label5.TabIndex = 27;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(376, 91);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 26;
            label4.Text = "PersonID:";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Segoe UI", 12F);
            lbID.Location = new Point(154, 38);
            lbID.Name = "lbID";
            lbID.Size = new Size(51, 28);
            lbID.TabIndex = 25;
            lbID.Text = "{???}";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 38);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 24;
            label6.Text = "Client ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 88);
            label3.Name = "label3";
            label3.Size = new Size(89, 28);
            label3.TabIndex = 23;
            label3.Text = "Savings:";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(246, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(253, 50);
            lbTitle.TabIndex = 10;
            lbTitle.Text = "Add Client";
            // 
            // frmAddUpdateClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(697, 337);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(gbClientInfo);
            Controls.Add(lbTitle);
            Name = "frmAddUpdateClient";
            Text = "Add Client";
            Load += frmAddUpdateClient_Load;
            gbClientInfo.ResumeLayout(false);
            gbClientInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnSave;
        private GroupBox gbClientInfo;
        private TextBox txtPersonID;
        private TextBox txtSavings;
        private TextBox txtPassword;
        private Label label5;
        private Label label4;
        private Label lbID;
        private Label label6;
        private Label label3;
        private Label lbTitle;
    }
}