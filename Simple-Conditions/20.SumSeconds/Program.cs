using System;

namespace SumSeconds
{
    class Program
    {
        static void Main()
        {
            int player = int.Parse(Console.ReadLine());
            int player1 = int.Parse(Console.ReadLine());
            int player2 = int.Parse(Console.ReadLine());

            int totalTime = player + player1 + player2;

            int mins = totalTime / 60;
            int seconds = totalTime % 60;
            Console.WriteLine("{0}:{1}", mins, seconds.ToString().PadLeft(2, '0'));
            
        }
    }
}
