using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.VikolAS.Sprint1.Task3.V12.Lib;
namespace Tyuiu.VikolAS.Sprint1.Task3.V12.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 3;
            double y = 4;
            double wait = 6.0;
            var res = DataService.CalculateTriangleArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
