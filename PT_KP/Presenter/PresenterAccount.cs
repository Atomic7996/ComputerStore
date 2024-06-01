using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PT_KP.Model;
using PT_KP.View;

namespace PT_KP.Presenter
{
    public class PresenterAccount
    {
        public IViewAccount view;
        public Account modelAccount;

        public PresenterAccount(IViewAccount view)
        {
            this.view = view;
            this.modelAccount = view.LoggedAccount;
        }

        public void Login(string login, string password)
        {
            this.modelAccount = Account.GetAccount(login, password);

            if (this.modelAccount != null)
            {
                this.view.LoggedAccount = this.modelAccount;
            }
        }

        public void AddAccount(string login, string password, string fio)
        {
            Account.AddAccount(login, password, fio);
        }

        public void AddToBalance(decimal wallet, decimal card)
        {
            this.modelAccount = view.LoggedAccount;
            this.modelAccount.AddToBalance(wallet, card);
            this.view.LoggedAccount = this.modelAccount;
        }

        public void ChangeProfileData(string login, string password, string fio)
        {
            this.modelAccount = view.LoggedAccount;
            this.modelAccount.ChangeProfileData(login, password, fio);
            this.view.LoggedAccount = this.modelAccount;
        }

        public bool IsValidBalance(decimal wallet, decimal card, decimal bonuses)
        {
            this.modelAccount = view.LoggedAccount;
            return this.modelAccount.IsValidBalance(wallet, card, bonuses);
        }

        public void MakePay(decimal wallet, decimal card, decimal bonuses, decimal purchaseValue)
        {
            this.modelAccount = view.LoggedAccount;
            this.modelAccount.MakePay(wallet, card, bonuses, purchaseValue);
        }

        public decimal GetBonuses()
        {
            this.modelAccount = view.LoggedAccount;
            return this.modelAccount.Bonuses;
        }
    }
}
