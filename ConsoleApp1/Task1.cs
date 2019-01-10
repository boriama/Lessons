using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Земских Борис
//1. Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double, double).
//    Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x)

namespace ConsoleApp1
{
    class Task1
    {
        public delegate double Fun(double x, double a);

        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        
        public static double MyFunc(double x, double a)
        {
            return a * x * x;
        }
        public static double MyFunc2(double x,double a)
        {
            return a * Math.Sin(x);
        }
        static void Main(string[] args)
        {
            Table(new Fun(MyFunc),5, -2, 2);
            Table(new Fun(MyFunc2), 5, -2, 2);
            Console.ReadLine();
        }
    }
}
