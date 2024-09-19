using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZolotovaKA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ZolotovaKA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Карина";
            var ress = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Карина", ress);
        }
    }
}
