using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZhirenbaevaII.Sprint2.Task2.V28.Lib
{
    public class DataService : ISprint2Task2V28
{
    public bool CheckDotInShadedArea(int x, int y)
    {
        if ((y == 2) && (x > 9) && (x < 14) || (y == 3) && (((x > 2) && (x < 6)) || ((x > 9) && (x < 14))) ||(y == 4) && (((x > 1) && (x < 6)) || ((x > 9) && (x < 13))) || (y == 5) && (x > 1) && (x < 13) || (y == 6) && (x > 2) && (x < 9) || (y == 7) && (x > 2) && (x < 9) || (y == 8) && (x > 5) && (x < 9) || (y == 9) && (((x > 5) && (x < 9)) || (x == 13)) || (y == 10) && (((x > 5) && (x < 9)) || (x == 13)) || (y == 11) && (x > 2) && (x < 14) || (y == 12) && (((x > 6) && (x < 11)) || (x == 13)) || (y == 13) && (x == 13)) return true;
        else return false;
    }
}

}

