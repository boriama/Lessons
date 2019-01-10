using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Task2
{
    class Program
        
    {
    public delegate double Fun(double x,double a);

       
      
        public static double MyFunc(double x, double a)
        {
            return a * x * x;
        }
        public static double MyFunc2(double x, double a)
        {
            return a * Math.Sin(x);
        }


        public static void SaveFunc(Fun F,string fileName, double a,double b,double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x,a));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for(int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = br.ReadDouble();
                if (d < min) min = d;
            }
            br.Close();
            fs.Close();
            return min;
        }
        static void Main(string[] args)
        {
            SaveFunc(MyFunc,"data.bin", -100, 100, 0.5);
            Console.WriteLine(Load("data.bin"));
            Console.ReadLine();
        }
    }
}
