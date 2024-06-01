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
    public partial class FormBalanceInput : Form, IViewAccount
    {
        public Account LoggedAccount { get; set; }
        private PresenterAccount presenterAccount;

        public FormBalanceInput(Account logInAccount)
        {
            InitializeComponent();

            LoggedAccount = logInAccount;
            presenterAccount = new PresenterAccount(this);
        }

        private void btnEnterData_Click(object sender, EventArgs e)
        {
            decimal wallet = 0;
            decimal card = 0;

            decimal.TryParse(tbWallet.Text, out wallet);
            decimal.TryParse(tbCard.Text, out card);

            presenterAccount.modelAccount.AddToBalance(wallet, card);
            this.Close();
        }

        private void tbWallet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void tbCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }
    }
}
