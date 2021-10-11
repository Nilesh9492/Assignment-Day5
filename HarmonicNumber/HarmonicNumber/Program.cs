using System;

namespace HarmonicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, a;
            double sum = 0;
            Console.WriteLine("The Harmonic Series:");
            Console.Write("Enter the number of terms required in series:");
            N = int.Parse(Console.ReadLine());
            for (a=1; a<=N; a++)
            {
                Console.Write("1/{0} + ", a);
                sum= sum+ 1 / a;
            }
            Console.WriteLine("Sum of Series is : " + sum);
        }
    }
}
