namespace PT_KP.View
{
    partial class FormProfile
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
            this.btnUpdateBalance = new System.Windows.Forms.Button();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lLogin = new System.Windows.Forms.Label();
            this.lFIO = new System.Windows.Forms.Label();
            this.lWallet = new System.Windows.Forms.Label();
            this.lCard = new System.Windows.Forms.Label();
            this.lBonuses = new System.Windows.Forms.Label();
            this.lStatus = new System.Windows.Forms.Label();
            this.lPurchasesValue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateBalance
            // 
            this.btnUpdateBalance.Font = new System.Drawing.Font("Arial", 12F);
            this.btnUpdateBalance.Location = new System.Drawing.Point(418, 146);
            this.btnUpdateBalance.Name = "btnUpdateBalance";
            this.btnUpdateBalance.Size = new System.Drawing.Size(200, 50);
            this.btnUpdateBalance.TabIndex = 1;
            this.btnUpdateBalance.Text = "Внести баланс";
            this.btnUpdateBalance.UseVisualStyleBackColor = true;
            this.btnUpdateBalance.Click += new System.EventHandler(this.btnUpdateBalance_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Font = new System.Drawing.Font("Arial", 12F);
            this.btnUpdateProfile.Location = new System.Drawing.Point(418, 69);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(200, 50);
            this.btnUpdateProfile.TabIndex = 2;
            this.btnUpdateProfile.Text = "Изменить профиль";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Arial", 12F);
            this.btnLogOut.Location = new System.Drawing.Point(418, 279);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(200, 50);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Сменить аккаунт";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Font = new System.Drawing.Font("Arial", 14F);
            this.lLogin.Location = new System.Drawing.Point(414, 12);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(121, 22);
            this.lLogin.TabIndex = 4;
            this.lLogin.Text = "Приветствие";
            // 
            // lFIO
            // 
            this.lFIO.AutoSize = true;
            this.lFIO.Font = new System.Drawing.Font("Arial", 12F);
            this.lFIO.Location = new System.Drawing.Point(6, 50);
            this.lFIO.Name = "lFIO";
            this.lFIO.Size = new System.Drawing.Size(51, 18);
            this.lFIO.TabIndex = 6;
            this.lFIO.Text = "ФИО: ";
            // 
            // lWallet
            // 
            this.lWallet.AutoSize = true;
            this.lWallet.Font = new System.Drawing.Font("Arial", 12F);
            this.lWallet.Location = new System.Drawing.Point(6, 89);
            this.lWallet.Name = "lWallet";
            this.lWallet.Size = new System.Drawing.Size(89, 18);
            this.lWallet.TabIndex = 7;
            this.lWallet.Text = "Наличные: ";
            // 
            // lCard
            // 
            this.lCard.AutoSize = true;
            this.lCard.Font = new System.Drawing.Font("Arial", 12F);
            this.lCard.Location = new System.Drawing.Point(6, 134);
            this.lCard.Name = "lCard";
            this.lCard.Size = new System.Drawing.Size(59, 18);
            this.lCard.TabIndex = 8;
            this.lCard.Text = "Карта: ";
            // 
            // lBonuses
            // 
            this.lBonuses.AutoSize = true;
            this.lBonuses.Font = new System.Drawing.Font("Arial", 12F);
            this.lBonuses.Location = new System.Drawing.Point(6, 175);
            this.lBonuses.Name = "lBonuses";
            this.lBonuses.Size = new System.Drawing.Size(71, 18);
            this.lBonuses.TabIndex = 9;
            this.lBonuses.Text = "Бонусы: ";
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font("Arial", 12F);
            this.lStatus.Location = new System.Drawing.Point(6, 221);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(66, 18);
            this.lStatus.TabIndex = 10;
            this.lStatus.Text = "Статус: ";
            // 
            // lPurchasesValue
            // 
            this.lPurchasesValue.AutoSize = true;
            this.lPurchasesValue.Font = new System.Drawing.Font("Arial", 12F);
            this.lPurchasesValue.Location = new System.Drawing.Point(6, 267);
            this.lPurchasesValue.Name = "lPurchasesValue";
            this.lPurchasesValue.Size = new System.Drawing.Size(125, 18);
            this.lPurchasesValue.TabIndex = 11;
            this.lPurchasesValue.Text = "Сумма покупок: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lFIO);
            this.groupBox1.Controls.Add(this.lPurchasesValue);
            this.groupBox1.Controls.Add(this.lWallet);
            this.groupBox1.Controls.Add(this.lStatus);
            this.groupBox1.Controls.Add(this.lCard);
            this.groupBox1.Controls.Add(this.lBonuses);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 317);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ваши данные";
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 341);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lLogin);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.btnUpdateBalance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Профиль";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateBalance;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lFIO;
        private System.Windows.Forms.Label lWallet;
        private System.Windows.Forms.Label lCard;
        private System.Windows.Forms.Label lBonuses;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Label lPurchasesValue;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}