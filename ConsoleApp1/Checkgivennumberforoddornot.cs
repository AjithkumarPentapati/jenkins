using System;

namespace ConsoleApp1
{
    class Checkgivennumberforoddornot
    {
        static void Main()
        {
            int num;
                Console.WriteLine("enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("given number is even ;{0}", num);
            }
            else
            {
                Console.WriteLine("given number is odd ; {0}", num);
            }
            Console.ReadKey();

        }

    }
}
