using System;

namespace Lesson1._3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите число, определяющий количество элементов формируемой последовательности:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Фибоначи через Рекурсию!");
            int RecurResult = RecurCalc(num);
            Console.WriteLine($"{num} число Фибоначчи = {RecurResult}");


            Console.WriteLine("Фибоначи через Цикл!");
            int Result = Calc(num);
            Console.WriteLine($"{num} число Фибоначчи = {Result}");

            Console.ReadKey();
        }
        public static int RecurCalc(int x)                      //рукурсивно
        {
            if (x == 0)
            {
                return 0;
            }
            else if (x == 1)
            {
                return 1;
            }

            return RecurCalc(x - 1) + RecurCalc(x - 2);
        }
        public static int Calc(int x)                           //цикл
        {
            int f1 = 0;
            int f2 = 1;
            int temp;

            for (int i = 0; i < x; i++)
            {
                temp = f1;
                f1 = f2;
                f2 += temp;
            }
            return f1;
        }
    }
}


