using System;

namespace _01.Rectangle10Stars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int col = 0; col < n; col++)
            {
                Console.Write("*");
                for (int row = 1; row < n; row++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            
        }
    }
}
