using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid_Area
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.Write("Enter side b1: ");
            double b1 = double.Parse(Console.ReadLine());
          //  Console.Write("Enter side b2: ");
            double b2 = double.Parse(Console.ReadLine());
          //  Console.Write("Enter side h: ");
            double h = double.Parse(Console.ReadLine());
            double area = (b1 + b2) * h / 2.0;
            Console.WriteLine("Trapezoid area = " + area);
        }
    }
}
