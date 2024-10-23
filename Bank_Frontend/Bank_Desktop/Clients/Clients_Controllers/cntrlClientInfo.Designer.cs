namespace Bank_Desktop.Clients.Clients_Controllers
{
    partial class cntrlClientInfo
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
            linklbUpdateClient = new LinkLabel();
            lbPersonID = new Label();
            label4 = new Label();
            lbID = new Label();
            label6 = new Label();
            lbSavings = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // linklbUpdateClient
            // 
            linklbUpdateClient.AutoSize = true;
            linklbUpdateClient.Enabled = false;
            linklbUpdateClient.Location = new Point(397, 64);
            linklbUpdateClient.Name = "linklbUpdateClient";
            linklbUpdateClient.Size = new Size(100, 20);
            linklbUpdateClient.TabIndex = 38;
            linklbUpdateClient.TabStop = true;
            linklbUpdateClient.Text = "Update Client";
            linklbUpdateClient.LinkClicked += linklbUpdateClient_LinkClicked;
            // 
            // lbPersonID
            // 
            lbPersonID.AutoSize = true;
            lbPersonID.Font = new Font("Segoe UI", 12F);
            lbPersonID.Location = new Point(374, 9);
            lbPersonID.Name = "lbPersonID";
            lbPersonID.Size = new Size(51, 28);
            lbPersonID.TabIndex = 37;
            lbPersonID.Text = "{???}";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(251, 9);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 36;
            label4.Text = "PersonID:";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Segoe UI", 12F);
            lbID.Location = new Point(137, 9);
            lbID.Name = "lbID";
            lbID.Size = new Size(51, 28);
            lbID.TabIndex = 35;
            lbID.Text = "{???}";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 9);
            label6.Name = "label6";
            label6.Size = new Size(93, 28);
            label6.TabIndex = 34;
            label6.Text = "ClientID:";
            // 
            // lbSavings
            // 
            lbSavings.AutoSize = true;
            lbSavings.Font = new Font("Segoe UI", 12F);
            lbSavings.Location = new Point(137, 56);
            lbSavings.Name = "lbSavings";
            lbSavings.Size = new Size(51, 28);
            lbSavings.TabIndex = 31;
            lbSavings.Text = "{???}";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 56);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 30;
            label1.Text = "Savings:";
            // 
            // cntrlClientInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(linklbUpdateClient);
            Controls.Add(lbPersonID);
            Controls.Add(label4);
            Controls.Add(lbID);
            Controls.Add(label6);
            Controls.Add(lbSavings);
            Controls.Add(label1);
            Name = "cntrlClientInfo";
            Size = new Size(517, 107);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linklbUpdateClient;
        private Label lbPersonID;
        private Label label4;
        private Label lbID;
        private Label label6;

        private Label lbSavings;
        private Label label1;
    }
}
