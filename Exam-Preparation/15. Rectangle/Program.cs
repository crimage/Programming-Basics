using System;

class RectangleWithStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = n * 2;
        int percentSymbol = n * 2;
        int emptySpace = (n * 2) - 2;
        int upperPart = (n - 1) / 2;
        int lowerPart = (n - 1) / 2;

        Console.WriteLine(new string('%', percentSymbol));

        for (int i = 0; i < upperPart; i++)
        {
            Console.WriteLine("%{0}%", new string(' ', emptySpace));
        }

        Console.WriteLine("%{0}**{0}%", new string(' ', (width - 4) / 2));

        for (int i = 0; i < lowerPart; i++)
        {
            Console.WriteLine("%{0}%", new string(' ', emptySpace));
        }

        Console.WriteLine(new string('%', percentSymbol));
    }
}