using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhirenbaevaII.Sprint2.Task1.V20.Lib;

namespace Tyuiu.ZhirenbaevaII.Sprint2.Task1.V20
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            int a = 242;
            int b= 155;
            int c = 456;
            int d = 17;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнила: Жиренбаева И.И | ИСТНб-23-1";

            Console.WriteLine("");
            Console.WriteLine(" Спринт #2                                                               ");
            Console.WriteLine(" Тема: Алгоритмы разветвляющейся структуры                                      ");
            Console.WriteLine(" Задание #1                                                              ");
            Console.WriteLine(" Вариант #20                                                            ");
            Console.WriteLine(" Выполнила: Жиренбаева Ирина Ильгизовна | ИСТНб-23-1                       ");
            Console.WriteLine("");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine(" Написать программу из операций сравнений            ");
            Console.WriteLine("                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("");
            Console.WriteLine("a= " + a);
            Console.WriteLine("b= " + b);
            Console.WriteLine("c= " + c);
            Console.WriteLine("d= " + d);
            Console.WriteLine("**");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("**");

            for (int i = 0; i < 6; i++)

                Console.WriteLine(res[i]);


            Console.ReadKey();
        }
    }
}
    

