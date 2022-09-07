using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest_Project
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_ToplaMethod()
        {
            TemelIslemler tm = new TemelIslemler();
            double sonuc = tm.Topla(10, 10);
            Assert.AreEqual(20, sonuc);
        }

        [TestMethod]
        public void Test_CarpMethod()
        {
            TemelIslemler tm = new TemelIslemler();
            double sonuc = tm.Topla(5, 5);
            Assert.AreEqual(25, sonuc);
        }
        [TestMethod]
        public void Test_Pozitifmi()
        {
            TemelIslemler tm =new TemelIslemler();
            bool sonuc = tm.Pozitifmi(1);
            Assert.IsTrue(sonuc);
        }
    }
}
