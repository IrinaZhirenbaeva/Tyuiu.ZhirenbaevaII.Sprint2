using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint2.Task3.V9.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint2.Task3.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Жиренбаева И.И | ИСТНб-23-1";

            Console.WriteLine("**");
            Console.WriteLine(" Спринт #2                                                               ");
            Console.WriteLine(" Тема: Алгоритмы разветвляющейся структуры                                       ");
            Console.WriteLine(" Задание #3                                                              ");
            Console.WriteLine(" Вариант #9                                                             ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                              ");
            Console.WriteLine("**");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine(" Написать программу, которая вычисляет требуемое значение функции Y      ");
            Console.WriteLine(" с использованием вложенных оператор if-else, где пользователь вводит    ");
            Console.WriteLine(" значение переменной X с клавиатуры.                                     ");
            Console.WriteLine("**");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("**");

            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                              ");
            Console.WriteLine("**");

            double res = ds.Calculate(x);
            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();

        }
    }
}
