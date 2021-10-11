using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check even or odd:");
            int a = int.Parse(Console.ReadLine());
            if(a %2==0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}
