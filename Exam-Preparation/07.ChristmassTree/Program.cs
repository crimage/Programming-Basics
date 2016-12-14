using System;

namespace _07.ChristmassTree
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row <= n; row++)
            {
                Console.Write(new string (' ', n - row));
                
                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }

                Console.Write(" | ");

                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
