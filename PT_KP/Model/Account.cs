using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_KP.Model
{
    // Класс аккаунта пользователя
    public class Account
    {
        // Список всех аккаунтов
        private static List<Account> allAccounts = new List<Account>();

        public string Login { get; set; }

        public string Password { get; set; }

        public string FIO { get; set; }

        public decimal WalletBalance { get; set; } // Наличка

        public decimal CardBalance { get; set; } // Баланс карты

        public decimal Bonuses { get; set; }

        public decimal PurchasesValue { get; set; } // Сумма всех покупок

        public string Status { get; set; } // Статус покупателя (для скидок)

        // Ввод баланса
        public void AddToBalance(decimal walletBalance, decimal cardBalance)
        {
            if (walletBalance == 0)
                this.CardBalance += cardBalance;
            else if (cardBalance == 0)
                this.WalletBalance += walletBalance;
            else
            {
                this.CardBalance += cardBalance;
                this.WalletBalance += walletBalance;
            }
        }

        // Изменение данных аккаунта
        public void ChangeProfileData(string login, string password, string fio)
        {
            this.Login = login;
            this.Password = password;
            this.FIO = fio;
        }

        // Получение информации об аккаунте
        public string AccountInfo()
        {
            return string.Format("ФИО: {0}\nНаличка: {1}\nБаланс карты: {2}\nБонусы: {3}\nТип карты: {4}\nСумма покупок: {5}",
                this.FIO, this.WalletBalance, this.CardBalance, this.Bonuses, this.Status, this.PurchasesValue);
        }

        // Проверка баланса
        public bool IsValidBalance(decimal wallet, decimal card, decimal bonuses)
        {
            if (this.WalletBalance < wallet)
                return false;
            else if (this.CardBalance < card)
                return false;
            else if (this.Bonuses < bonuses)
                return false;
            else
                return true;
        }

        // Совершение покупки
        public void MakePay(decimal wallet, decimal card, decimal bonuses, decimal purchaseValue)
        {
            this.WalletBalance -= wallet;
            this.CardBalance -= card;
            this.Bonuses -= bonuses;

            this.PurchasesValue += purchaseValue;
            this.Bonuses += purchaseValue * (decimal)0.05; // Начисление бонусов в размере 5% от покупки

            if (this.PurchasesValue < 30000)
                this.Status = "Basic";
            else if (this.PurchasesValue < 75000)
                this.Status = "Bronze";
            else if (this.PurchasesValue < 125000)
                this.Status = "Silver";
            else if (this.PurchasesValue < 200000)
                this.Status = "Gold";
            else if (this.PurchasesValue >= 200000)
                this.Status = "Platinum";
        }

        // Статические методы

        // Добавление аккаунта
        public static void AddAccount(string login, string password, string fio)
        {
            Account account = allAccounts
                .Where(item => item.Login == login)
                .FirstOrDefault();

            if (account == null)
                allAccounts.Add(new Account(login, password, fio));
            else
                MessageBox.Show("Аккаунт с таким логином уже существует!");

        }

        // Получение экземпляра аккаунта
        public static Account GetAccount(string login, string password)
        {
            Account curAccount = allAccounts
                .Where(item => item.Login == login && item.Password == password)
                .FirstOrDefault();

            if (curAccount != null)
                return curAccount;
            else
                return null;
        }

        // Конструкторы
        public Account(string login, string password, string fio)
        {
            this.Login = login;
            this.Password = password;
            this.FIO = fio;
            this.WalletBalance = 0;
            this.CardBalance = 0;
            this.Bonuses = 0;
            this.Status = "Basic";
            this.PurchasesValue = 0;
        }

        public Account() 
        {
            this.Login = string.Empty;
            this.Password = string.Empty;
        }
    }
}
