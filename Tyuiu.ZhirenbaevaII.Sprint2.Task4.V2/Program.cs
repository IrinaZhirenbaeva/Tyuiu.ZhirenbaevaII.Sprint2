using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint2.Task4.V2.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint2.Task4.V2
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
            Console.WriteLine(" Задание #4                                                              ");
            Console.WriteLine(" Вариант #2                                                             ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                              ");
            Console.WriteLine("**");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine(" Написать программу, которая вычисляет требуемое значение c помощью тернарного оператора     ");
            Console.WriteLine(" где пользователь вводит значение переменных х,у     ");
            Console.WriteLine(" с клавиатуры.                                     ");
            Console.WriteLine("**");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("**");

            Console.WriteLine("Введите значение X:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                              ");
            Console.WriteLine("**");

            double res = ds.Calculate(x,y);
            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}
