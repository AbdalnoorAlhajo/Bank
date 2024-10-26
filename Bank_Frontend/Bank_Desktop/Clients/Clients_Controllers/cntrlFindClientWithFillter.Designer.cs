namespace Bank_Desktop.Clients.Clients_Controllers
{
    partial class cntrlFindClientWithFillter
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
            gbClientFillter = new GroupBox();
            txtSearch = new TextBox();
            pbSearch = new PictureBox();
            cbFillterBy = new ComboBox();
            label1 = new Label();
            gbClient = new GroupBox();
            cntrlClientInfo1 = new cntrlClientInfo();
            gbClientFillter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            gbClient.SuspendLayout();
            SuspendLayout();
            // 
            // gbClientFillter
            // 
            gbClientFillter.Controls.Add(txtSearch);
            gbClientFillter.Controls.Add(pbSearch);
            gbClientFillter.Controls.Add(cbFillterBy);
            gbClientFillter.Controls.Add(label1);
            gbClientFillter.Location = new Point(3, 3);
            gbClientFillter.Name = "gbClientFillter";
            gbClientFillter.Size = new Size(607, 78);
            gbClientFillter.TabIndex = 3;
            gbClientFillter.TabStop = false;
            gbClientFillter.Text = "Client Fillter";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.InactiveCaption;
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(313, 34);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(158, 30);
            txtSearch.TabIndex = 3;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // pbSearch
            // 
            pbSearch.Image = Properties.Resources.Person_Search;
            pbSearch.Location = new Point(525, 17);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(76, 55);
            pbSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pbSearch.TabIndex = 2;
            pbSearch.TabStop = false;
            pbSearch.Click += pbSearch_Click;
            // 
            // cbFillterBy
            // 
            cbFillterBy.BackColor = SystemColors.InactiveCaption;
            cbFillterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFillterBy.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFillterBy.FormattingEnabled = true;
            cbFillterBy.Location = new Point(139, 32);
            cbFillterBy.Name = "cbFillterBy";
            cbFillterBy.Size = new Size(151, 31);
            cbFillterBy.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 32);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 0;
            label1.Text = "Fillter by:";
            // 
            // gbClient
            // 
            gbClient.Controls.Add(cntrlClientInfo1);
            gbClient.Location = new Point(25, 98);
            gbClient.Name = "gbClient";
            gbClient.Size = new Size(570, 133);
            gbClient.TabIndex = 4;
            gbClient.TabStop = false;
            gbClient.Text = "Client Info";
            // 
            // cntrlClientInfo1
            // 
            cntrlClientInfo1.BackColor = SystemColors.ActiveCaption;
            cntrlClientInfo1.Location = new Point(20, 26);
            cntrlClientInfo1.Name = "cntrlClientInfo1";
            cntrlClientInfo1.Size = new Size(525, 94);
            cntrlClientInfo1.TabIndex = 5;
            // 
            // cntrlFindClientWithFillter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(gbClient);
            Controls.Add(gbClientFillter);
            Name = "cntrlFindClientWithFillter";
            Size = new Size(623, 236);
            Load += cntrlFindClientWithFillter_Load;
            gbClientFillter.ResumeLayout(false);
            gbClientFillter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            gbClient.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbClientFillter;
        private TextBox txtSearch;
        private PictureBox pbSearch;
        private ComboBox cbFillterBy;
        private Label label1;
        private GroupBox gbClient;
        private cntrlClientInfo cntrlClientInfo1;
    }
}
