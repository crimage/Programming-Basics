using System;

namespace _01.Work_Hours
{
    class Program
    {
        static void Main()
        {
            int projectHours = int.Parse(Console.ReadLine());
            int daysToFinish = int.Parse(Console.ReadLine());
            int productivity = int.Parse(Console.ReadLine());

            double biking = daysToFinish - (daysToFinish * 0.1);
            double workingHours = Math.Round(biking * 12);
            double productivityHours = Math.Floor((workingHours * productivity ) / 100);
            double projectDone = productivityHours - projectHours;

            if (projectHours < projectDone)
            {
                Console.WriteLine("No");
                Console.WriteLine("{0}", projectDone);
            }
            else
            {
                Console.WriteLine("Yes");
                Console.WriteLine("{0}", projectHours - projectDone);
            }

        }
    }
}
