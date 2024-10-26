using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Desktop.Users
{
    public partial class frmFindUser : Form
    {
        public frmFindUser()
        {
            InitializeComponent();
        }

        private Label label1;

        private void InitializeComponent()
        {
            label1 = new Label();
            cntrlFindUserWithFillter1 = new Users_Controllers.cntrlFindUserWithFillter();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 9);
            label1.Name = "label1";
            label1.Size = new Size(226, 50);
            label1.TabIndex = 0;
            label1.Text = "Find User";
            label1.Click += label1_Click;
            // 
            // cntrlFindUserWithFillter1
            // 
            cntrlFindUserWithFillter1.BackColor = SystemColors.ActiveCaption;
            cntrlFindUserWithFillter1.Location = new Point(23, 74);
            cntrlFindUserWithFillter1.Name = "cntrlFindUserWithFillter1";
            cntrlFindUserWithFillter1.Size = new Size(630, 235);
            cntrlFindUserWithFillter1.TabIndex = 1;
            // 
            // frmFindUser
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(675, 332);
            Controls.Add(cntrlFindUserWithFillter1);
            Controls.Add(label1);
            Name = "frmFindUser";
            Text = "Find User";
            Load += frmFindUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Users_Controllers.cntrlFindUserWithFillter cntrlFindUserWithFillter1;

        private void frmFindUser_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
