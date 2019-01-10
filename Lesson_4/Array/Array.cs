using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class NewArray
    {
        int[] a;

        public void Print()
        
        {
            for (int i = 0; i < a.Length; i++) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }
        public void Change(int n, int[] a)
        {

            for (int i = 0; i < n; i++)
                if (a[i] < 0) a[i] = -a[i];
            // изменяются элементы массива 
        }
        public void Fill(int n,int m)
            {
            a = new int[n];
                for(int i =0; i<n; i++)
                a[i] = a[i] + m*i;
          
            }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < a.Length - 1; i++)
                sum = a[i] + a[i + 1];
            return sum;
        }
        public void Invers()
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = -a[i];
        }
        public void Multi(int n)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = a[i] * n;
        }
    }
}
