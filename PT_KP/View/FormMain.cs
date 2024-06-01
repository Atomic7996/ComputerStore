using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PT_KP.Model;
using PT_KP.View;
using PT_KP.Presenter;

namespace PT_KP
{
    public partial class FormMain : Form, IViewAccount
    {
        public Account LoggedAccount { get; set; }

        public FormMain()
        {
            InitializeComponent();

            LoggedAccount = null;
        }

        private void catalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FormCatalog")
                    open = true;
            }

            if (!open)
            {
                FormCatalog form = new FormCatalog();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void buildPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FormBuildPC")
                    open = true;
            }

            if (!open)
            {
                FormBuildPC form = new FormBuildPC();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool openProf = false;

            if (LoggedAccount == null)
            {
                FormUserData formUserData = new FormUserData();
                formUserData.Owner = this;
                formUserData.ShowDialog();
            }
            else
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name == "FormProfile")
                        openProf = true;
                }

                if (!openProf)
                {
                    FormProfile formProfile = new FormProfile(LoggedAccount);
                    formProfile.MdiParent = this;
                    formProfile.Show();
                }
            }
        }

        private void shoppingCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool open = false;

            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "FormShoppingCart")
                    open = true;
            }

            if (!open)
            {
                FormShoppingCart form = new FormShoppingCart(LoggedAccount);
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}
