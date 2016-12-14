using System;

namespace _12.Butterfly
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //Upperpart
            for (int row = 0; row < (2 * (n - 2) + 1) / 2; row++)
            {
                if (row % 2 == 0)
                {
                    Console.Write("{0}\\ /{0}", new string('*', n - 2));
                }
                else
                {
                    Console.Write("{0}\\ /{0}", new string('-', n - 2));
                }

                Console.WriteLine();
            }
            //middle
            Console.WriteLine("{0}@{0}", new string(' ', n - 1));

            //bottom
            for (int row = 0; row < (2 * (n - 2) + 1) / 2; row++)
            {
                if (row % 2 == 0)
                {
                    Console.Write("{0}/ \\{0}", new string('*', n - 2));
                }
                else
                {
                    Console.Write("{0}/ \\{0}", new string('-', n - 2));
                }

                Console.WriteLine();
            }
        }
    }
}
