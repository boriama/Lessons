using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дроби //описать класс дробей и проверить его работу. Земских Борис
{
    class Fraction
    {
        public int nominator;
        public int deNominator;

        public Fraction Pluse(Fraction x)
        {
            Fraction y = new Fraction();
            y.nominator = nominator * x.deNominator + x.nominator * deNominator;
            y.deNominator = deNominator * x.deNominator;
            return y;
            
        }
        public string ToString()
        {
            if (deNominator == 1)
            {
                
                return Convert.ToString(nominator);
            }
            else
            {
                return nominator + "/" + deNominator;
            }
        }
        public Fraction Minus(Fraction x)
        {
            Fraction y = new Fraction();
            y.nominator = nominator * x.deNominator - x.nominator * deNominator;
            y.deNominator = deNominator * x.deNominator;
            return y;
        }
        public Fraction Multi(Fraction x)
        {
            Fraction y = new Fraction();
            y.nominator = nominator * x.nominator;
            y.deNominator = deNominator * x.deNominator;
            return y;
        }
        public Fraction Devide(Fraction x)
        {
            Fraction y = new Fraction();
            y.nominator = nominator * x.deNominator;
            y.deNominator = deNominator * x.nominator;
            return y;
        }
        public Fraction NOD(Fraction x)
        {
            Fraction y = new Fraction();
            for (int i = 2; i < 100; i++)
            {
                int xyi = x.nominator % i;
                int jopa = x.deNominator % i;
                if ((xyi == 0) && (jopa == 0))
                {
                    y.nominator = x.nominator / i;
                    y.deNominator = x.deNominator / i;
                    break;
                }
            }
            return y;
        }

        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction();
            fraction1.nominator = Convert.ToInt32(Console.ReadLine());
            fraction1.deNominator = Convert.ToInt32(Console.ReadLine());

            Fraction fraction2 = new Fraction();
            fraction2.nominator = Convert.ToInt32(Console.ReadLine());
            fraction2.deNominator = Convert.ToInt32(Console.ReadLine());

            //Fraction result1 = fraction1.Pluse(fraction2);
            //Console.WriteLine("сумма:"+result1.ToString());
            //Fraction result2 = fraction1.Minus(fraction2);
            //Console.WriteLine("разница:"+result2.ToString());
            //Fraction result3 = fraction1.Multi(fraction2);
            //Console.WriteLine("произведение:"+result3.ToString());
            //Fraction result4 = fraction1.Devide(fraction2);
            //Console.WriteLine("частное:" + result4.ToString());
            //Console.ReadLine();
            Fraction result1 = fraction1.NOD(fraction1);
            Console.WriteLine(result1.ToString());
            Console.ReadLine();

        }
    }
}
