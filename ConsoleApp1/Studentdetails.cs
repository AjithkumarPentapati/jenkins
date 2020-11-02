using System;

namespace ConsoleApp1
{
    class Studentdetails
    {
        static void Main()
        {
            string studentname;
            int studentid,standard;
            Console.WriteLine("Enter studentname");
            studentname = Console.ReadLine();
            Console.WriteLine("Enter studentid");
            studentid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter standard");
            standard = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(".............................");
            Console.WriteLine("studentname;{0} || studentid;{1} || standard;{2}", studentname, studentid, standard);
            Console.Read();


        }
    }
}