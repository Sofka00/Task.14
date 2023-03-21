using System;

namespace Task_14._3
{
    internal class Program
    { //Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры.
      //Например, для пары 123 и 345, ответом будет являться “ДА”, а, для пары 500 и 999 - “НЕТ”.
        static void Main(string[] args)
        {
            string q = "1234";
            string w = "56789";
            bool r =false;
            for (int i = 0; i < q.Length; i++)
            {
                for (int z = 0; z < w.Length; z++)
                {
                    if (q[i] == w[z])
                    {
                        r=true;
                    }
                }
            }

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 0;
            int c = 0;

            do
            {
                a = num1 % 10;
                num1 /= 10;
                c = num2;

                do
                {

                    b = c % 10;
                    c /= 10;

                    if (a == b)
                        break;

                } while (c != 0);

                if (a == b)
                {
                    Console.WriteLine("Да");
                    break;
                }

            } while (num1 != 0);

            if (a != b)
            {
                Console.WriteLine("Нет");
            }
            Console.ReadLine();
        }
    }
}
