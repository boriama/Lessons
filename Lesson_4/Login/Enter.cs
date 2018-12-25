using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Login
{
    class Enter
    {
        public void LoginAndPass()
        {
            StreamReader sr = new StreamReader("OS(C:)\\Пользователи\\user\\Документы\\Homework\\data.txt");
            string[] m = new string[2];
            for (int i = 0; i < m.Length - 1; i++)
                m[i] =sr.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите логин:");
                if (m[0] == Console.ReadLine())
                {
                    Console.WriteLine("Введите пароль:");
                    if (m[1] == Console.ReadLine())
                        break;
                    else
                    {
                        Console.WriteLine("Неверный пароль, введите заново. У вас осталось" + i + "попыток!");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Неверный пароль, введите заново. У вас осталось" + i + "попыток!");
                    Console.ReadLine();
                }
            }
        }
    }
}
