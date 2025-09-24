using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VikolAS.Sprint1.Task7.V22.Lib;
namespace Tyuiu.VikolAS.Sprint1.Task7.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #1 | Выполнил: Викол А.С. | ИСПб-25-1";
            Console.WriteLine("*****************************************");
            Console.WriteLine("* Спринт #1                             *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#      *");
            Console.WriteLine("* Задание #7                            *");
            Console.WriteLine("* Вариант #22                            *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1      *");
            Console.WriteLine("*****************************************");
            Console.WriteLine("* УСЛОВИЕ:                              *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным значениям данных, вводимых пользователем.*");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой. *");
            Console.WriteLine("*****************************************");


            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            // Вычисление результата
            double result = ds.Calculate(x, y);

            // Вывод результата
            Console.WriteLine($"Результат: z = {result}");



        }
    }
}
