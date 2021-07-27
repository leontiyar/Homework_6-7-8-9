using System;
using System.Linq;
//Заполнить массив с клавиатуры
namespace Homework6
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
                    Console.WriteLine("Введи " + (i+1) + " элемент массива");//выводим не i а і+1 т.к так понятнее для юзеров
                    array[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            else
            {
                Console.WriteLine("Вводи числа");
            }
        }
    }
}
