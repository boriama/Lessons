using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2//3. С клавиатуры вводятся числа, пока не будет введен 0.
    //Подсчитать сумму всех нечетных положительных чисел. Земских Борис
{
    partial class Home
    {

        static int Countable()
        {

            int number = Convert.ToInt32(Console.ReadLine());
            int inCounteble = number%2;
            int sum = 0;
            do
            {

                if (inCounteble > 0)
                {
                    sum = sum + number;
                    number = Convert.ToInt32(Console.ReadLine());
                }
                else if (inCounteble == 0)
                {
                    number = Convert.ToInt32(Console.ReadLine());
                }
            }

            while (number == 0);


            return sum;
        }
       
    }
}
