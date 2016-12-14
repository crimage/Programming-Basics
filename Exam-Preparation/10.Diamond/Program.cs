using System;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int left = n / 2;
            int right = left;
            if (n % 2 == 0)
            {
                left--;
            }
            //upside
            while (left >= 0)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == left || col == right)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                left--;
                right++;
                Console.WriteLine();

            }
            //downside
            left = 1;
            right = n - 2;
            while (left <= right)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == left || col == right)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                left++;
                right--;
                Console.WriteLine();

            }
        }
    }
}