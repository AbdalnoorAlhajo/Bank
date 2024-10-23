namespace Bank_Desktop.Clients
{
    partial class frmDeleteClient
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
            label1 = new Label();
            btnClose = new Button();
            btnDelete = new Button();
            cntrlFindClientWithFillter1 = new Clients_Controllers.cntrlFindClientWithFillter();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 9);
            label1.Name = "label1";
            label1.Size = new Size(316, 50);
            label1.TabIndex = 3;
            label1.Text = "Delete Client";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(188, 329);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(187, 60);
            btnClose.TabIndex = 13;
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
            btnDelete.Location = new Point(404, 329);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(187, 60);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // cntrlFindClientWithFillter1
            // 
            cntrlFindClientWithFillter1.BackColor = SystemColors.ActiveCaption;
            cntrlFindClientWithFillter1.Location = new Point(36, 74);
            cntrlFindClientWithFillter1.Name = "cntrlFindClientWithFillter1";
            cntrlFindClientWithFillter1.Size = new Size(621, 242);
            cntrlFindClientWithFillter1.TabIndex = 14;
            cntrlFindClientWithFillter1.OnSearchClicked += cntrlFindClientWithFillter1_OnSearchClicked;
            // 
            // frmDeleteClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(682, 401);
            Controls.Add(cntrlFindClientWithFillter1);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Name = "frmDeleteClient";
            Text = "Delete Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnClose;
        private Button btnDelete;
        private Clients_Controllers.cntrlFindClientWithFillter cntrlFindClientWithFillter1;
    }
}