using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year:");
            int year = int.Parse(Console.ReadLine());
            if (((year % 4==0) && (year % 100 !=0)) || (year % 400==0))
            {
                Console.WriteLine(year + "is Leap Year");

            }
            else
            {
                Console.WriteLine(year + "is not Leap Year");
            }
        }
    }
}
