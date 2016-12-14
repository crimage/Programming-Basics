using System;

namespace _05.SquareFrame
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("+");

            for (int i = 0; i < n + (n - 3); i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("-");
                }
            }

            Console.WriteLine("+");

            for (int row = 0; row < n - 2  ; row++)
            {
                for (int col = 0; col < n   ; col++)
                {
                    if (col == 0 || col == n - 1)
                    {
                        Console.Write("| ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.Write("+");

            for (int i = 0; i < n + (n - 3); i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine("+");

        }
    }
}
