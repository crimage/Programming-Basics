using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SunglassesV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                if 
                               
                for (int col = 0; col < 5 * n; col++)
                {
                    if (col > 2 * n -1  && col < 3 * n)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                    
                    
                }
                Console.WriteLine();
            }
        }
    }
}
