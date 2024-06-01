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
    public partial class FormPayment : Form, IViewAccount, IViewShoppingCart
    {
        public Account LoggedAccount { get; set; }
        public CartRecord SelectedCartRecord { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        PresenterAccount presenterAccount;
        PresenterShoppingCart presenterShoppingCart;

        private decimal startIurchasePrice;
        private decimal purchaseValue;
        private decimal remains;
        private decimal wallet;
        private decimal card;
        private decimal bonuses;
        private decimal discount;

        public FormPayment(Account logInAccount)
        {
            InitializeComponent();

            LoggedAccount = logInAccount;

            presenterShoppingCart = new PresenterShoppingCart(this);
            presenterAccount = new PresenterAccount(this);

            startIurchasePrice = presenterShoppingCart.ComputeTotalValue();

            switch (LoggedAccount.Status)
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
                default:
                    purchaseValue = presenterShoppingCart.ComputeTotalValue();
                    break;
            }

            purchaseValue = startIurchasePrice * (1 - discount);
            remains = purchaseValue;

            lPrice.Text += startIurchasePrice;
            lDiscount.Text += startIurchasePrice * discount;
            lTotalPrice.Text += purchaseValue;

            lLogin.Text += LoggedAccount.Login;
            lMoneyRemain.Text += purchaseValue;
            tbWallet.Visible = false;
            tbCard.Visible = false;
            tbBonuses.Visible = false;
            lBonuses.Visible = false;

            lbProducts.DataSource = presenterShoppingCart.GetRecords();
            lbProducts.DisplayMember = "Title";
        }

        private void UpdateRemains()
        {
            decimal.TryParse(tbWallet.Text, out wallet);
            decimal.TryParse(tbCard.Text, out card);
            decimal.TryParse(tbBonuses.Text, out bonuses);

            remains = purchaseValue;
            remains -= wallet;
            remains -= card;
            remains -= bonuses;

            if (remains == 0)
            {
                lMessage.Text = string.Empty;
                lMoneyRemain.Text = string.Empty;
                btnPay.Enabled = true;
            }
            else if (remains < 0)
            {
                lMessage.Text = "Переизбыток введенных средств";
                lMoneyRemain.Text = "Избыток:" + remains;
                btnPay.Enabled = false;
            }
            else if (remains > 0)
            {
                lMessage.Text = "Недостаточно введенных средств";
                lMoneyRemain.Text = "Остаток:" + remains;
                btnPay.Enabled = false;
            }
        }

        private bool CheckBalance()
        {
            return presenterAccount.IsValidBalance(wallet, card, bonuses);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (remains == 0)
            {
                if (CheckBalance())
                {
                    if (bonuses / purchaseValue * 100 > 50)
                    {
                        MessageBox.Show("Оплатить бонусами можно не более 50% стоимости заказа!");
                    }
                    else
                    {
                        decimal newBonuses = (purchaseValue - bonuses) * (decimal)0.05;

                        presenterAccount.MakePay(wallet, card, bonuses, purchaseValue);

                        this.DialogResult = DialogResult.OK;

                        MessageBox.Show(string.Format("Оплата прошла успешно! Спасибо за покупку!\nНа счет профиля Вам начислено {0} бонусов!", newBonuses), "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                }
                else
                    lMessage.Text = "Недостаточно средств на счетах";
            }
            else
                UpdateRemains();
        }

        private void cbWallet_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWallet.Checked)
                tbWallet.Visible = true;
            else
            {
                tbWallet.Text = string.Empty;
                tbWallet.Visible = false;
            }
        }

        private void cbCard_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCard.Checked)
                tbCard.Visible = true;
            else
            {
                tbCard.Text = string.Empty;
                tbCard.Visible = false;
            }
        }

        private void cbBonuses_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBonuses.Checked)
            {
                tbBonuses.Visible = true;
                lBonuses.Visible = true;
                lBonuses.Text = "Доступно бонусов: " + presenterAccount.GetBonuses();
            }
            else
            {
                tbBonuses.Text = string.Empty;
                tbBonuses.Visible = false;

                lBonuses.Visible = false;
            }
        }

        private void tbWallet_TextChanged(object sender, EventArgs e)
        {
            UpdateRemains();
        }

        private void tbCard_TextChanged(object sender, EventArgs e)
        {
            UpdateRemains();
        }

        private void tbBonuses_TextChanged(object sender, EventArgs e)
        {
            UpdateRemains();
        }

        private void tbWallet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void tbCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void tbBonuses_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }
    }
}
