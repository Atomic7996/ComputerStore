using PT_KP.Model;
using PT_KP.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_KP.Presenter
{
    public class PresenterInitData
    {
        public IViewComponents view;

        public PresenterInitData(IViewComponents view)
        {
            this.view = view;
        }

        public void GetMotherboards()
        {
            this.view.motherboardsList = InitData.InitMotherboards();
        }

        public void GetCPUs()
        {
            this.view.cpusList = InitData.InitCPUs();
        }

        public void GetGPUs()
        {
            this.view.gpusList = InitData.InitPGUs();
        }

        public void GetComputers()
        {
            this.view.computersList = InitData.InitComputers();
        }
    }
}
