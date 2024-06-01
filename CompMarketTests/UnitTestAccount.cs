using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PT_KP.Model;
using PT_KP.Presenter;

namespace CompMarketTests
{
    [TestClass]
    public class UnitTestAccount
    {
        [TestMethod]
        public void TestAddAccount()
        {
            string login = "sashaBelyakov02";
            string password = "admin";
            string fio = "Беляков Александр Алексеевич";

            Account.AddAccount(login, password, fio);

            Account account = Account.GetAccount(login, password);

            account.Login = "dDWDDW";

            Assert.AreEqual(login, account.Login, "Логин не совпал");
            Assert.AreEqual(fio, account.FIO, "ФИО не совпало");
        }

        [TestMethod]
        public void TestAddToBalance()
        {
            string login = "sashaBelyakov02";
            string password = "admin";
            string fio = "Беляков Александр Алексеевич";

            Account.AddAccount(login, password, fio);
            Account account = Account.GetAccount(login, password);
            account.WalletBalance = 3500;
            account.CardBalance = 12000;

            decimal wallet = 5000;
            decimal card = 4128;

            decimal exeptedWallet = 8500;
            decimal expectedCard = 16128;

            account.AddToBalance(wallet, card);

            Assert.AreEqual(exeptedWallet, account.WalletBalance, "Налчиные не совпали");
            Assert.AreEqual(expectedCard, account.CardBalance, "Баланс карты не совпал");
        }

        [TestMethod]
        public void TestMakePay()
        {
            string login = "sashaBelyakov02";
            string password = "admin";
            string fio = "Беляков Александр Алексеевич";

            Account.AddAccount(login, password, fio);
            Account account = Account.GetAccount(login, password);
            account.WalletBalance = 7500;
            account.CardBalance = 50000;
            account.Bonuses = 1000;
            account.PurchasesValue = 15000;

            decimal wallet = 4000;
            decimal card = 50000;
            decimal bonuses = 1000;
            decimal purchaseValue = 55000;
            decimal discount = 0;

            switch (account.Status)
            {
                case "Bronze":
                    discount = (decimal)0.03;
                    break;
                case "Silver":
                    discount = (decimal)0.05;
                    break;
                case "Gold":
                    discount = (decimal)0.07;
                    break;
                case "Platinum":
                    discount = (decimal)0.10;
                    break;
            }

            bool isValid = account.IsValidBalance(wallet, card, bonuses);

            if (isValid)
                account.MakePay(wallet, card, bonuses, purchaseValue - bonuses);

            decimal expectedBonuses = (purchaseValue - bonuses) * (decimal)0.05;
            decimal exeptedWallet = 3500;
            decimal expectedCard = 0;
            decimal expectedpurchaseValue = 70000 * (1 - discount) - bonuses;

            Assert.AreEqual(exeptedWallet, account.WalletBalance, "Налчиные не совпали");
            Assert.AreEqual(expectedCard, account.CardBalance, "Баланс карты не совпал");
            Assert.AreEqual(expectedBonuses, account.Bonuses, "Бонусы не совпали");
            Assert.AreEqual(expectedpurchaseValue, account.PurchasesValue, "Сумма покупок не совпала");
        }
    }
}
