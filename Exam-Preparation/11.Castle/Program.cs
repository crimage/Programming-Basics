using System;

namespace _11.Castle
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            //firstRow
            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', n / 2), new string ('_', 2 * n - ((n / 2) * 2 + 4)));
            //middleRow
            for (int row = 0; row < n - 2; row++)
            {
                char middle = ' ';

                if (row == n - 3)
                {
                    middle = '_';
                }

                Console.WriteLine("|{0}{1}{0}|" , new string (' ', (n / 2) + 1), new string (middle, 2 * n - ((n / 2) * 2 + 4)));
                                
            }
            //bottomRow
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n / 2), new string(' ', 2 * n - ((n / 2) * 2 + 4)));
        }
    }
}
