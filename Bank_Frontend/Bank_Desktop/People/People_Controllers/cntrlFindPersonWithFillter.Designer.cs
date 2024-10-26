namespace Bank_Desktop.People.People_Controllers
{
    partial class cntrlFindPersonWithFillter
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
            gbPersonFillter = new GroupBox();
            txtSearch = new TextBox();
            pbSearch = new PictureBox();
            cbSearchFillter = new ComboBox();
            lbSearchBy = new Label();
            gbPersonInfo = new GroupBox();
            cntrlPersonInfo1 = new cntrlPersonInfo();
            gbPersonFillter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            gbPersonInfo.SuspendLayout();
            SuspendLayout();
            // 
            // gbPersonFillter
            // 
            gbPersonFillter.Controls.Add(txtSearch);
            gbPersonFillter.Controls.Add(pbSearch);
            gbPersonFillter.Controls.Add(cbSearchFillter);
            gbPersonFillter.Controls.Add(lbSearchBy);
            gbPersonFillter.Location = new Point(33, 3);
            gbPersonFillter.Name = "gbPersonFillter";
            gbPersonFillter.Size = new Size(607, 77);
            gbPersonFillter.TabIndex = 8;
            gbPersonFillter.TabStop = false;
            gbPersonFillter.Text = "Person Fillter";
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
            // cbSearchFillter
            // 
            cbSearchFillter.BackColor = SystemColors.InactiveCaption;
            cbSearchFillter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearchFillter.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSearchFillter.FormattingEnabled = true;
            cbSearchFillter.Location = new Point(124, 33);
            cbSearchFillter.Name = "cbSearchFillter";
            cbSearchFillter.Size = new Size(151, 31);
            cbSearchFillter.TabIndex = 1;
            cbSearchFillter.SelectedIndexChanged += cbSearchFillter_SelectedIndexChanged;
            // 
            // lbSearchBy
            // 
            lbSearchBy.AutoSize = true;
            lbSearchBy.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbSearchBy.Location = new Point(6, 32);
            lbSearchBy.Name = "lbSearchBy";
            lbSearchBy.Size = new Size(100, 28);
            lbSearchBy.TabIndex = 0;
            lbSearchBy.Text = "Fillter by:";
            // 
            // gbPersonInfo
            // 
            gbPersonInfo.Controls.Add(cntrlPersonInfo1);
            gbPersonInfo.Location = new Point(7, 88);
            gbPersonInfo.Name = "gbPersonInfo";
            gbPersonInfo.Size = new Size(670, 271);
            gbPersonInfo.TabIndex = 9;
            gbPersonInfo.TabStop = false;
            gbPersonInfo.Text = "Person Info";
            // 
            // cntrlPersonInfo1
            // 
            cntrlPersonInfo1.BackColor = SystemColors.ActiveCaption;
            cntrlPersonInfo1.Location = new Point(9, 26);
            cntrlPersonInfo1.Name = "cntrlPersonInfo1";
            cntrlPersonInfo1.Size = new Size(655, 233);
            cntrlPersonInfo1.TabIndex = 10;
            // 
            // cntrlFindPersonWithFillter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(gbPersonInfo);
            Controls.Add(gbPersonFillter);
            Name = "cntrlFindPersonWithFillter";
            Size = new Size(685, 370);
            Load += cntrlFindPersonWithFillter_Load;
            gbPersonFillter.ResumeLayout(false);
            gbPersonFillter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            gbPersonInfo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbPersonFillter;
        private TextBox txtSearch;
        private PictureBox pbSearch;
        private ComboBox cbSearchFillter;
        private Label lbSearchBy;
        private GroupBox gbPersonInfo;
        private cntrlPersonInfo cntrlPersonInfo1;
    }
}
