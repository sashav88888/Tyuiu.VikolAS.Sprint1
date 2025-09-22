using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint1.Task4.V3.Lib;

namespace Tyuiu.VikolAS.Sprint1.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_ValidData_ReturnsCorrectResult()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3, 1);
            Assert.AreEqual(0.75, res, 0.001);
        }
    }
}
