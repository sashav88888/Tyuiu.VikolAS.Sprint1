using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint1.Task5.V7.Lib;

namespace Tyuiu.VikolAS.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void AngleToHoursMinutes_ValidData()
        {
            DataService ds = new DataService();

            var result = ds.AngleToHoursMinutes(95);

            Assert.AreEqual(3, result.Hours);
            Assert.AreEqual(10, result.Minutes);
        }
    }
}