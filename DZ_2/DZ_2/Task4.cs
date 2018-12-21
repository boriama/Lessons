using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2//4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
             //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
             //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
               //С помощью цикла do while ограничить ввод пароля тремя попытками.
               //Земских Борис
{
    partial class Home
    {



        static void LoginAndPass(string userLogin, string userPass)
        {
            Console.WriteLine("Введите логин и пароль");

            string login = "root";
            string pass = "GeekBrains";


            bool trueLogin = true;
            bool truePass = true;

           
            int i = 0;
            do
                if (trueLogin != String.Equals(userLogin, login))
                {
                    Console.WriteLine("Неверный логин. Введите новый логин.");
                    userLogin = Console.ReadLine();
                    i++;
                }
                else if (truePass != String.Equals(userPass, pass))
                {
                    Console.WriteLine("Неверный пароль. Введите новый пароль.");
                    userPass = Console.ReadLine();
                    i++;
                }
                else if ((truePass = String.Equals(userPass, pass)) && (trueLogin = String.Equals(userLogin, login)))
                {
                    Console.WriteLine("Верный логин и пароль");
                    break;
                } while (i <= 3);
        }



        


    }
}
