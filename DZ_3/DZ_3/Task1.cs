using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3
{
    struct Complex // дописать структуру дробей, добавив в нее вычетание и деление. Земских Борис
    {
        public double re;// обычные числа
        public double im;// числа на оси с i

        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y; 
        }
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re + im * x.im;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - (x.im);
            y.re = re - (x.re);
            return y;
        }
        public Complex Divide(Complex x)
        {
            Complex y;
            y.im = (re / x.im) + (im / x.re);
            y.re = (re / x.re) + (im / x.im);
            return y;
        }
     //z=a+b*i - комплексное число
     //z1+z2=a1+bi1+a2+bi2 - сложение
    }
}
