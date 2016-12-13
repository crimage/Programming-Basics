using System;

namespace EqualNumbers
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num == num1 && num == num2 && num1 == num && num1 == num2
                && num2 == num && num2 == num1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
