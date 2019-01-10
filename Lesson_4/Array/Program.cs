using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        { // дописать класс массивов

            NewArray array = new NewArray();
            array.Fill(5, 1);
            array.Print();
            int sum = array.Sum();
            Console.WriteLine(sum);
            array.Invers();
            array.Print();
            array.Multi(2);
            array.Print();
            Console.ReadLine();

        }
    }
}
