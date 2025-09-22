using System;
using Tyuiu.VikolAS.Sprint1.Task4.V3.Lib;

namespace Tyuiu.VikolAS.Sprint1.Task4.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Викол А.С. | ИСПб-25-1";
            Console.WriteLine("*****************************************");
            Console.WriteLine("* Спринт #1                             *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#      *");
            Console.WriteLine("* Задание #4                            *");
            Console.WriteLine("* Вариант #3                            *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1      *");
            Console.WriteLine("*****************************************");
            Console.WriteLine("* УСЛОВИЕ                               *");
            Console.WriteLine("* Вычислить выражение: sqrt(3x)/(x - y)^2*");
            Console.WriteLine("* Ответ округлить до 3 знаков после запятой. *");
            Console.WriteLine("*****************************************");

            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double result = new DataService().Calculate(x, y);
            Console.WriteLine($"Результат: {result}");

            Console.ReadKey();
        }
    }
}
