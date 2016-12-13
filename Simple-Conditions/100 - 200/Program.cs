using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100___200
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = int.Parse(Console.ReadLine());
            if (result < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (result <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
