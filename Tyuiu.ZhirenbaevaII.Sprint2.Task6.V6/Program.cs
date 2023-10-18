using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint2.Task6.V6.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint2.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Жиренбаева И.И| ИСТНб-23-1";

            Console.WriteLine("**");
            Console.WriteLine(" Спринт #2                                                               ");
            Console.WriteLine(" Тема:  Алгоритмы разветвляющейся структуры                                        ");
            Console.WriteLine(" Задание #6                                                              ");
            Console.WriteLine(" Вариант #6                                                              ");
            Console.WriteLine(" Выполнилa: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                              ");
            Console.WriteLine("**");
            Console.WriteLine("* УСЛОВИЕ:                                                               ");
            Console.WriteLine(" Написать программу, которая использует сокращенную форму записи         ");
            Console.WriteLine(" оператора switch вычисляет требуемое значение и возвращает результат.   ");
            Console.WriteLine(" По заданному номеру карты определить достоинство соответствующей карты. ");
            Console.WriteLine("**");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       ");
            Console.WriteLine("**");

            Console.WriteLine("Введите порядковый номер карты:");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите масть карты:");
            int value2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                              ");
            Console.WriteLine("**");

            string res = ds.FindCardNameAndValue(value1, value2);
            Console.WriteLine("Название карты: " + res);
            Console.ReadKey();
        }
    }
}
