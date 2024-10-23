namespace Bank_Desktop.People
{
    partial class frmFindPerson
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
            cntrlFindPersonWithFillter1 = new People_Controllers.cntrlFindPersonWithFillter();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 9);
            label1.Name = "label1";
            label1.Size = new Size(280, 50);
            label1.TabIndex = 13;
            label1.Text = "Find Person";
            // 
            // cntrlFindPersonWithFillter1
            // 
            cntrlFindPersonWithFillter1.BackColor = SystemColors.ActiveCaption;
            cntrlFindPersonWithFillter1.Location = new Point(12, 84);
            cntrlFindPersonWithFillter1.Name = "cntrlFindPersonWithFillter1";
            cntrlFindPersonWithFillter1.Size = new Size(690, 368);
            cntrlFindPersonWithFillter1.TabIndex = 14;
            // 
            // frmFindPerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(705, 455);
            Controls.Add(cntrlFindPersonWithFillter1);
            Controls.Add(label1);
            Name = "frmFindPerson";
            Text = "frmFindPerson";
            Load += frmFindPerson_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private People_Controllers.cntrlFindPersonWithFillter cntrlFindPersonWithFillter1;
    }
}