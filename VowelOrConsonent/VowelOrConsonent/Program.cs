using System;

namespace VowelOrConsonent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Alphabet:");
            char alpha = char.Parse(Console.ReadLine());
            if (alpha=='a'|| alpha=='e'||alpha=='i'||alpha=='o'||alpha=='u'||alpha=='A'||alpha=='E'||alpha=='I'||alpha=='O'||alpha=='U')
            {
                Console.WriteLine("Alphabet is Vowel");
            }
            else
            {
                Console.WriteLine("Alphabet is Consonent");
            }
        }
    }
}
