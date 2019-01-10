using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
         
            
                
                Console.WriteLine("Введите логин");
                StringBuilder login = new StringBuilder(Console.ReadLine());
                if ((login.Length >= 2) && (login.Length <= 10) && (char.IsLetter(login[0])))
                {
                    for (int i = 0; i <= login.Length - 1; i++)
                    {
                        int isLatin = System.Convert.ToInt32(login[i]);

                        if (isLatin < 128)
                        {

                        if (i == login.Length)
                            Console.WriteLine("Введен верный логин");
                                

                        }
                        else
                        {
                            Console.WriteLine("Логин может содержать только цифры и буквы латинского алфавита");
                            

                        } 
                   
                    }
                    
                }
                else
                {
                    Console.WriteLine("Логин слишком длинный или слишком короткий и первый символ должен быть буквой");

                }
                
           
            Console.ReadLine();

            
            
        }
    }
}
