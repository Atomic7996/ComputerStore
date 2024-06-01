namespace PT_KP.View
{
    partial class FormPayment
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
            this.lLogin = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lBonuses = new System.Windows.Forms.Label();
            this.lMoneyRemain = new System.Windows.Forms.Label();
            this.tbBonuses = new System.Windows.Forms.TextBox();
            this.cbBonuses = new System.Windows.Forms.CheckBox();
            this.tbCard = new System.Windows.Forms.TextBox();
            this.cbCard = new System.Windows.Forms.CheckBox();
            this.tbWallet = new System.Windows.Forms.TextBox();
            this.cbWallet = new System.Windows.Forms.CheckBox();
            this.lTotalPrice = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lMessage = new System.Windows.Forms.Label();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lDiscount = new System.Windows.Forms.Label();
            this.lPrice = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Font = new System.Drawing.Font("Arial", 12F);
            this.lLogin.Location = new System.Drawing.Point(5, 39);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(119, 18);
            this.lLogin.TabIndex = 0;
            this.lLogin.Text = "Пользователь: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lBonuses);
            this.groupBox1.Controls.Add(this.lMoneyRemain);
            this.groupBox1.Controls.Add(this.tbBonuses);
            this.groupBox1.Controls.Add(this.cbBonuses);
            this.groupBox1.Controls.Add(this.tbCard);
            this.groupBox1.Controls.Add(this.cbCard);
            this.groupBox1.Controls.Add(this.tbWallet);
            this.groupBox1.Controls.Add(this.cbWallet);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 219);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Способы оплаты";
            // 
            // lBonuses
            // 
            this.lBonuses.AutoSize = true;
            this.lBonuses.Font = new System.Drawing.Font("Arial", 12F);
            this.lBonuses.Location = new System.Drawing.Point(4, 158);
            this.lBonuses.Name = "lBonuses";
            this.lBonuses.Size = new System.Drawing.Size(146, 18);
            this.lBonuses.TabIndex = 7;
            this.lBonuses.Text = "Доступно бонусов: ";
            // 
            // lMoneyRemain
            // 
            this.lMoneyRemain.AutoSize = true;
            this.lMoneyRemain.Font = new System.Drawing.Font("Arial", 14F);
            this.lMoneyRemain.Location = new System.Drawing.Point(4, 188);
            this.lMoneyRemain.Name = "lMoneyRemain";
            this.lMoneyRemain.Size = new System.Drawing.Size(90, 22);
            this.lMoneyRemain.TabIndex = 5;
            this.lMoneyRemain.Text = "Остаток: ";
            // 
            // tbBonuses
            // 
            this.tbBonuses.Font = new System.Drawing.Font("Arial", 12F);
            this.tbBonuses.Location = new System.Drawing.Point(125, 116);
            this.tbBonuses.Name = "tbBonuses";
            this.tbBonuses.Size = new System.Drawing.Size(150, 26);
            this.tbBonuses.TabIndex = 6;
            this.tbBonuses.TextChanged += new System.EventHandler(this.tbBonuses_TextChanged);
            this.tbBonuses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBonuses_KeyPress);
            // 
            // cbBonuses
            // 
            this.cbBonuses.AutoSize = true;
            this.cbBonuses.Font = new System.Drawing.Font("Arial", 12F);
            this.cbBonuses.Location = new System.Drawing.Point(7, 120);
            this.cbBonuses.Name = "cbBonuses";
            this.cbBonuses.Size = new System.Drawing.Size(98, 22);
            this.cbBonuses.TabIndex = 3;
            this.cbBonuses.Text = "Бонусами";
            this.cbBonuses.UseVisualStyleBackColor = true;
            this.cbBonuses.CheckedChanged += new System.EventHandler(this.cbBonuses_CheckedChanged);
            // 
            // tbCard
            // 
            this.tbCard.Font = new System.Drawing.Font("Arial", 12F);
            this.tbCard.Location = new System.Drawing.Point(125, 77);
            this.tbCard.Name = "tbCard";
            this.tbCard.Size = new System.Drawing.Size(150, 26);
            this.tbCard.TabIndex = 5;
            this.tbCard.TextChanged += new System.EventHandler(this.tbCard_TextChanged);
            this.tbCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCard_KeyPress);
            // 
            // cbCard
            // 
            this.cbCard.AutoSize = true;
            this.cbCard.Font = new System.Drawing.Font("Arial", 12F);
            this.cbCard.Location = new System.Drawing.Point(7, 79);
            this.cbCard.Name = "cbCard";
            this.cbCard.Size = new System.Drawing.Size(78, 22);
            this.cbCard.TabIndex = 3;
            this.cbCard.Text = "Картой";
            this.cbCard.UseVisualStyleBackColor = true;
            this.cbCard.CheckedChanged += new System.EventHandler(this.cbCard_CheckedChanged);
            // 
            // tbWallet
            // 
            this.tbWallet.Font = new System.Drawing.Font("Arial", 12F);
            this.tbWallet.Location = new System.Drawing.Point(125, 38);
            this.tbWallet.Name = "tbWallet";
            this.tbWallet.Size = new System.Drawing.Size(150, 26);
            this.tbWallet.TabIndex = 4;
            this.tbWallet.TextChanged += new System.EventHandler(this.tbWallet_TextChanged);
            this.tbWallet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbWallet_KeyPress);
            // 
            // cbWallet
            // 
            this.cbWallet.AutoSize = true;
            this.cbWallet.Font = new System.Drawing.Font("Arial", 12F);
            this.cbWallet.Location = new System.Drawing.Point(7, 40);
            this.cbWallet.Name = "cbWallet";
            this.cbWallet.Size = new System.Drawing.Size(95, 22);
            this.cbWallet.TabIndex = 2;
            this.cbWallet.Text = "Наличкой";
            this.cbWallet.UseVisualStyleBackColor = true;
            this.cbWallet.CheckedChanged += new System.EventHandler(this.cbWallet_CheckedChanged);
            // 
            // lTotalPrice
            // 
            this.lTotalPrice.AutoSize = true;
            this.lTotalPrice.Font = new System.Drawing.Font("Arial", 12F);
            this.lTotalPrice.Location = new System.Drawing.Point(5, 146);
            this.lTotalPrice.Name = "lTotalPrice";
            this.lTotalPrice.Size = new System.Drawing.Size(79, 18);
            this.lTotalPrice.TabIndex = 2;
            this.lTotalPrice.Text = "К оплате: ";
            // 
            // btnPay
            // 
            this.btnPay.Font = new System.Drawing.Font("Arial", 12F);
            this.btnPay.Location = new System.Drawing.Point(772, 354);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(250, 75);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Оплатить заказ";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Font = new System.Drawing.Font("Arial", 14F);
            this.lMessage.Location = new System.Drawing.Point(464, 250);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(113, 22);
            this.lMessage.TabIndex = 4;
            this.lMessage.Text = "Сообщение";
            // 
            // lbProducts
            // 
            this.lbProducts.Font = new System.Drawing.Font("Arial", 12F);
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 18;
            this.lbProducts.Location = new System.Drawing.Point(467, 44);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(555, 184);
            this.lbProducts.TabIndex = 5;
            // 
            // lDiscount
            // 
            this.lDiscount.AutoSize = true;
            this.lDiscount.Font = new System.Drawing.Font("Arial", 12F);
            this.lDiscount.Location = new System.Drawing.Point(5, 108);
            this.lDiscount.Name = "lDiscount";
            this.lDiscount.Size = new System.Drawing.Size(138, 18);
            this.lDiscount.TabIndex = 6;
            this.lDiscount.Text = "Скидка за статус: ";
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Font = new System.Drawing.Font("Arial", 12F);
            this.lPrice.Location = new System.Drawing.Point(5, 71);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(119, 18);
            this.lPrice.TabIndex = 7;
            this.lPrice.Text = "Цена товаров: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lLogin);
            this.groupBox2.Controls.Add(this.lPrice);
            this.groupBox2.Controls.Add(this.lTotalPrice);
            this.groupBox2.Controls.Add(this.lDiscount);
            this.groupBox2.Font = new System.Drawing.Font("Arial Black", 12F);
            this.groupBox2.Location = new System.Drawing.Point(11, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(401, 183);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дополнительная информация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label1.Location = new System.Drawing.Point(463, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Список товаров";
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbProducts);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оплата заказа";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbBonuses;
        private System.Windows.Forms.CheckBox cbCard;
        private System.Windows.Forms.CheckBox cbWallet;
        private System.Windows.Forms.Label lTotalPrice;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox tbBonuses;
        private System.Windows.Forms.TextBox tbCard;
        private System.Windows.Forms.TextBox tbWallet;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.Label lMoneyRemain;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Label lBonuses;
        private System.Windows.Forms.Label lDiscount;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}