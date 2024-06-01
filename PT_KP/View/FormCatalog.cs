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
    public partial class FormCatalog : Form, IViewPC, IViewComponents
    {
        public PC CreatedPC { get; set; }
        public List<Motherboard> motherboardsList { get; set; }
        public List<CPU> cpusList { get; set; }
        public List<GPU> gpusList { get; set; }
        public List<PC> computersList { get; set; }

        private PresenterInitData presenterComponent;

        private PresenterPC presenterPC;

        public FormCatalog()
        {
            InitializeComponent();

            presenterComponent = new PresenterInitData(this);
            presenterPC = new PresenterPC(this);

            computersList = new List<PC>();

            presenterComponent.GetComputers();

            lbComputers.DataSource = computersList;
            lbComputers.DisplayMember = "Title";
        }

        private void btnAddToShoppingCart_Click(object sender, EventArgs e)
        {
            CreatedPC = computersList[lbComputers.SelectedIndex] as PC;
            presenterPC.AddItem();
        }

        private void lbComputers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbComputers.SelectedIndex >= 0)
            {
                rtbOutput.Clear();

                CreatedPC = computersList[lbComputers.SelectedIndex] as PC;
                rtbOutput.Text = presenterPC.GetSpecification();
            }
        }
    }
}
