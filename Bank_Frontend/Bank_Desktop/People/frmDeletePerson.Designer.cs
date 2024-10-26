namespace Bank_Desktop.People
{
    partial class frmDeletePerson
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
            btnDelete = new Button();
            label1 = new Label();
            cntrlFindPersonWithFillter1 = new People_Controllers.cntrlFindPersonWithFillter();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(200, 459);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(187, 60);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Lime;
            btnDelete.Enabled = false;
            btnDelete.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(441, 459);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(187, 60);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 9);
            label1.Name = "label1";
            label1.Size = new Size(334, 50);
            label1.TabIndex = 12;
            label1.Text = "Delete Person";
            // 
            // cntrlFindPersonWithFillter1
            // 
            cntrlFindPersonWithFillter1.BackColor = SystemColors.ActiveCaption;
            cntrlFindPersonWithFillter1.Location = new Point(12, 62);
            cntrlFindPersonWithFillter1.Name = "cntrlFindPersonWithFillter1";
            cntrlFindPersonWithFillter1.Size = new Size(689, 379);
            cntrlFindPersonWithFillter1.TabIndex = 16;
            cntrlFindPersonWithFillter1.OnSearchClicked += cntrlFindPersonWithFillter1_OnSearchClicked;
            // 
            // frmDeletePerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(708, 557);
            Controls.Add(cntrlFindPersonWithFillter1);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Name = "frmDeletePerson";
            Text = "frmDeletePerson";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnDelete;
        private Label label1;
        private People_Controllers.cntrlFindPersonWithFillter cntrlFindPersonWithFillter1;
    }
}