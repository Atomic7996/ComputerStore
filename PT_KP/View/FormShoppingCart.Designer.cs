namespace PT_KP.View
{
    partial class FormShoppingCart
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
            this.lbCartItems = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lTotalPrice = new System.Windows.Forms.Label();
            this.lLoginToBuy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCartItems
            // 
            this.lbCartItems.Font = new System.Drawing.Font("Arial", 12F);
            this.lbCartItems.FormattingEnabled = true;
            this.lbCartItems.ItemHeight = 18;
            this.lbCartItems.Location = new System.Drawing.Point(16, 41);
            this.lbCartItems.Name = "lbCartItems";
            this.lbCartItems.Size = new System.Drawing.Size(555, 184);
            this.lbCartItems.TabIndex = 0;
            this.lbCartItems.SelectedIndexChanged += new System.EventHandler(this.lbCartItems_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбранные товары";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Arial", 12F);
            this.rtbDescription.Location = new System.Drawing.Point(602, 41);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(420, 184);
            this.rtbDescription.TabIndex = 3;
            this.rtbDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label2.Location = new System.Drawing.Point(598, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Описание товара";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Font = new System.Drawing.Font("Arial", 12F);
            this.btnRemoveItem.Location = new System.Drawing.Point(16, 354);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(175, 75);
            this.btnRemoveItem.TabIndex = 5;
            this.btnRemoveItem.Text = "Удалить товар";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Font = new System.Drawing.Font("Arial", 12F);
            this.btnClearCart.Location = new System.Drawing.Point(256, 354);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(175, 75);
            this.btnClearCart.TabIndex = 6;
            this.btnClearCart.Text = "Очистить корзину";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Enabled = false;
            this.btnPayment.Font = new System.Drawing.Font("Arial", 12F);
            this.btnPayment.Location = new System.Drawing.Point(772, 329);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(250, 100);
            this.btnPayment.TabIndex = 7;
            this.btnPayment.Text = "Перейти к оплате";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lTotalPrice
            // 
            this.lTotalPrice.AutoSize = true;
            this.lTotalPrice.Font = new System.Drawing.Font("Arial", 14F);
            this.lTotalPrice.Location = new System.Drawing.Point(598, 240);
            this.lTotalPrice.Name = "lTotalPrice";
            this.lTotalPrice.Size = new System.Drawing.Size(138, 22);
            this.lTotalPrice.TabIndex = 8;
            this.lTotalPrice.Text = "Итоговая цена";
            // 
            // lLoginToBuy
            // 
            this.lLoginToBuy.AutoSize = true;
            this.lLoginToBuy.Font = new System.Drawing.Font("Arial", 14F);
            this.lLoginToBuy.Location = new System.Drawing.Point(12, 240);
            this.lLoginToBuy.Name = "lLoginToBuy";
            this.lLoginToBuy.Size = new System.Drawing.Size(113, 22);
            this.lLoginToBuy.TabIndex = 9;
            this.lLoginToBuy.Text = "Сообщение";
            // 
            // FormShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 441);
            this.Controls.Add(this.lLoginToBuy);
            this.Controls.Add(this.lTotalPrice);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCartItems);
            this.Name = "FormShoppingCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Корзина";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCartItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lTotalPrice;
        private System.Windows.Forms.Label lLoginToBuy;
    }
}