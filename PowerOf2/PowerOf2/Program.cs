using System;

namespace PowerOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Table of Power of 2:");
            int product = 2;
            for(int a=1; a<=30; a++)
            {
                int products = Convert.ToInt32(Math.Pow(product, a));

                Console.WriteLine("2 ^ " + a + " = "  + products);
            }
        }
    }
}
