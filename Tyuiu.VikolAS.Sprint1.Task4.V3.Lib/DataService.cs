using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VikolAS.Sprint1.Task4.V3.Lib
{
    public class DataService : ISprint1Task4V3
    {
        public double Calculate(double x, double y)
        {                              
            double n = Math.Sqrt(3 * x);
            
            double d = Math.Pow(x - y, 2);
            
            double res = n / d;
            
            return Math.Round(res, 3);
        }
    }
}