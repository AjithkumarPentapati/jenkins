using System;

namespace ConsoleApp1
{
    class Switcheg
    {
        static void Main()
        {
            int num;
            Console.WriteLine("enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
                case 1:
                    {
                        Console.WriteLine("Monday");
                       break;
                    }

                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("invalid number");
                    break;
            }
            Console.Read();
        }

    }
}
