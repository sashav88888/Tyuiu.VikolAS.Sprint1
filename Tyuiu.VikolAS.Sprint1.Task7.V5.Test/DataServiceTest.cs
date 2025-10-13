using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VikolAS.Sprint1.Task7.V5.Lib;
namespace Tyuiu.VikolAS.Sprint1.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 2;
            double expected = -0.545;
            double actual = ds.Calculate(x);



            Assert.AreEqual(expected, actual, 0.001, "Ошибка в вычислении формулы");
        }
    }
}
  


