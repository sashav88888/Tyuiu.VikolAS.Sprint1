using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VikolAS.Sprint1.Task2.V26.Lib;
namespace Tyuiu.VikolAS.Sprint1.Task2.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Викол А.С. | ИСПб-25-1";
            Console.WriteLine("******************************************");
            Console.WriteLine("* Спринт #1                              *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#       *");
            Console.WriteLine("* Задание #2                             *");
            Console.WriteLine("* Вариант #26                            *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1       *");
            Console.WriteLine("******************************************");
            Console.WriteLine("* УСЛОВИЕ                                 *");
            Console.WriteLine("* Задано текущее время в часах и минутах. *");
            Console.WriteLine("* Вычислить, сколько минут прошло с       *");
            Console.WriteLine("* начала суток и напечатать результат.    *");
            Console.WriteLine("***************************************** *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                        *");
            Console.Write("*Введите количество часов:                    *");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество минут: ");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************** *");
            Console.WriteLine("* РЕЗУЛЬТАТ                               *");
            Console.WriteLine("***************************************** *");
            int result = ds.CalculateMinutesSinceStart(hours, minutes);
            Console.WriteLine("С начала суток прошло: " + result + " минут.");

            Console.ReadKey();
        }
    }
}
