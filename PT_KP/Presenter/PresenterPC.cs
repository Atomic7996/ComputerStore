using PT_KP.Model;
using PT_KP.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_KP.Presenter
{
    public class PresenterPC
    {
        public IViewPC view;
        public PC modelPC;
        public PCBuilder modelPCBuilder;

        public PresenterPC(IViewPC view)
        {
            this.view = view;
            this.modelPC = new PC();
            this.modelPCBuilder = new PCBuilder();
        }

        public void AddMotherboard(string manuf, string title, int price)
        {
            this.modelPCBuilder.AddMotherboard(manuf, title, price);
        }

        public void AddCpu(string manuf, string title, int price, int cores, decimal frequency)
        {
            this.modelPCBuilder.AddCpu(manuf, title, price, cores, frequency);
        }

        public void AddGpu(string manuf, string title, int price, int vm)
        {
            this.modelPCBuilder.AddGpu(manuf, title, price, vm);
        }

        public void BuildPC(string title)
        {
            this.view.CreatedPC = this.modelPCBuilder.Build(title);
        }

        public string GetSpecification()
        {
            this.modelPC = this.view.CreatedPC;
            return this.modelPC.GetSpecification();
        }

        public void AddItem()
        {
            this.modelPC = this.view.CreatedPC;
            ShoppingCart.AddItem((Computer)modelPC, 1);
        }
    }
}
