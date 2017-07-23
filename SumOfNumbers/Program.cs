using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Автор Матюков Евгений
//Программа рекурсивно вычисляет сумму целых чисел от a до b

namespace SumOfNumbers
{
    class Program
    {
        static int Sum(int a, int b)
        {
            Console.WriteLine(a);
            if (a == b) return a;
            return (a + Sum(++a, b));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа рекурсивно вычисляет сумму целых чисел от a до b");

            int a, b;
            
            do
            {
                Console.Write("Введите a: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите b: ");
                b = Convert.ToInt32(Console.ReadLine());

            } while(a > b);


            Console.Write("\nCумма чисел: " + Sum(a,b));

            Console.ReadKey();

        }
    }
}
