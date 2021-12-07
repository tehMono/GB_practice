using System;

namespace Lesson1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Начинаем проверку числа!\nВведите число: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Simple_or_not(number));
        }
        static string Simple_or_not(int number)
        {
            int d = 0;
            int i = 2;

            if (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }
                else
                {
                    i++;
                }
            }
            else
            {
                if (d == 0)
                {
                    return "Простое";
                }
            }

            return "Не простое";
        }

    }
}
