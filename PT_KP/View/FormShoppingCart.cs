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
    public partial class FormShoppingCart : Form, IViewAccount, IViewShoppingCart
    {
        public Account LoggedAccount { get; set; }
        public CartRecord SelectedCartRecord { get; set; }

        private PresenterShoppingCart presenterShoppingCart;

        private List<CartRecord> listRecords;       

        private decimal totalValue;

        public FormShoppingCart(Account logInAccount)
        {
            InitializeComponent();

            presenterShoppingCart = new PresenterShoppingCart(this);

            LoggedAccount = logInAccount;

            listRecords = presenterShoppingCart.GetRecords();

            lbCartItems.DataSource = listRecords;
            lbCartItems.DisplayMember = "Title";

            totalValue = ShoppingCart.ComputeTotalValue();

            lTotalPrice.Text = "Итоговая цена: " + totalValue.ToString();
            lLoginToBuy.Text = string.Empty;

            if (listRecords.Count == 0)
            {
                btnRemoveItem.Enabled = false;
                btnPayment.Enabled = false;
            }

            if (LoggedAccount == null)
            {
                btnPayment.Enabled = false;
                lLoginToBuy.Text = "Выполните вход в профиль, чтобы перейти к оплате!";
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            SelectedCartRecord = listRecords[lbCartItems.SelectedIndex] as CartRecord;
            presenterShoppingCart.RemoveItem(SelectedCartRecord);

            totalValue = presenterShoppingCart.ComputeTotalValue();

            lbCartItems.DataSource = null;
            lbCartItems.DataSource = presenterShoppingCart.GetRecords();
            lbCartItems.DisplayMember = "Title";

            lTotalPrice.Text = "Итоговая цена: " + totalValue.ToString();

            if (totalValue == 0)
            {
                btnPayment.Enabled = false;
            }

            if (listRecords.Count == 0)
            {
                btnRemoveItem.Enabled = false;
                btnPayment.Enabled = false;
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            presenterShoppingCart.ClearShoppingCart();

            totalValue = presenterShoppingCart.ComputeTotalValue();

            lTotalPrice.Text = "Итоговая цена: " + totalValue.ToString();

            rtbDescription.Text = "";
            btnPayment.Enabled = false;
            lbCartItems.DataSource = null;
            btnRemoveItem.Enabled = false;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            totalValue = presenterShoppingCart.ComputeTotalValue();

            FormPayment formPayment = new FormPayment(LoggedAccount);
            formPayment.ShowDialog();

            if (formPayment.DialogResult == DialogResult.OK)
            {
                btnClearCart_Click(sender, e);
                this.Close();
            }
        }

        private void lbCartItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCartItems.SelectedIndex >= 0)
            {
                rtbDescription.Clear();

                SelectedCartRecord = listRecords[lbCartItems.SelectedIndex];

                rtbDescription.Text = presenterShoppingCart.GetCompSpecification();

                if (LoggedAccount == null)
                {
                    btnPayment.Enabled = false;
                    lLoginToBuy.Text = "Выполните вход в профиль, чтобы перейти к оплате!";
                }
                else
                    btnPayment.Enabled = true;
            }
            else
            {
                rtbDescription.Text = string.Empty;
            }
        }
    }
}
