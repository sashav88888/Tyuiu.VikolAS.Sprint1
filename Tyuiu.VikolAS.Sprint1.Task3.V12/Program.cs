using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VikolAS.Sprint1.Task3.V12.Lib;
namespace Tyuiu.VikolAS.Sprint1.Task3.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Викол А.С. | ИСПб-25-1";
            Console.WriteLine("***************************************** *");
            Console.WriteLine("* Спринт #1                               *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#        *");
            Console.WriteLine("* Задание #3                              *");
            Console.WriteLine("* Вариант #12                             *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1        *");
            Console.WriteLine("***************************************** *");
            Console.WriteLine("* УСЛОВИЕ                                 *");
            Console.WriteLine("* Вычисление площади прямоугольного треугольника по длинам двух катетов.*");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.*");
            Console.WriteLine("***************************************** *");

            // Ввод катетов
            Console.Write("Введите длину первого катета: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите длину второго катета: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************** *");
            Console.WriteLine("* РЕЗУЛЬТАТ                               *");
            Console.WriteLine("***************************************** *");

            // Вычисление площади
            double area = DataService.CalculateTriangleArea(x, y);
            Console.WriteLine($"Площадь прямоугольного треугольника: {area}");

            Console.ReadKey();
        }
    }
}
