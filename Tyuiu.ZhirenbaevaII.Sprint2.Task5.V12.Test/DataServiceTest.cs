using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhirenbaevaII.Sprint2.Task5.V12.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int n = 1;
            int m = 3;
            int g = 2024;
            Assert.AreEqual("29.2.2024", ds.FindDateOfPreviousDay(n, m, g));
        }
    }
}
