using System;

namespace LargestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers to compare:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if(a>b)
            {
                if (a>c)
                {
                    Console.WriteLine(a+ " is Largest number among given input.");
                }
                else
                {
                    Console.WriteLine(c+ " is Largest number among given input.");
                }
            }
            else if(b>c)
            {
                Console.WriteLine(b+ " is Largest number among given input.");
            }
            else
            {
                Console.WriteLine(c+ " is Largest number among given input.");
            }
        }
    }
}
