using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace message
{
    class Program
    {
        static void Main(string[] args)
        {
           StringBuilder str = new StringBuilder(Console.ReadLine());
            Message.EndLetter(str,'а');
            Message.NoMoreThenXLetters(str, 4);
            Console.ReadLine();
        }
    }
}
