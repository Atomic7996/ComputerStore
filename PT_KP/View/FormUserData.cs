using PT_KP.Model;
using PT_KP.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_KP.View
{
    public partial class FormUserData : Form, IViewAccount
    {
        private PresenterAccount presenterAccount;

        public Account LoggedAccount { get; set; }

        public FormUserData()
        {
            InitializeComponent();

            presenterAccount = new PresenterAccount(this);

            LoggedAccount = new Account();

            tbOldPassword.Visible = false;
            lOldPassword.Visible = false;
            lFIO.Visible = false;
            tbFIO.Visible = false;

            lTitle.Text = "Авторизация";
            this.Text = "Авторизация";
        }

        public FormUserData(Account logInAccount)
        {
            InitializeComponent();

            LoggedAccount = logInAccount;
            presenterAccount = new PresenterAccount(this);

            lTitle.Text = "Обновление данных";
            this.Text = "Обновление данных";
            btnLogin.Visible = false;
            btnRegister.Text = "Обновить данные";

            tbLogin.Text = LoggedAccount.Login;
            tbFIO.Text = LoggedAccount.FIO;
        }

        private void Login()
        {
            presenterAccount.Login(tbLogin.Text, tbPassword.Text);

            if (LoggedAccount.Login != string.Empty)
            {
                FormMain formMain = this.Owner as FormMain;

                if (formMain != null)
                {
                    formMain.LoggedAccount = LoggedAccount;
                }

                this.Close();
            }
            else
                MessageBox.Show("Неверный логин или пароль!");
        }

        private void Register()
        {
            presenterAccount.AddAccount(tbLogin.Text, tbPassword.Text, tbFIO.Text);

            MessageBox.Show("Аккаунт успешно создан!");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (LoggedAccount.Login == string.Empty)
            {
                lFIO.Visible = true;
                tbFIO.Visible = true;
                btnLogin.Visible = false;
                lTitle.Text = "Регистрация";
                this.Text = "Регистрация";

                if (tbFIO.Text != "")
                {
                    Register();
                    this.Close();
                }
            }
            else if (LoggedAccount.Password == tbOldPassword.Text)
            {
                FormProfile formProfile = this.Owner as FormProfile;
                formProfile.LoggedAccount = LoggedAccount;

                presenterAccount.ChangeProfileData(tbLogin.Text, tbPassword.Text, tbFIO.Text);

                MessageBox.Show("Данные обновлены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
                MessageBox.Show("Неверный старый пароль!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tbFIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar));
        }
    }
}
