using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZhirenbaevaII.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
        public string FindDateOfPreviousDay(int n, int m, int g)
        { int mp = m;
            int np=n;

            if (n == 1)
            {
                if (m == 1)
                {
                    n = 31;
                    m = 12;
                    g -= 1;
                }
                else {
                    switch (m)
                    {
                        case 2:
                        case 4:
                        case 6:
                        case 8:
                        case 9:
                        case 11:
                            {
                                mp -= 1;
                                np = 31;
                            }
                            break;
                        case 5:
                        case 7:
                        case 10:
                        case 12:
                            {
                                np -= 1;
                                np = 30;
                            }
                            break;
                        case 3:
                            {
                                mp -= 1;
                                np = 29;
                            }
                            break;
                    }

                }
            }
            else np = n - 1;
            return ($"{np}.{mp}.{g}");
        }
    }
}
