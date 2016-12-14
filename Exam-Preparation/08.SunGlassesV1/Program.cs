using System;
class SunGlasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = n * 2;
        // first line
        Console.Write(new string('*', width));
        Console.Write(new string(' ', n));
        Console.WriteLine(new string('*', width));
        // end first line

        // MIddle Line
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(new string('*', n / n));
            Console.Write(new string('/', width - 2));
            Console.Write(new string('*', n / n));
            if (i == n / 2 - 1)
            {
                Console.Write(new string('|', n));
                Console.Write(new string('*', n / n));
                Console.Write(new string('/', width - 2));
                Console.WriteLine(new string('*', n / n));
            }
            else
            {
                Console.Write(new string(' ', n));
                Console.Write(new string('*', n / n));
                Console.Write(new string('/', width - 2));
                Console.WriteLine(new string('*', n / n));
            }

        }
        // End MIddle


        // last line
        Console.Write(new string('*', width));
        Console.Write(new string(' ', n));
        Console.WriteLine(new string('*', width));
        // end last line
    }
}