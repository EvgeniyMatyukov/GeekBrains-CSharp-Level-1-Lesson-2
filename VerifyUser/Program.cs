using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Автор Матюков Евгений
//Программа проверяет правильность ввода логина и пароля

namespace VerifyUser
{
    class Program
    {
        static bool CorrectPassword(string login, string password)
        {
            if (login == "root" && password == "GeekBrains") return true;
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Для дальнейшей работы введите логин и пароль. У вас три попытки");

            bool pswIsCorrect = false;
            int retryCount = 0;
            do
            {
                retryCount++;
                Console.Write("Логин: ");
                string login = Console.ReadLine();

                Console.Write("Пароль: ");
                string password = Console.ReadLine();

                if (CorrectPassword(login, password))
                {
                    pswIsCorrect = true;
                    break;
                }

                Console.WriteLine("Вы неправильно ввели логин или пароль!");
            } while (retryCount < 3);

            
            if (pswIsCorrect) Console.WriteLine("Вы правильно ввели пароль");
            else Console.WriteLine("Вы недопущены в систему");

            Console.ReadKey();


        }
    }
}
