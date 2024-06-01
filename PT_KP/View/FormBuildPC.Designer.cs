namespace PT_KP.View
{
    partial class FormBuildPC
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
            this.btnAddComputer = new System.Windows.Forms.Button();
            this.lbComputers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMotherboard = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCpu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGpu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddToShoppingCart = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddComputer
            // 
            this.btnAddComputer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddComputer.Location = new System.Drawing.Point(80, 210);
            this.btnAddComputer.Name = "btnAddComputer";
            this.btnAddComputer.Size = new System.Drawing.Size(250, 75);
            this.btnAddComputer.TabIndex = 1;
            this.btnAddComputer.Text = "Добавить сборку";
            this.btnAddComputer.UseVisualStyleBackColor = true;
            this.btnAddComputer.Click += new System.EventHandler(this.btnAddComputer_Click);
            // 
            // lbComputers
            // 
            this.lbComputers.Font = new System.Drawing.Font("Arial", 12F);
            this.lbComputers.FormattingEnabled = true;
            this.lbComputers.ItemHeight = 18;
            this.lbComputers.Location = new System.Drawing.Point(607, 47);
            this.lbComputers.Name = "lbComputers";
            this.lbComputers.Size = new System.Drawing.Size(415, 148);
            this.lbComputers.TabIndex = 17;
            this.lbComputers.SelectedIndexChanged += new System.EventHandler(this.lbComputers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название сборки";
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Arial", 12F);
            this.tbTitle.Location = new System.Drawing.Point(164, 39);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(400, 26);
            this.tbTitle.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Видеокарта";
            // 
            // cbMotherboard
            // 
            this.cbMotherboard.DropDownWidth = 300;
            this.cbMotherboard.Font = new System.Drawing.Font("Arial", 12F);
            this.cbMotherboard.FormattingEnabled = true;
            this.cbMotherboard.Location = new System.Drawing.Point(164, 81);
            this.cbMotherboard.Name = "cbMotherboard";
            this.cbMotherboard.Size = new System.Drawing.Size(400, 26);
            this.cbMotherboard.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Процессор";
            // 
            // cbCpu
            // 
            this.cbCpu.DropDownWidth = 300;
            this.cbCpu.Font = new System.Drawing.Font("Arial", 12F);
            this.cbCpu.FormattingEnabled = true;
            this.cbCpu.Location = new System.Drawing.Point(164, 125);
            this.cbCpu.Name = "cbCpu";
            this.cbCpu.Size = new System.Drawing.Size(400, 26);
            this.cbCpu.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Материнская плата";
            // 
            // cbGpu
            // 
            this.cbGpu.DropDownWidth = 300;
            this.cbGpu.Font = new System.Drawing.Font("Arial", 12F);
            this.cbGpu.FormattingEnabled = true;
            this.cbGpu.Location = new System.Drawing.Point(164, 166);
            this.cbGpu.Name = "cbGpu";
            this.cbGpu.Size = new System.Drawing.Size(400, 26);
            this.cbGpu.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label6.Location = new System.Drawing.Point(603, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Характеристики компьютера";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F);
            this.label5.Location = new System.Drawing.Point(603, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Список сборок";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTitle);
            this.groupBox1.Controls.Add(this.btnAddComputer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbMotherboard);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbCpu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbGpu);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 304);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор комплектующих";
            // 
            // btnAddToShoppingCart
            // 
            this.btnAddToShoppingCart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddToShoppingCart.Location = new System.Drawing.Point(92, 343);
            this.btnAddToShoppingCart.Name = "btnAddToShoppingCart";
            this.btnAddToShoppingCart.Size = new System.Drawing.Size(250, 75);
            this.btnAddToShoppingCart.TabIndex = 21;
            this.btnAddToShoppingCart.Text = "Добавить в корзину";
            this.btnAddToShoppingCart.UseVisualStyleBackColor = true;
            this.btnAddToShoppingCart.Click += new System.EventHandler(this.btnAddToShoppingCart_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Font = new System.Drawing.Font("Arial", 12F);
            this.rtbOutput.Location = new System.Drawing.Point(607, 249);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(415, 180);
            this.rtbOutput.TabIndex = 23;
            this.rtbOutput.Text = "";
            // 
            // FormBuildPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 441);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnAddToShoppingCart);
            this.Controls.Add(this.lbComputers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBuildPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сборка ПК";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddComputer;
        private System.Windows.Forms.ListBox lbComputers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMotherboard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCpu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGpu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddToShoppingCart;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}