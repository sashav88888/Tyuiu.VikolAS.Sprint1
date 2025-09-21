using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VikolAS.Sprint1.Task2.V26.Lib;
namespace Tyuiu.VikolAS.Sprint1.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int hours = 2;
            int minutes = 20;
            int expected = 140;

            int result = ds.CalculateMinutesSinceStart(hours, minutes);

            Assert.AreEqual(expected, result);
        }
    }
}
