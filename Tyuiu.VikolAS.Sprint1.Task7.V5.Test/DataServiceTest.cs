using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VikolAS.Sprint1.Task7.V5.Lib;
namespace Tyuiu.VikolAS.Sprint1.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var ds = new DataService();

            double x = 1.0;
            double expected = Math.Log(Math.Abs(Math.Cos(x))) / Math.Log(1 + x * x);

            double actual = ds.Calculate(x);

            Assert.AreEqual(Math.Round(expected, 3), Math.Round(actual, 3));
        }
    }
}
