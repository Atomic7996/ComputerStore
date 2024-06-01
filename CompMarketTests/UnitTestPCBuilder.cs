using Microsoft.VisualStudio.TestTools.UnitTesting;
using PT_KP.Model;
using PT_KP.Presenter;
using System;

namespace CompMarketTests
{
    [TestClass]
    public class UnitTestPCBuilder
    {
        [TestMethod]
        public void TestBuildPC()
        {
            PC expectedPC = new PC("MSI Gaming PC i7 4770 RX5500 8GB",
                new Motherboard().CreateComponent("MSI", "Z390", 14000),
                new CPU().CreateComponent("Intel", "i7 4770", 4000, 4, (decimal)2.8),
                new GPU().CreateComponent("AMD", "RX 5500", 25000, 8),
                43000);

            PC pc;
            PCBuilder pcBuilder = new PCBuilder();

            pcBuilder.AddMotherboard("MSI", "Z390", 14000);
            pcBuilder.AddCpu("Intel", "i7 4770", 4000, 4, (decimal)2.8);
            pcBuilder.AddGpu("AMD", "RX 5500", 25000, 8);
            pc = pcBuilder.Build("MSI Gaming PC i7 4770 RX5500 8GB");


            Assert.AreEqual(expectedPC.Title, pc.Title);
            Assert.AreEqual(expectedPC.Price, pc.Price);
        }
    }
}