﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min_and_sec
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());


            int seconds = (num1 + num2 + num3);
            int min = seconds / 60;
            seconds = seconds % 60;

            Console.WriteLine("{0}:{1}", min, seconds.ToString().PadLeft(2, '0'));

        }
    }
}
