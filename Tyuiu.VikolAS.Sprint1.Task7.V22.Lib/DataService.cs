using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VikolAS.Sprint1.Task7.V22.Lib
{
    public class DataService : ISprint1Task7V22
    {
        public double Calculate(double x, double y)
        {
            double cotX = 1 / Math.Tan(x);
            double z = (1 - Math.Tan(x)) * cotX + Math.Cos(x - y);
            return Math.Round(z, 3);
        }

    }
}
