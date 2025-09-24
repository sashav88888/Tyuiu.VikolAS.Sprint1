using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VikolAS.Sprint1.Task7.V5.Lib
{
    public class DataService : ISprint1Task7V5
    {
        public double Calculate(double x)
        {
            double denominator = Math.Log(1 + x * x);
            if (denominator == 0)
                throw new DivideByZeroException("Деление на ноль невозможно.");

            double numerator = Math.Log(Math.Abs(Math.Cos(x)));
            return numerator / denominator;
        }
    }
}
