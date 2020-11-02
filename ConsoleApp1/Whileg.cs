using System;

namespace ConsoleApp1
{
    class Whileg
    {
        static void Main()
        {
            int endvalue,initialvalue = 1;
            Console.WriteLine("enter the number");
            endvalue = Convert.ToInt32(Console.ReadLine());
            while (initialvalue <= endvalue)
            {
                initialvalue++;
                    if(initialvalue%2 ==0)
                {
                    Console.WriteLine("{0} is even ", initialvalue);
                }
            }
            Console.Read();
        }
    }
}
