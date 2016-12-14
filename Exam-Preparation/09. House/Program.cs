using System;

namespace _09.House
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int left = n / 2;
            int right = left;
            if (n % 2 == 0)
            {
                left--;
            }

            while (left >= 0)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i >= left && i <= right)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('-');
                    }
                    
                }
                left--;
                right++;
                Console.WriteLine();
            }

            for (int row = 0; row < n / 2; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == 0 || col == n - 1)
                    {
                        Console.Write('|');
                    }
                    else
                    {
                        Console.Write('*');
                    }
                    
                }
                Console.WriteLine();
            }

            
        }
    }
}
