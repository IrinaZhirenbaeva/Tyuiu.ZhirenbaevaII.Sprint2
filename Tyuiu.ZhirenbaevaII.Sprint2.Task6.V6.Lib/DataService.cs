using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2; 

namespace Tyuiu.ZhirenbaevaII.Sprint2.Task6.V6.Lib
{
    public class DataService : ISprint2Task6V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string m;
            string n;
            switch (value1)
            {
                case 1: m = "пик"; break;
                case 2: m = "треф"; break;
                case 3: m = "бубен"; break;
                case 4: m = "червей"; break;
                default: throw new ArgumentException($"Масть карты должна быть от 1 до 4. Значение {value1}");
            }
            switch (value2)
            {
                case 6: n = "Шестерка"; break;
                case 7: n = "Семерка"; break;
                case 8: n = "Восьмерка"; break;
                case 9: n = "Девятка"; break;
                case 10: n = "Десятка"; break;
                case 11: n = "Валет"; break;
                case 12: n = "Дама"; break;
                case 13: n = "Король"; break;
                case 14: n = "Туз"; break;
                default: throw new ArgumentException($"Порядковый номер карты должен быть от 6 до 14. Значение {value2}");
            }
                 return ($"{n} {m}");
        }
    }
}
