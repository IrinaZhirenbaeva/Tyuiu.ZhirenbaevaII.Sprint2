using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint2.Task0.V28.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint2.Task0.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 111;
            int y = 735;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #2 | Выполнила: Жиренбаева И.И | ИСТНб-23-1";

            Console.WriteLine("");
            Console.WriteLine(" Спринт #2                                                               ");
            Console.WriteLine(" Тема: Алгоритмы разветвляющейся структуры                                      ");
            Console.WriteLine(" Задание #0                                                              ");
            Console.WriteLine(" Вариант #28                                                            ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                       ");
            Console.WriteLine("");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine(" Написать программу из операций сравнений            ");
            Console.WriteLine("                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("");
            Console.WriteLine("X= " + x);
            Console.WriteLine("Y= " + y);
            Console.WriteLine("**");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("**");

            for (int i = 0; i < 6; i++)
                Console.WriteLine(res[i]);


            Console.ReadKey();
        }
    }
}
