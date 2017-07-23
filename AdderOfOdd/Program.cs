using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Автор Матюков Евгений
//Программа суммирует все положительные нечетные числа пока не будет введен 0


namespace AdderOfOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа суммирует все положительные нечётные числа");

            int number, sumOfOdd = 0;
            do
            {
                Console.Write("Введите целое число или 0 для завершения: ");
                number = Convert.ToInt32(Console.ReadLine());
                if ((number > 0) && (number % 2 == 1)) sumOfOdd += number;
            } while (number != 0);

            Console.WriteLine("\nСумма всех нечетных положительных чисел: " + sumOfOdd);
            Console.ReadKey();
        }
    }
}
