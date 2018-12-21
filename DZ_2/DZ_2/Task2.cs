using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2 //2. Написать метод подсчета количества цифр числа. Земских Борис
{
    partial class Home
    {


        static int Count( int number)
        {
           
            int i = 0;

            while (number != 0)
            {
                number = number / 10;
                i++;
            }
            return i;

        }
       
            
            
        
    }

}
