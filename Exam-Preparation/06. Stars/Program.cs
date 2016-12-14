﻿using System;

namespace _06.Stars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int row = 1; row <= n; row++)
            {

                Console.Write(new string (' ', n - row ));
                for (int col = 0; col < 2 * row - 1 ; col++)
                {
                    if (col % 2 == 0)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
            }

            for (int row = n - 1; row >= 0; row--)
            {
                Console.Write(new string(' ', n - row ));
                for (int col = 0; col < 2 * row - 1; col++)
                {
                    if (col % 2 == 0)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
