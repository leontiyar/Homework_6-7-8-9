using System;
using System.Linq;
//Найти найменьшее число в массиве
namespace Homework9
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
                int min = array[0];
                for (int i = 0; i < length; i++)
                {
                    //Каждый элемент сравниваем с текущим минимумом
                    if (array[i] < min)//Если он меньше - то он новый минимум
                    {
                        min = array[i];
                    }
                }
                Console.WriteLine("Минимальное значение = " + min);
            }
            else
            {
                Console.WriteLine("Вводи числа");
            }
        }
    }
}
