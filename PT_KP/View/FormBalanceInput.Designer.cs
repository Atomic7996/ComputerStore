namespace PT_KP.View
{
    partial class FormBalanceInput
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnterData = new System.Windows.Forms.Button();
            this.tbCard = new System.Windows.Forms.TextBox();
            this.tbWallet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(9, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(319, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Введите количество денег для пополнения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(59, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Карта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(53, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Наличка";
            // 
            // btnEnterData
            // 
            this.btnEnterData.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEnterData.Location = new System.Drawing.Point(93, 206);
            this.btnEnterData.Name = "btnEnterData";
            this.btnEnterData.Size = new System.Drawing.Size(133, 49);
            this.btnEnterData.TabIndex = 8;
            this.btnEnterData.Text = "Внести";
            this.btnEnterData.UseVisualStyleBackColor = true;
            this.btnEnterData.Click += new System.EventHandler(this.btnEnterData_Click);
            // 
            // tbCard
            // 
            this.tbCard.Font = new System.Drawing.Font("Arial", 12F);
            this.tbCard.Location = new System.Drawing.Point(56, 157);
            this.tbCard.Name = "tbCard";
            this.tbCard.Size = new System.Drawing.Size(135, 26);
            this.tbCard.TabIndex = 7;
            this.tbCard.Text = "180000";
            this.tbCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCard_KeyPress);
            // 
            // tbWallet
            // 
            this.tbWallet.Font = new System.Drawing.Font("Arial", 12F);
            this.tbWallet.Location = new System.Drawing.Point(56, 91);
            this.tbWallet.Name = "tbWallet";
            this.tbWallet.Size = new System.Drawing.Size(135, 26);
            this.tbWallet.TabIndex = 6;
            this.tbWallet.Text = "50000";
            this.tbWallet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWallet_KeyPress);
            // 
            // FormBalanceInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnterData);
            this.Controls.Add(this.tbCard);
            this.Controls.Add(this.tbWallet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBalanceInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Внесение денег";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnterData;
        private System.Windows.Forms.TextBox tbCard;
        private System.Windows.Forms.TextBox tbWallet;
    }
}