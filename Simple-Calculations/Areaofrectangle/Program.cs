using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areaofrectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter coordinates for x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinates for y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinates for x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinates for y2: ");
            double y2 = double.Parse(Console.ReadLine());
            double width = Math.Max(x1, x2) - Math.Min(x1, x2);
            double hight = Math.Max(y1, y2) - Math.Min(y2, y1);
            Console.WriteLine("Area =",(width*hight));
            Console.WriteLine("Perimeter={0}:",2*(width + hight)); 
        }
    }
}
