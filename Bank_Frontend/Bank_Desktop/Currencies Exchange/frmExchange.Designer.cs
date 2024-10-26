namespace Bank_Desktop.CurrenciesExchange
{
    partial class frmExchange
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
            cbBaseCode = new ComboBox();
            label1 = new Label();
            cbTargetCode = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtAmount = new TextBox();
            btnConvert = new Button();
            label4 = new Label();
            lbResult = new Label();
            lbCurrenciesExchange = new Label();
            SuspendLayout();
            // 
            // cbBaseCode
            // 
            cbBaseCode.BackColor = SystemColors.InactiveCaption;
            cbBaseCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBaseCode.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbBaseCode.FormattingEnabled = true;
            cbBaseCode.Location = new Point(147, 112);
            cbBaseCode.Name = "cbBaseCode";
            cbBaseCode.Size = new Size(151, 31);
            cbBaseCode.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 111);
            label1.Name = "label1";
            label1.Size = new Size(114, 28);
            label1.TabIndex = 4;
            label1.Text = "Base Code:";
            // 
            // cbTargetCode
            // 
            cbTargetCode.BackColor = SystemColors.InactiveCaption;
            cbTargetCode.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTargetCode.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTargetCode.FormattingEnabled = true;
            cbTargetCode.Location = new Point(570, 111);
            cbTargetCode.Name = "cbTargetCode";
            cbTargetCode.Size = new Size(151, 31);
            cbTargetCode.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(390, 110);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 7;
            label2.Text = "Target Code: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 181);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 9;
            label3.Text = "Amount: ";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(147, 181);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(151, 30);
            txtAmount.TabIndex = 10;
            txtAmount.KeyPress += txtAmount_KeyPress;
            // 
            // btnConvert
            // 
            btnConvert.BackColor = Color.SteelBlue;
            btnConvert.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvert.ForeColor = SystemColors.ActiveCaptionText;
            btnConvert.Location = new Point(332, 164);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(153, 65);
            btnConvert.TabIndex = 11;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(530, 183);
            label4.Name = "label4";
            label4.Size = new Size(81, 28);
            label4.TabIndex = 12;
            label4.Text = "Result: ";
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbResult.Location = new Point(608, 183);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(62, 28);
            lbResult.TabIndex = 13;
            lbResult.Text = "{????}";
            // 
            // lbCurrenciesExchange
            // 
            lbCurrenciesExchange.AutoSize = true;
            lbCurrenciesExchange.Font = new Font("Old English Text MT", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCurrenciesExchange.Location = new Point(195, 9);
            lbCurrenciesExchange.Name = "lbCurrenciesExchange";
            lbCurrenciesExchange.Size = new Size(446, 56);
            lbCurrenciesExchange.TabIndex = 14;
            lbCurrenciesExchange.Text = "Currencies Exchange";
            // 
            // frmExchange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 256);
            Controls.Add(lbCurrenciesExchange);
            Controls.Add(lbResult);
            Controls.Add(label4);
            Controls.Add(btnConvert);
            Controls.Add(txtAmount);
            Controls.Add(label3);
            Controls.Add(cbTargetCode);
            Controls.Add(label2);
            Controls.Add(cbBaseCode);
            Controls.Add(label1);
            Name = "frmExchange";
            Text = "frmExchange";
            Load += frmExchange_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbBaseCode;
        private Label label1;
        private ComboBox cbTargetCode;
        private Label label2;
        private Label label3;
        private TextBox txtAmount;
        private Button btnConvert;
        private Label label4;
        private Label lbResult;
        private Label lbCurrenciesExchange;
    }
}