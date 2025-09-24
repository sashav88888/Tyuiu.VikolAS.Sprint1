using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.VikolAS.Sprint1.Task7.V5.Lib;
namespace Tyuiu.VikolAS.Sprint1.Task7.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();


            Console.Title = "Спринт #1 | Выполнил: Викол А.С. | ИСПб-25-1";
            Console.WriteLine("*****************************************");
            Console.WriteLine("* Спринт #1                             *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#      *");
            Console.WriteLine("* Задание #7                            *");
            Console.WriteLine("* Вариант #5                            *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1      *");
            Console.WriteLine("*****************************************");
            Console.WriteLine("* УСЛОВИЕ:                              *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным значениям данных, вводимых пользователем.*");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой. *");
            Console.WriteLine("* Вычислить z = ln|cos x| / ln(1+x^2)   *");
            Console.WriteLine("*****************************************");
            

            Console.Write("Введите значение x: ");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                try
                {
                    double z = ds.Calculate(x);
                    Console.WriteLine($"Результат z = {Math.Round(z, 3)}");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введено не число.");
            }





        }
    }
}
