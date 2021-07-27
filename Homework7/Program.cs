using System;
using System.Linq;
//вывести массив в обратном порядке
namespace Homework7
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
                for (int i = length - 1; i >= 0; i--)//т.к 2 элемент по номеру 1 - счетчику присваеваем n-1
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