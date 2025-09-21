using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VikolAS.Sprint1.Task1.V9.Lib;
namespace Tyuiu.VikolAS.Sprint1.Task1.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = ("Спринт #1 | Выполнил: Викол А.С. | ИСПб-25-1   ");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* Спринт #1                                  *");
            Console.WriteLine("* Тема: Базовые навыки работы с С#           *");
            Console.WriteLine("* Задание #1                                 *");
            Console.WriteLine("* Вариант #9                                 *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1           *");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* УСЛОВИЕ                                    *");
            Console.WriteLine("* Написать консольную программу на С#, которая запрашивает у пользователя исходные данные,*");
            Console.WriteLine("* вычисляет результат по формуле  (1+3*x)/(4*y) и печатает его на экране.            *");
            Console.WriteLine("*                                            *");
            Console.WriteLine("*****************************************    *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                           *");
            Console.WriteLine("******************************************   *");


            double x, y;
            Console.WriteLine("Введите значение Х:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("******************************************   *");
            Console.WriteLine("Результат:                                   *");
            Console.WriteLine("******************************************   *");

            Console.WriteLine(ds.Calculate(x, y));




            Console.ReadLine();

        }
    }
}
