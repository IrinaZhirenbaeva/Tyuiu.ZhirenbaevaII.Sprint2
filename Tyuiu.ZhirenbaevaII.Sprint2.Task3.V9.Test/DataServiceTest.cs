using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhirenbaevaII.Sprint2.Task3.V9.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint2.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
       
        {
            DataService ds = new DataService();
            Assert.AreEqual(-2.667, ds.Calculate(1));
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            Assert.AreEqual(1, ds.Calculate(0));
        }
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.2, ds.Calculate(-1));
        }
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-165.067, ds.Calculate(-15));
        }
    }
}
