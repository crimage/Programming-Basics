using System;

namespace transportPrice
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();

            double taxi = 0.70;
            double bus = 0.09;
            double train = 0.06;
            

            if (timeOfTheDay == "day" && n < 20)
            {
                Console.WriteLine((n * 0.79) + taxi);
            }
            else if (timeOfTheDay == "night" && n < 20)
            {
                Console.WriteLine((n * 0.90) + taxi);
            }
            else if (n >= 20 && n < 100)
            {
                Console.WriteLine(n * bus);                     
            }
            else if (n >= 100)
            {
                Console.WriteLine(n * train);
            }
            
        }
    }
}
