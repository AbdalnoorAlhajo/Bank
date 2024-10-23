namespace Bank_Desktop.TranferLogs
{
    partial class frmShowAllTranferLogs
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
            lbTransferLogs = new Label();
            dgvTransferLogs = new DataGridView();
            txtSearch = new TextBox();
            cbFillterBy = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransferLogs).BeginInit();
            SuspendLayout();
            // 
            // lbTransferLogs
            // 
            lbTransferLogs.AutoSize = true;
            lbTransferLogs.Font = new Font("Old English Text MT", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbTransferLogs.Location = new Point(176, 9);
            lbTransferLogs.Name = "lbTransferLogs";
            lbTransferLogs.Size = new Size(327, 56);
            lbTransferLogs.TabIndex = 5;
            lbTransferLogs.Text = "Transfer Logs";
            // 
            // dgvTransferLogs
            // 
            dgvTransferLogs.AllowDrop = true;
            dgvTransferLogs.AllowUserToAddRows = false;
            dgvTransferLogs.AllowUserToDeleteRows = false;
            dgvTransferLogs.AllowUserToResizeColumns = false;
            dgvTransferLogs.AllowUserToResizeRows = false;
            dgvTransferLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTransferLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTransferLogs.BackgroundColor = SystemColors.ActiveBorder;
            dgvTransferLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransferLogs.Dock = DockStyle.Bottom;
            dgvTransferLogs.Location = new Point(0, 157);
            dgvTransferLogs.Name = "dgvTransferLogs";
            dgvTransferLogs.ReadOnly = true;
            dgvTransferLogs.RowHeadersWidth = 51;
            dgvTransferLogs.Size = new Size(687, 446);
            dgvTransferLogs.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.InactiveCaption;
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(319, 101);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(158, 30);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cbFillterBy
            // 
            cbFillterBy.BackColor = SystemColors.InactiveCaption;
            cbFillterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFillterBy.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFillterBy.FormattingEnabled = true;
            cbFillterBy.Items.AddRange(new object[] { "ClientID", "Type" });
            cbFillterBy.Location = new Point(130, 100);
            cbFillterBy.Name = "cbFillterBy";
            cbFillterBy.Size = new Size(151, 31);
            cbFillterBy.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 99);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 6;
            label1.Text = "Fillter by:";
            // 
            // frmShowAllTranferLogs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(687, 603);
            Controls.Add(txtSearch);
            Controls.Add(cbFillterBy);
            Controls.Add(label1);
            Controls.Add(lbTransferLogs);
            Controls.Add(dgvTransferLogs);
            Name = "frmShowAllTranferLogs";
            Text = "All Tranfer Logs";
            Load += frmShowAllTranferLogs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransferLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTransferLogs;
        private DataGridView dgvTransferLogs;
        private TextBox txtSearch;
        private ComboBox cbFillterBy;
        private Label label1;
    }
}