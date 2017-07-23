using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Автор Матюков Евгений
//Программа подсказывает насколько человеку нужно скорректировать вес

namespace BodyWeightIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            double bwindex, growth, weight, idealWeight;

            Console.WriteLine("Программа Индекс массы тела");

            Console.Write("Введите ваш рост в см: ");
            growth = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Введите ваш вес в кг: ");
            weight = Convert.ToDouble(Console.ReadLine());

            bwindex = weight / (growth * growth);
            idealWeight = growth * growth * 21;

            Console.WriteLine("\nВаш ИМТ: {0:F1}", bwindex);
            Console.WriteLine("Рекомендуемый вес при вашем росте {0:F1} кг", idealWeight);

            if (bwindex < 16) Console.WriteLine("У вас выраженный дефицит массы");
            else if (bwindex >= 16 && bwindex < 18.5) Console.WriteLine("У вас недостаточная масса тела");
            else if (bwindex >= 18.5 && bwindex < 25) Console.WriteLine("У вас нормальный вес");
            else if (bwindex >= 25 && bwindex < 30) Console.WriteLine("У вас предожирение");
            else if (bwindex >= 30 && bwindex < 35) Console.WriteLine("У вас ожирение первой степени");
            else if (bwindex >= 35 && bwindex < 40) Console.WriteLine("У вас ожирение второй степени");
            else Console.WriteLine("У вас ожирение третьей степени");

            if (bwindex < 20) Console.WriteLine("\nРекомендуем вам набрать {0:F1} кг", idealWeight - weight);
            else if (bwindex > 22) Console.WriteLine("\nРекомендуем вам сбросить {0:F1} кг", weight - idealWeight);
            else Console.WriteLine("\nВам не нужно корректировать вес");
            
            Console.ReadKey();
        }
    }
}
