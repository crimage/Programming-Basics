using System;

namespace _13.Diamond
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int left = n;
            int right = 4 * n + 1;
            //upperpart
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', 3 * n));

            //middle
            while (left > 1)
            {
                for (int i = 1; i < 5 * n + 1 ; i++)
                {
                    if (i == left || i == right)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }
                left--;
                right++;
                Console.WriteLine();

            }
            //middle
            Console.WriteLine(new string('*', 5 * n));

            //down
             left = 1;
            right = 5 * n - 2;

            while (left < 2 * n + 1)
            {
                for (int i = 0; i < 5 * n; i++)
                {
                    if (i == left || i == right)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }
                left++;
                right--;
                Console.WriteLine();
            }
            Console.WriteLine("{0}{1}{0}", new string('.', 2 * n + 1), new string('*', n - 2));

        }
    }
}
