namespace PT_KP.View
{
    partial class FormCatalog
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
            this.btnAddToShoppingCart = new System.Windows.Forms.Button();
            this.lbComputers = new System.Windows.Forms.ListBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddToShoppingCart
            // 
            this.btnAddToShoppingCart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddToShoppingCart.Location = new System.Drawing.Point(772, 254);
            this.btnAddToShoppingCart.Name = "btnAddToShoppingCart";
            this.btnAddToShoppingCart.Size = new System.Drawing.Size(250, 75);
            this.btnAddToShoppingCart.TabIndex = 26;
            this.btnAddToShoppingCart.Text = "Добавить в корзину";
            this.btnAddToShoppingCart.UseVisualStyleBackColor = true;
            this.btnAddToShoppingCart.Click += new System.EventHandler(this.btnAddToShoppingCart_Click);
            // 
            // lbComputers
            // 
            this.lbComputers.Font = new System.Drawing.Font("Arial", 12F);
            this.lbComputers.FormattingEnabled = true;
            this.lbComputers.ItemHeight = 18;
            this.lbComputers.Location = new System.Drawing.Point(16, 53);
            this.lbComputers.Name = "lbComputers";
            this.lbComputers.Size = new System.Drawing.Size(415, 220);
            this.lbComputers.TabIndex = 23;
            this.lbComputers.SelectedIndexChanged += new System.EventHandler(this.lbComputers_SelectedIndexChanged);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Font = new System.Drawing.Font("Arial", 12F);
            this.rtbOutput.Location = new System.Drawing.Point(591, 53);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(431, 180);
            this.rtbOutput.TabIndex = 22;
            this.rtbOutput.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label6.Location = new System.Drawing.Point(587, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Характеристики компьютера";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Каталог компьютеров";
            // 
            // FormCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 341);
            this.Controls.Add(this.btnAddToShoppingCart);
            this.Controls.Add(this.lbComputers);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "FormCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Каталог";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddToShoppingCart;
        private System.Windows.Forms.ListBox lbComputers;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}