using System;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, N;
            Console.Write("Enter the Number : ");
            N = int.Parse(Console.ReadLine());
            for (i=1; i<=N; i++)
            {
                if (N % i ==0)
                {
                    bool isPrime = true;
                    for (int j=1; j<i; j++)
                    {
                        if (i % j==0)
                        {
                            isPrime = false;

                        }
                        else
                        {
                            isPrime = true;
                            Console.WriteLine("Prime factor of " + N + " is " + i);
                        }
                    }
                }
            }
            
        }
    }
}
