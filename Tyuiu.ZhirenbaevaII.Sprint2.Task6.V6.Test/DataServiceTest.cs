using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhirenbaevaII.Sprint2.Task6.V6.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Дама пик", ds.FindCardNameAndValue(1, 12));
            Assert.AreEqual("Шестерка треф", ds.FindCardNameAndValue(2, 6));
        }
    }
}
