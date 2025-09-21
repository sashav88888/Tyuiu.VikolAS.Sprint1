using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.VikolAS.Sprint1.Task3.V12.Lib
{
    public class DataService : ISprint1Task3V12
    {
        public static double CalculateTriangleArea(double x, double y)
        {
            if (x <= 0 || y <= 0)
                throw new ArgumentException("Катеты должны быть положительными числами.");
            double area = 0.5 * x * y;
            return Math.Round(area, 3);
        }

        public double TriangleArea(double lengthCathetus1, double lengthCathetus2)
        {
            throw new NotImplementedException();
        }
    }
}
