using PT_KP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_KP.View
{
    public interface IViewComponents
    {
        List<Motherboard> motherboardsList { get; set; }
        List<CPU> cpusList { get; set; }
        List<GPU> gpusList { get; set; }
        List<PC> computersList { get; set; }
    }
}
