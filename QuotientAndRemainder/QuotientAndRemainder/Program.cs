using System;

namespace QuotientAndRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to be divided:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the divisor:");
            int divisor = int.Parse(Console.ReadLine());
            int quotient = number / divisor;
            int remainder = number % divisor;
            Console.WriteLine("The Quotient is: " +quotient);
            Console.WriteLine("The remainder is: " +remainder);
        }
    }
}
