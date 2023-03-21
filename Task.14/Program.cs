using System;

namespace Task._14
{
    //1) Пользователь вводит положительное число (A). Вывести сумму всех цифр у чисел из диапазона от 0 до A.
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < b; i++)
            {
                int s = 0;
                int crnt = i;
                while (crnt != 0)
                {
                    int tmp = crnt % 10;
                    s += tmp;
                    crnt /= 10;

                }
                Console.WriteLine($"Сумма цифр {i} = {s} ");

            }
        }
    }
}
