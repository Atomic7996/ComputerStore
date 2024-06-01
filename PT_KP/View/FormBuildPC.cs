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
using PT_KP.Presenter;

namespace PT_KP.View
{
    public partial class FormBuildPC : Form, IViewPC, IViewComponents
    {
        public PC CreatedPC { get; set; }

        private PresenterPC presenterPC;
        private PresenterInitData presenterComponent;

        public List<Motherboard> motherboardsList { get; set; }
        public List<CPU> cpusList { get; set; }
        public List<GPU> gpusList { get; set; }
        public List<PC> computersList { get; set; }

        public FormBuildPC()
        {
            InitializeComponent();

            presenterPC = new PresenterPC(this);

            presenterComponent = new PresenterInitData(this);

            presenterComponent.GetMotherboards();
            presenterComponent.GetCPUs();
            presenterComponent.GetGPUs();

            computersList = new List<PC>();

            cbMotherboard.DataSource = motherboardsList;
            cbCpu.DataSource = cpusList;
            cbGpu.DataSource = gpusList;
        }

        // Создание компьютера через строитель
        private void BuildComputer()
        {
            // Выбранные комплектующие
            Motherboard curMotherboard = cbMotherboard.SelectedItem as Motherboard;
            CPU curCpu = cbCpu.SelectedItem as CPU;
            GPU curGpu = cbGpu.SelectedItem as GPU;

            // Создание компьютера с выбранными комплектующими
            // используя "Builder" (Строитель)
            CreatedPC = new PC();
            presenterPC.modelPCBuilder = new PCBuilder();

            switch (cbMotherboard.SelectedItem)
            {
                case null:
                    break;
                default:
                    presenterPC.AddMotherboard(curMotherboard.Manufacturer, curMotherboard.Title, curMotherboard.Price);
                    break;
            }

            switch (cbCpu.SelectedItem)
            {
                case null:
                    break;
                default:
                    presenterPC.AddCpu(curCpu.Manufacturer, curCpu.Title, curCpu.Price, curCpu.Cores, curCpu.Frequancy);
                    break;
            }

            switch (cbGpu.SelectedItem)
            {
                case null:
                    break;
                default:
                    presenterPC.AddGpu(curGpu.Manufacturer, curGpu.Title, curGpu.Price, curGpu.VideoMemory);
                    break;
            }

            // Финальная сборка объекта PC
            presenterPC.BuildPC(tbTitle.Text);

            // Обновление списка компьютеров
            computersList.Add(CreatedPC);
        }

        private void btnAddComputer_Click(object sender, EventArgs e)
        {
            PC curComp = computersList
                .Where(item => item.Title == tbTitle.Text)
                .FirstOrDefault();

            if (curComp == null)
            {
                BuildComputer();

                lbComputers.DataSource = null;
                lbComputers.DataSource = computersList;
                lbComputers.DisplayMember = "Title";
            }
            else
            {
                MessageBox.Show("Сборка с таким названием уже существует!");
            }
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
