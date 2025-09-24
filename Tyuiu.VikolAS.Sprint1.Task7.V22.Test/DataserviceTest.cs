using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VikolAS.Sprint1.Task7.V22.Lib;
namespace Tyuiu.VikolAS.Sprint1.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 4;
            double expected = 0.172;

            double actual = ds.Calculate(x, y);

            Assert.AreEqual(expected, actual, 0.001, "Ошибка в вычислении формулы");
        }
    }
}
