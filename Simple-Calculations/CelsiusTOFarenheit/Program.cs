using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusTOFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
       //   Console.Write("Enter Temperature in Celcius :");
            double Celcius = double.Parse(Console.ReadLine());
            double Farenheit = Celcius * 9 / 5 + 32;
            Console.WriteLine("The temperature in Farenheit is: " + Math.Round(Farenheit, 2));
        }
    }
}
