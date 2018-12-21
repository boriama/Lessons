using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2//5. а) Написать программу, которая запрашивает массу и рост человека,
    //вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
//    б)* Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
//Земских Борис
 {
    partial class Home
    {
       
        static void Imt()
        {
            Console.WriteLine("Введите ваш вес.");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ваш рост.");
            double h = Convert.ToDouble(Console.ReadLine());
            h = h / 100;
            double imt = m / (h * h);
            double optimum;
            if (imt >= 18.5 && imt <= 25.0)
            {
                Console.WriteLine("Ваш вес в норме. Ваш индкс массы : " + imt);
               

            }
            else if (imt < 18.5)
            {
                optimum = ((18.5 * (h * h)) - m) * (-1);

                Console.WriteLine("Ваш индкс массы : " + imt + "Ваш вес мал. Вам нужно набрать " + optimum + " килограмм.");

            }
            else if (imt > 25)
            {
                optimum = ((25 * (h * h)) - m) * (-1);
                Console.WriteLine("Ваш индкс массы : " + imt + "Ваш вес велик. Вам нужно похудеть на" + optimum + " килограмм");
            }
        }

    }

    
}
