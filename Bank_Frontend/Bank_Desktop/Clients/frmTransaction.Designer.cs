namespace Bank_Desktop.Clients
{
    partial class frmTransaction
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
            btnSave = new Button();
            gbTransactionInfo = new GroupBox();
            txtRecipientID = new TextBox();
            lbRecipientID = new Label();
            lbType = new Label();
            txtSenderID = new TextBox();
            txtAmount = new TextBox();
            label5 = new Label();
            lbSenderID = new Label();
            lbID = new Label();
            label6 = new Label();
            label2 = new Label();
            lbTitle = new Label();
            gbTransactionInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(307, 276);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(187, 60);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Lime;
            btnSave.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(523, 276);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(187, 60);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // gbTransactionInfo
            // 
            gbTransactionInfo.Controls.Add(txtRecipientID);
            gbTransactionInfo.Controls.Add(lbRecipientID);
            gbTransactionInfo.Controls.Add(lbType);
            gbTransactionInfo.Controls.Add(txtSenderID);
            gbTransactionInfo.Controls.Add(txtAmount);
            gbTransactionInfo.Controls.Add(label5);
            gbTransactionInfo.Controls.Add(lbSenderID);
            gbTransactionInfo.Controls.Add(lbID);
            gbTransactionInfo.Controls.Add(label6);
            gbTransactionInfo.Controls.Add(label2);
            gbTransactionInfo.Location = new Point(46, 74);
            gbTransactionInfo.Name = "gbTransactionInfo";
            gbTransactionInfo.Size = new Size(718, 166);
            gbTransactionInfo.TabIndex = 11;
            gbTransactionInfo.TabStop = false;
            gbTransactionInfo.Text = "Transaction Info";
            // 
            // txtRecipientID
            // 
            txtRecipientID.BackColor = SystemColors.InactiveCaption;
            txtRecipientID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRecipientID.Location = new Point(448, 96);
            txtRecipientID.Name = "txtRecipientID";
            txtRecipientID.Size = new Size(70, 27);
            txtRecipientID.TabIndex = 34;
            txtRecipientID.Visible = false;
            // 
            // lbRecipientID
            // 
            lbRecipientID.AutoSize = true;
            lbRecipientID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRecipientID.Location = new Point(274, 92);
            lbRecipientID.Name = "lbRecipientID";
            lbRecipientID.Size = new Size(127, 28);
            lbRecipientID.TabIndex = 33;
            lbRecipientID.Text = "RecipientID:";
            lbRecipientID.Visible = false;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Segoe UI", 12F);
            lbType.Location = new Point(559, 35);
            lbType.Name = "lbType";
            lbType.Size = new Size(51, 28);
            lbType.TabIndex = 32;
            lbType.Text = "{???}";
            // 
            // txtSenderID
            // 
            txtSenderID.BackColor = SystemColors.InactiveCaption;
            txtSenderID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenderID.Location = new Point(144, 92);
            txtSenderID.Name = "txtSenderID";
            txtSenderID.Size = new Size(70, 27);
            txtSenderID.TabIndex = 31;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = SystemColors.InactiveCaption;
            txtAmount.Location = new Point(313, 39);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(149, 27);
            txtAmount.TabIndex = 28;
            txtAmount.KeyPress += txtAmount_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(491, 38);
            label5.Name = "label5";
            label5.Size = new Size(62, 28);
            label5.TabIndex = 27;
            label5.Text = "Type:";
            // 
            // lbSenderID
            // 
            lbSenderID.AutoSize = true;
            lbSenderID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSenderID.Location = new Point(19, 88);
            lbSenderID.Name = "lbSenderID";
            lbSenderID.Size = new Size(103, 28);
            lbSenderID.TabIndex = 26;
            lbSenderID.Text = "SenderID:";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Segoe UI", 12F);
            lbID.Location = new Point(80, 38);
            lbID.Name = "lbID";
            lbID.Size = new Size(51, 28);
            lbID.TabIndex = 25;
            lbID.Text = "{???}";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 38);
            label6.Name = "label6";
            label6.Size = new Size(38, 28);
            label6.TabIndex = 24;
            label6.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(178, 38);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 22;
            label2.Text = "Amount:";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(245, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(465, 50);
            lbTitle.TabIndex = 10;
            lbTitle.Text = "Transfer Operation";
            // 
            // frmTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 372);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(gbTransactionInfo);
            Controls.Add(lbTitle);
            Name = "frmTransaction";
            Text = "Transaction";
            Load += frmTransaction_Load;
            gbTransactionInfo.ResumeLayout(false);
            gbTransactionInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnSave;
        private GroupBox gbTransactionInfo;
        private TextBox txtSenderID;
        private TextBox txtAmount;
        private Label label5;
        private Label lbSenderID;
        private Label label6;
        private Label label2;
        private Label lbTitle;
        private Label lbType;
        private Label lbID;
        private TextBox txtRecipientID;
        private Label lbRecipientID;
    }
}