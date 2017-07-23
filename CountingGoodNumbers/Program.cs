using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Автор Матюков Евгений
//Программа подсчитывает количество чисел от 1 до 1000000000, которые делятся без остатка на сумму своих цифр

namespace CountingGoodNumbers
{
    class Program
    {
        static int SumOfNumbers(int number) //возвращает сумму цифр числа
        {
            int sum = 0;
            do
            {
                sum += number % 10;
                number /= 10;
            } while (number > 0);

            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа подсчитывает количество чисел от 1 до 1000000000, которые делятся без остатка на сумму своих цифр");

            DateTime start = DateTime.Now;
            Console.WriteLine("\nПодсчет начался в " + start);

            int amountOfNumbers = 0; //количество хороших чисел
            for (int i = 1; i < 1000000000; i++)
            {
                //Console.WriteLine(i + "    " + SumOfNumbers(i));
                if (i % SumOfNumbers(i) == 0) //число делится без остатка?
                {
                    amountOfNumbers++;
                //    Console.WriteLine("ok");
                }
            }

            DateTime finish = DateTime.Now;

            Console.WriteLine("Подсчет закончился в " + finish);
            Console.WriteLine("Подсчет длился " + (finish - start));

            Console.WriteLine("\nХороших чисел: " + amountOfNumbers);
            Console.ReadKey();
        }
    }
}
