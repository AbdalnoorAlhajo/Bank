namespace Bank_Desktop.Users
{
    partial class frmDeleteUser
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
            cntrlFindUserWithFillter1 = new Users_Controllers.cntrlFindUserWithFillter();
            label1 = new Label();
            btnClose = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // cntrlFindUserWithFillter1
            // 
            cntrlFindUserWithFillter1.BackColor = SystemColors.ActiveCaption;
            cntrlFindUserWithFillter1.Location = new Point(14, 74);
            cntrlFindUserWithFillter1.Name = "cntrlFindUserWithFillter1";
            cntrlFindUserWithFillter1.Size = new Size(630, 235);
            cntrlFindUserWithFillter1.TabIndex = 3;
            cntrlFindUserWithFillter1.OnSearchClicked += cntrlFindUserWithFillter1_OnSearchClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 9);
            label1.Name = "label1";
            label1.Size = new Size(280, 50);
            label1.TabIndex = 2;
            label1.Text = "Delete User";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(130, 315);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(187, 60);
            btnClose.TabIndex = 11;
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
            btnDelete.Location = new Point(346, 315);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(187, 60);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmDeleteUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(646, 401);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(cntrlFindUserWithFillter1);
            Controls.Add(label1);
            Name = "frmDeleteUser";
            Text = "Delete User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Users_Controllers.cntrlFindUserWithFillter cntrlFindUserWithFillter1;
        private Label label1;
        private Button btnClose;
        private Button btnDelete;
    }
}