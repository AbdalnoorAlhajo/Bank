namespace Bank_Desktop.Clients
{
    partial class frmShowAllClients
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
            dgvClients = new DataGridView();
            lbClient = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Dock = DockStyle.Bottom;
            dgvClients.Location = new Point(0, 117);
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.RowHeadersWidth = 51;
            dgvClients.Size = new Size(629, 446);
            dgvClients.TabIndex = 0;
            // 
            // lbClient
            // 
            lbClient.AutoSize = true;
            lbClient.Font = new Font("Old English Text MT", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbClient.Location = new Point(234, 9);
            lbClient.Name = "lbClient";
            lbClient.Size = new Size(169, 56);
            lbClient.TabIndex = 1;
            lbClient.Text = "Clients";
            // 
            // frmShowAllClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(629, 563);
            Controls.Add(lbClient);
            Controls.Add(dgvClients);
            Name = "frmShowAllClients";
            Text = "ShowAllClients";
            Load += frmShowAllClients_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClients;
        private Label lbClient;
    }
}