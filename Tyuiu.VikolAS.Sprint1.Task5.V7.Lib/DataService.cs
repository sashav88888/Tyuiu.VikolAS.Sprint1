using System;

namespace Tyuiu.VikolAS.Sprint1.Task5.V7.Lib
{
    public class DataService
    {
        public (int Hours, int Minutes) AngleToHoursMinutes(double f)
        {
            
            double hours = f / 30;

            int h = Convert.ToInt32(Math.Floor(hours));
            int m = Convert.ToInt32((hours - h) * 60);

            return (h, m);
        }
    }
}
