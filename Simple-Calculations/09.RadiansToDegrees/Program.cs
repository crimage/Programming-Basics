using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angle.and.radian
{
    class Program
    {
        static void Main(string[] args)
        {
     //     Console.Write("Enter radian angle: ");
            double rad = double.Parse(Console.ReadLine());
            double deg = rad * 180 / Math.PI;
            Console.WriteLine("Radian degree :" + Math.Round(deg));
        }
    }
}
