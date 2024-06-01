namespace PT_KP.View
{
    partial class FormUserData
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
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lFIO = new System.Windows.Forms.Label();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.lOldPassword = new System.Windows.Forms.Label();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Arial", 12F);
            this.tbLogin.Location = new System.Drawing.Point(19, 77);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(300, 26);
            this.tbLogin.TabIndex = 0;
            this.tbLogin.Text = "admin";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Arial", 12F);
            this.tbPassword.Location = new System.Drawing.Point(19, 146);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(300, 26);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Text = "admin";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F);
            this.btnLogin.Location = new System.Drawing.Point(12, 334);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 50);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(16, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Arial Black", 20F);
            this.lTitle.Location = new System.Drawing.Point(12, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(215, 38);
            this.lTitle.TabIndex = 5;
            this.lTitle.Text = "Авторизация";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Arial", 12F);
            this.btnRegister.Location = new System.Drawing.Point(257, 334);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(150, 50);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lFIO
            // 
            this.lFIO.AutoSize = true;
            this.lFIO.Font = new System.Drawing.Font("Arial", 12F);
            this.lFIO.Location = new System.Drawing.Point(16, 186);
            this.lFIO.Name = "lFIO";
            this.lFIO.Size = new System.Drawing.Size(43, 18);
            this.lFIO.TabIndex = 15;
            this.lFIO.Text = "ФИО";
            // 
            // tbFIO
            // 
            this.tbFIO.Font = new System.Drawing.Font("Arial", 12F);
            this.tbFIO.Location = new System.Drawing.Point(19, 207);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(300, 26);
            this.tbFIO.TabIndex = 14;
            this.tbFIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFIO_KeyPress);
            // 
            // lOldPassword
            // 
            this.lOldPassword.AutoSize = true;
            this.lOldPassword.Font = new System.Drawing.Font("Arial", 12F);
            this.lOldPassword.Location = new System.Drawing.Point(16, 258);
            this.lOldPassword.Name = "lOldPassword";
            this.lOldPassword.Size = new System.Drawing.Size(360, 18);
            this.lOldPassword.TabIndex = 17;
            this.lOldPassword.Text = "Введите старый пароль для обновления данных";
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.Font = new System.Drawing.Font("Arial", 12F);
            this.tbOldPassword.Location = new System.Drawing.Point(19, 279);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.PasswordChar = '*';
            this.tbOldPassword.Size = new System.Drawing.Size(300, 26);
            this.tbOldPassword.TabIndex = 16;
            this.tbOldPassword.Text = "admin";
            // 
            // FormUserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 396);
            this.Controls.Add(this.lOldPassword);
            this.Controls.Add(this.tbOldPassword);
            this.Controls.Add(this.lFIO);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormUserData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lFIO;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.Label lOldPassword;
        private System.Windows.Forms.TextBox tbOldPassword;
    }
}