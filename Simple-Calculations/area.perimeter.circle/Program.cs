﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area.perimeter.circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimeter = 2.0 * Math.PI * r;
            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = " + perimeter);
        }
    }
}
