namespace Bank_Desktop.Clients
{
    partial class frmFindClient
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
            cntrlFindClientWithFillter1 = new Clients_Controllers.cntrlFindClientWithFillter();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 9);
            label1.Name = "label1";
            label1.Size = new Size(262, 50);
            label1.TabIndex = 1;
            label1.Text = "Find Client";
            // 
            // cntrlFindClientWithFillter1
            // 
            cntrlFindClientWithFillter1.BackColor = SystemColors.ActiveCaption;
            cntrlFindClientWithFillter1.Location = new Point(12, 82);
            cntrlFindClientWithFillter1.Name = "cntrlFindClientWithFillter1";
            cntrlFindClientWithFillter1.Size = new Size(620, 248);
            cntrlFindClientWithFillter1.TabIndex = 2;
            // 
            // frmFindClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(635, 343);
            Controls.Add(cntrlFindClientWithFillter1);
            Controls.Add(label1);
            Name = "frmFindClient";
            Text = "Find Client";
            Load += frmFindClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Clients_Controllers.cntrlFindClientWithFillter cntrlFindClientWithFillter1;
    }
}