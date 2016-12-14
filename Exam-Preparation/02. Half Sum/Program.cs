using System;

namespace _02.Half_Sum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int odd = 0;
            int even = 0;

            for (int i = 0; i < 2*n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    odd = odd + a;
                }
                else
                {
                    even = even + a;
                }
            }

            if (even == odd)
            {
                Console.WriteLine("Yes, sum={0}", odd);
            }

            else if (odd > even)
            {
                Console.WriteLine("No, diff={0}", odd - even);
            }
            else
            {
                Console.WriteLine("No, diff={0}", even - odd);
            }
        }
    }
}
