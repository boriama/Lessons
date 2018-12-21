using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2//1. Написать метод, возвращающий минимальное из трех чисел. Земских Борис
{
    partial class Home
    {
        static int MinOfThree(int a, int b, int c)
        {
            int min = 0;
            if (a < b && a < c)
            {
               min = a;
            }
            else if (b < a && b < c)
            {
               min = b;
            }
            else if (c < a && c < b)
            {
               min = c;
            }
            return min;
        }
        
            

        
    }
}
