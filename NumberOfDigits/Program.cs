using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Автор Матюков Евгений
//Программа показывает количество цифр в числе
namespace NumberOfDigits
{
    class Program
    {
        static int QuantityDigits(int number)
        {
            int digits = 0;

            do
            {
                number /= 10;
                digits++;
            } while (number > 0);

            return digits;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число, программа покажет количество цифр в нем");

            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nЗнаков в числе: " + QuantityDigits(number));

            Console.ReadKey();

        }
    }
}
