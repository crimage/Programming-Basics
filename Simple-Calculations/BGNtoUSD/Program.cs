using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGNtoUSD
{
    class Program
    {
        static void Main(string[] args)
        {
      //    Console.Write("Enter the amount of USD: ");
            decimal bgn = decimal.Parse(Console.ReadLine());
            decimal usd = bgn * 1.79549m;
            Console.WriteLine("Bulgarian Levs: {0} BGN", Math.Round(usd, 2));

        }
    }
}
