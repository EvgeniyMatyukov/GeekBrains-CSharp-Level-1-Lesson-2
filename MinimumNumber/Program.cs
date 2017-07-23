using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Автор Матюков Евгений
//Программа выбирает минимальное число из трех
namespace MinimumNumber
{
    class Program
    {
        static int NumberMin(int[] numbers)
        {
            int? numberMin = null;

            foreach (var number in numbers) //
            {
                if (numberMin == null || numberMin > number) numberMin = number;
            }

            return (int)numberMin;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите три целых числа, программа выберет минимальное");

            int[] number = new int[3];

            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Введите {i}-ое число: ");
                number[i-1] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("\nМинимальное число: " + NumberMin(number));

            Console.ReadKey();
        }
    }
}
