using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VikolAS.Sprint1.Task0.V22.Lib;
namespace Tyuiu.VikolAS.Sprint1.Task0.V22
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
            Console.WriteLine("* Задание #0                                 *");
            Console.WriteLine("* Вариант #22                                *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1           *");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("* УСЛОВИЕ                                    *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 6*2-(5-3)*");
            Console.WriteLine("* и печатает результат на экране.            *");
            Console.WriteLine("*                                            *");
            Console.WriteLine("*****************************************    *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                           *");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("*  6*2-(5-3)                                 *");
            Console.WriteLine("******************************************   *");
            Console.WriteLine("Результат:                                   *");
            Console.WriteLine("******************************************   *");

            Console.WriteLine(ds.Calculate());
            Console.ReadKey();
        }
    }
}
