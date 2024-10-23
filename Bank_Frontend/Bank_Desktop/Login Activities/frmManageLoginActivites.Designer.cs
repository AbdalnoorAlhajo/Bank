namespace Bank_Desktop.Login_Activities
{
    partial class frmManageLoginActivites
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
            lbLoginActivites = new Label();
            dgvLoginActivites = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLoginActivites).BeginInit();
            SuspendLayout();
            // 
            // lbLoginActivites
            // 
            lbLoginActivites.AutoSize = true;
            lbLoginActivites.Font = new Font("Old English Text MT", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbLoginActivites.Location = new Point(130, 9);
            lbLoginActivites.Name = "lbLoginActivites";
            lbLoginActivites.Size = new Size(333, 56);
            lbLoginActivites.TabIndex = 5;
            lbLoginActivites.Text = "Login Activites";
            // 
            // dgvLoginActivites
            // 
            dgvLoginActivites.AllowDrop = true;
            dgvLoginActivites.AllowUserToAddRows = false;
            dgvLoginActivites.AllowUserToDeleteRows = false;
            dgvLoginActivites.AllowUserToResizeColumns = false;
            dgvLoginActivites.AllowUserToResizeRows = false;
            dgvLoginActivites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLoginActivites.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLoginActivites.BackgroundColor = SystemColors.ActiveBorder;
            dgvLoginActivites.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoginActivites.Dock = DockStyle.Bottom;
            dgvLoginActivites.Location = new Point(0, 102);
            dgvLoginActivites.Name = "dgvLoginActivites";
            dgvLoginActivites.ReadOnly = true;
            dgvLoginActivites.RowHeadersWidth = 51;
            dgvLoginActivites.Size = new Size(605, 446);
            dgvLoginActivites.TabIndex = 4;
            // 
            // frmManageLoginActivites
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(605, 548);
            Controls.Add(lbLoginActivites);
            Controls.Add(dgvLoginActivites);
            Name = "frmManageLoginActivites";
            Text = "Login Activites";
            Load += frmManageLoginActivites_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoginActivites).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLoginActivites;
        private DataGridView dgvLoginActivites;
    }
}