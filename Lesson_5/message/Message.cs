using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace message
{
    class Message
    {
        StringBuilder str = new StringBuilder();

       public static void NoMoreThenXLetters(StringBuilder str, int x)
        {
            for (int i = 0; i < str.Length;) {
                if (char.IsPunctuation(str[i]))
                {
                    str.Remove(1, i);
                }
                else
                {
                    i++;
                }

            }
            string array = str.ToString();
            string[] s = array.Split(' ');
            for(int i = 0; i<s.Length; i++)
            {
                
                if ((s[i].Length) == x) {
                    Console.WriteLine(s[i]);

                }
            }
        }
         public static void EndLetter(StringBuilder str,char sim)
        {
            
            string array = str.ToString();
            string[] s = array.Split(' ');
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i][s[i].Length-1] == sim)
                {
                    str.Remove(1, i);
                }

            }
             
        }
    }
}
