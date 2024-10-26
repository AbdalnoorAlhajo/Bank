namespace Bank_Desktop.People
{
    partial class frmManagePeople
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
            lbPeople = new Label();
            dgvPeople = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            SuspendLayout();
            // 
            // lbPeople
            // 
            lbPeople.AutoSize = true;
            lbPeople.Font = new Font("Old English Text MT", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbPeople.Location = new Point(412, 9);
            lbPeople.Name = "lbPeople";
            lbPeople.Size = new Size(163, 56);
            lbPeople.TabIndex = 5;
            lbPeople.Text = "People";
            // 
            // dgvPeople
            // 
            dgvPeople.AllowDrop = true;
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dgvPeople.AllowUserToResizeColumns = false;
            dgvPeople.AllowUserToResizeRows = false;
            dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPeople.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPeople.BackgroundColor = SystemColors.ActiveBorder;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.Dock = DockStyle.Bottom;
            dgvPeople.Location = new Point(0, 106);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.ReadOnly = true;
            dgvPeople.RowHeadersWidth = 51;
            dgvPeople.Size = new Size(982, 446);
            dgvPeople.TabIndex = 4;
            // 
            // frmManagePeople
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(982, 552);
            Controls.Add(lbPeople);
            Controls.Add(dgvPeople);
            Name = "frmManagePeople";
            Text = "frmManagePeople";
            Load += frmManagePeople_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPeople;
        private DataGridView dgvPeople;
    }
}