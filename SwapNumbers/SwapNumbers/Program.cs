using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number A=");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Enter second number B=");
            int B = int.Parse(Console.ReadLine());
            int C = A;
            A = B;
            B = C;
            Console.WriteLine("After swapping A="+A);
            Console.WriteLine("After swapping B="+B);

        }
    }
}
