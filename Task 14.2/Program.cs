using System;
using System.Security.Cryptography.X509Certificates;

namespace Task_14._2
{ //2) Пользователь вводит 2 числа (A и B). Вывести количество простых чисел
  //(которые делятся только на 1 и самих себя) в диапазоне от A до B.
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int count1 = 0;
            for (int i = a; i <= b; i++)
            {
                for (int z = 1; z <= i; z++)
                { 
                    if (i%z==0) 
                    { 
                        count1++;
                    } 

                    
                }
               if (count1== 2)
                {
                    count++;
                }
                
                    count1 = 0;
            }
             Console.WriteLine(count);
        } 
        }

    }


