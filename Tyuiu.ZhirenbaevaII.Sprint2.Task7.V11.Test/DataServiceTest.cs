using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhirenbaevaII.Sprint2.Task7.V11.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint2.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            Assert.AreEqual(true, ds.CheckDotInShadedArea(-0.25, 0.75));
            Assert.AreEqual(true, ds.CheckDotInShadedArea(-0.25, -0.75));
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0.5, 0.25));
        }
    }
}
