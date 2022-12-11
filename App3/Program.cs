using System;

namespace App3
{
    class Program
    {

        static void PrintLine(string symbol, uint symbolCount)
        {
            for (int i = 0; i < symbolCount; i++)
            {
                Console.Write(symbol);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a symbol:");
            string symbol = Console.ReadLine();

            Console.WriteLine("Enter a quantity of symbol:");
            uint symbolCount = uint.Parse(Console.ReadLine());


            PrintLine(symbol, symbolCount);
            Console.ReadLine();
        }
    }
}
