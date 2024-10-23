namespace Bank_Desktop.Users.Users_Controllers
{
    partial class cntrlFindUserWithFillter
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
            gbUserInfo = new GroupBox();
            cntrlUserInfo1 = new cntrlUserInfo();
            gbUserFillter = new GroupBox();
            txtSearch = new TextBox();
            pbSearch = new PictureBox();
            cbFillterBy = new ComboBox();
            label1 = new Label();
            gbUserInfo.SuspendLayout();
            gbUserFillter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            SuspendLayout();
            // 
            // gbUserInfo
            // 
            gbUserInfo.Controls.Add(cntrlUserInfo1);
            gbUserInfo.Location = new Point(3, 90);
            gbUserInfo.Name = "gbUserInfo";
            gbUserInfo.Size = new Size(610, 127);
            gbUserInfo.TabIndex = 0;
            gbUserInfo.TabStop = false;
            gbUserInfo.Text = "User Info";
            // 
            // cntrlUserInfo1
            // 
            cntrlUserInfo1.BackColor = SystemColors.ActiveCaption;
            cntrlUserInfo1.Location = new Point(6, 26);
            cntrlUserInfo1.Name = "cntrlUserInfo1";
            cntrlUserInfo1.Size = new Size(595, 93);
            cntrlUserInfo1.TabIndex = 0;
            // 
            // gbUserFillter
            // 
            gbUserFillter.Controls.Add(txtSearch);
            gbUserFillter.Controls.Add(pbSearch);
            gbUserFillter.Controls.Add(cbFillterBy);
            gbUserFillter.Controls.Add(label1);
            gbUserFillter.Location = new Point(3, 6);
            gbUserFillter.Name = "gbUserFillter";
            gbUserFillter.Size = new Size(607, 78);
            gbUserFillter.TabIndex = 1;
            gbUserFillter.TabStop = false;
            gbUserFillter.Text = "User Fillter";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.InactiveCaption;
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(313, 34);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(158, 30);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
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
            cbFillterBy.Location = new Point(124, 33);
            cbFillterBy.Name = "cbFillterBy";
            cbFillterBy.Size = new Size(151, 31);
            cbFillterBy.TabIndex = 1;
            cbFillterBy.SelectedIndexChanged += cbFillterBy_SelectedIndexChanged;
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
            // cntrlFindUserWithFillter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(gbUserFillter);
            Controls.Add(gbUserInfo);
            Name = "cntrlFindUserWithFillter";
            Size = new Size(619, 228);
            Load += cntrlFindUserWithFillter_Load;
            gbUserInfo.ResumeLayout(false);
            gbUserFillter.ResumeLayout(false);
            gbUserFillter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbUserInfo;
        private GroupBox gbUserFillter;
        private PictureBox pbSearch;
        private ComboBox cbFillterBy;
        private Label label1;
        private cntrlUserInfo cntrlUserInfo1;
        private TextBox txtSearch;
    }
}
