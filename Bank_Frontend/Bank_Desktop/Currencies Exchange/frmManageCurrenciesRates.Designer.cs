namespace Bank_Desktop.CurrenciesExchange
{
    partial class frmManageCurrenciesRates
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
            lbCurrenciesExchange = new Label();
            dgvCurrenciesExchange = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCurrenciesExchange).BeginInit();
            SuspendLayout();
            // 
            // lbCurrenciesExchange
            // 
            lbCurrenciesExchange.AutoSize = true;
            lbCurrenciesExchange.Font = new Font("Old English Text MT", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbCurrenciesExchange.Location = new Point(57, 9);
            lbCurrenciesExchange.Name = "lbCurrenciesExchange";
            lbCurrenciesExchange.Size = new Size(273, 40);
            lbCurrenciesExchange.TabIndex = 7;
            lbCurrenciesExchange.Text = "Currencies Rates";
            lbCurrenciesExchange.Click += lbCurrenciesExchange_Click;
            // 
            // dgvCurrenciesExchange
            // 
            dgvCurrenciesExchange.AllowDrop = true;
            dgvCurrenciesExchange.AllowUserToAddRows = false;
            dgvCurrenciesExchange.AllowUserToDeleteRows = false;
            dgvCurrenciesExchange.AllowUserToResizeColumns = false;
            dgvCurrenciesExchange.AllowUserToResizeRows = false;
            dgvCurrenciesExchange.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCurrenciesExchange.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCurrenciesExchange.BackgroundColor = SystemColors.ActiveBorder;
            dgvCurrenciesExchange.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurrenciesExchange.Dock = DockStyle.Bottom;
            dgvCurrenciesExchange.Location = new Point(0, 119);
            dgvCurrenciesExchange.Name = "dgvCurrenciesExchange";
            dgvCurrenciesExchange.ReadOnly = true;
            dgvCurrenciesExchange.RowHeadersWidth = 51;
            dgvCurrenciesExchange.Size = new Size(430, 446);
            dgvCurrenciesExchange.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 60);
            label1.Name = "label1";
            label1.Size = new Size(224, 38);
            label1.TabIndex = 8;
            label1.Text = "Base Code: USD";
            // 
            // frmManageCurrenciesRates
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(430, 565);
            Controls.Add(label1);
            Controls.Add(lbCurrenciesExchange);
            Controls.Add(dgvCurrenciesExchange);
            Name = "frmManageCurrenciesRates";
            Text = "frmManageCurrenciesExchange";
            Load += frmManageCurrenciesExchange_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCurrenciesExchange).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCurrenciesExchange;
        private DataGridView dgvCurrenciesExchange;
        private Label label1;
    }
}