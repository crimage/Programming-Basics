﻿using System;

namespace _14.Diamond_012016
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row <= n; row++)
            {
                Console.Write(new string (' ', n - row));
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int row = n - 1; row >= 0; row--)
            {
                Console.Write(new string(' ', n - row ));
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("* ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
