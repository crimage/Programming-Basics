using System;

namespace _01.Volleyball
{
    class Program
    {
        static void Main()
        {
            string leapOrNot = Console.ReadLine();
            int hollydays = int.Parse(Console.ReadLine());
            int homeWeekends = int.Parse(Console.ReadLine());

            int homePlays = homeWeekends;
            double hollydayPlays = hollydays * 2.0 / 3.0;
            double normalPlays = (48 - homeWeekends) * 3.0 / 4.0;
            double totalplays = homePlays + hollydayPlays + normalPlays;

            if (leapOrNot == "leap")
            {
                Console.WriteLine(Math.Floor(totalplays * 1.15));
            }
            else
            {
                Console.WriteLine(Math.Floor(totalplays));
            }
        }
    }
}
