using PT_KP.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_KP.Model
{
    // Статический класс для инициализации данных о комплектующих
    // и готовых ПК
    public static class InitData
    {
        private static List<Motherboard> motherboardsList = new List<Motherboard>();
        private static List<CPU> cpusList = new List<CPU>();
        private static List<GPU> gpusList = new List<GPU>();
        private static List<PC> computersList = new List<PC>();

        public static List<Motherboard> InitMotherboards()
        {
            motherboardsList = new List<Motherboard>();

            motherboardsList.Add(new Motherboard().CreateComponent("GIGABYTE", "B660 AORUS PRO", 16000));
            motherboardsList.Add(new Motherboard().CreateComponent("MSI", "Z570 MORTAR WI-FI", 34000));
            motherboardsList.Add(new Motherboard().CreateComponent("ASUS", "H710 PRIME", 8000));

            return motherboardsList;
        }

        public static List<CPU> InitCPUs()
        {
            cpusList = new List<CPU>();

            cpusList.Add(new CPU().CreateComponent("AMD", "R5 5600X", 24000, 6, (decimal)3.7));
            cpusList.Add(new CPU().CreateComponent("AMD", "R7 7900X", 56000, 16, (decimal)4.1));
            cpusList.Add(new CPU().CreateComponent("Intel", "Core i5 12600", 16000, 10, (decimal)3.6));

            return cpusList;
        }

        public static List<GPU> InitPGUs()
        {
            gpusList = new List<GPU>();

            gpusList.Add(new GPU().CreateComponent("MSI", "RTX 3080", 79000, 10));
            gpusList.Add(new GPU().CreateComponent("NVIDIA", "RTX 2060", 23000, 8));
            gpusList.Add(new GPU().CreateComponent("ASUS", "RTX 4090", 182000, 24));

            return gpusList;
        }

        public static List<PC> InitComputers()
        {
            computersList = new List<PC>();

            computersList.Add(new PC("MSI Gaming PC i7 4770 RX5500 8GB",
                new Motherboard().CreateComponent("MSI", "Z390", 14000),
                new CPU().CreateComponent("Intel", "i7 4770", 4000, 4, (decimal)2.8),
                new GPU().CreateComponent("AMD", "RX 5500", 25000, 8), 43000));

            computersList.Add(new PC("ASRock PC i5 12400f RX6500xt 8GB",
                new Motherboard().CreateComponent("ASRock", "H510", 10000),
                new CPU().CreateComponent("Intel", "i5 12400f", 9000, 4, (decimal)2.9),
                new GPU().CreateComponent("AMD", "RX 6500xt", 29000, 8), 48000));

            computersList.Add(new PC("ASUS Gaming PC R7 5800x RTX 4070 10GB",
                new Motherboard().CreateComponent("ASUS TUF", "B670", 17000),
                new CPU().CreateComponent("AMD", "R7 5800x", 24000, 8, (decimal)3.5),
                new GPU().CreateComponent("MSI", "RTX 4070", 36000, 10), 77000));

            return computersList;
        }
    }
}
