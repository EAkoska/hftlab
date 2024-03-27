using System;

namespace lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("0");
            for (int i = 1; i <= number; i++)
            {
                Console.Write(", " + i);
            }
        }
    }
}
