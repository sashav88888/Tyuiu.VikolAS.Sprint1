using System;
using Tyuiu.VikolAS.Sprint1.Task5.V7.Lib;

namespace Tyuiu.VikolAS.Sprint1.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Викол А.С. | ИСПб-25-1";
            Console.WriteLine("*****************************************");
            Console.WriteLine("* Спринт #1                             *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#      *");
            Console.WriteLine("* Задание #5                            *");
            Console.WriteLine("* Вариант #7                            *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1      *");
            Console.WriteLine("*****************************************");
            Console.WriteLine("* УСЛОВИЕ                               *");
            Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток до того момента*");
            Console.WriteLine("* когда часовая стрелка повернулась на f градусов (0<f<360, f – вещественное число). *");
            Console.WriteLine("*****************************************");



            Console.Write("Введите угол: ");
            double f = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();
            var res = ds.AngleToHoursMinutes(f);

            Console.WriteLine($"{res.Hours} часов {res.Minutes} минут");
            Console.ReadKey();
        }
    }
}
