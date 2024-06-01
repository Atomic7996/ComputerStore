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
    public partial class FormProfile : Form, IViewAccount
    {
        public Account LoggedAccount { get; set; }
        private PresenterAccount presenterAccount;

        public FormProfile()
        {
            InitializeComponent();            

            FormUserData formUserData = new FormUserData();
            formUserData.Show();

            this.Close();
        }

        public FormProfile(Account logInAccount)
        {
            InitializeComponent();

            LoggedAccount = logInAccount;
            presenterAccount = new PresenterAccount(this);

            UpdateData();
        }

        // Обновлнение данных аккаунта
        private void UpdateData()
        {
            lLogin.Text = string.Format("Здравствуйте, {0}!", LoggedAccount.Login);

            lFIO.Text = "ФИО: " + LoggedAccount.FIO;
            lWallet.Text = "Наличные: " + LoggedAccount.WalletBalance.ToString("0.00") + "₽";
            lCard.Text = "Карта: " + LoggedAccount.CardBalance.ToString("0.00") + "₽";
            lBonuses.Text = "Бонусы: " + LoggedAccount.Bonuses.ToString("0.00") + "₽";
            lStatus.Text = "Статус: " + LoggedAccount.Status;
            lPurchasesValue.Text = "Сумма покупок: " + LoggedAccount.PurchasesValue.ToString("0.00" + "₽");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormMain formMain = this.MdiParent as FormMain;

            if (formMain != null)
            {
                formMain.LoggedAccount = null;
                this.Close();
            }
        }

        private void btnUpdateBalance_Click(object sender, EventArgs e)
        {
            FormBalanceInput formBalanceInput = new FormBalanceInput(LoggedAccount);
            formBalanceInput.ShowDialog();

            UpdateData();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            FormUserData formUserData = new FormUserData(LoggedAccount);
            formUserData.Owner = this;
            formUserData.ShowDialog();

            UpdateData();
        }
    }
}
