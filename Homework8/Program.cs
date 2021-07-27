using System;
using System.Linq;
//найти сумму четных чисел в массиве
namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Введи к-во элементов массива");
            bool smart = int.TryParse(Console.ReadLine(), out int length);
            int[] array = new int[length];
            if (smart)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine("Введи " + (i + 1) + " элемент массива");
                    array[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                int sum = 0;
                int sumnum = 0;
                for (int i = 0; i < length; i++)
                {
                    //знач = [первый операнд - условие] ? [второй операнд if_true] : [третий операнд if_false]
                    sumnum = i % 2 != 0 ? sumnum += array[i] : sumnum;//Практикую использование тернарного оператора
                    sum = array[i] % 2 == 0 ? sum += array[i] : sum;
                }
                Console.WriteLine("Сумма четных номеров: " + sumnum);
                Console.WriteLine("Сумма четных чисел: " + sum);
            }
            else
            {
                Console.WriteLine("Вводи числа");
            }
        }
    }
}
