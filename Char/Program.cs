using System;

namespace Char
{
    class Program
    {
        static void PrintLine(char symbol, uint symbolCount)
        {
            for (int i = 0; i < symbolCount; i++)
            {
                Console.Write(symbol);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character:");
            char symbol = Console.ReadKey().KeyChar;

            Console.WriteLine("\nEnter a quantity of character:");
            uint symbolCount = uint.Parse(Console.ReadLine());


            PrintLine(symbol, symbolCount);
            Console.ReadLine();
        }
    }
}
