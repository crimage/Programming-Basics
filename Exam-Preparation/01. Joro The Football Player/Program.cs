using System;

namespace _01.Joro_The_Football_Player
{
    class Program
    {
        static void Main()
        {
            string leapOrNot = Console.ReadLine();
            int hollydays = int.Parse(Console.ReadLine());
            int homeWeekends = int.Parse(Console.ReadLine());

            int homePlays = homeWeekends;
            int hollydayPlays = hollydays / 2;
            int normalPlays = (52 - homeWeekends) * 2 / 3;
            int totalPlays = homePlays + hollydayPlays + normalPlays;

            if (leapOrNot == "t")
            {
                Console.WriteLine(totalPlays + 3);
            }
            else
            {
                Console.WriteLine(totalPlays);
            }
        }
    }
}
