using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            DateTime after1000days = date.AddDays(999);
            Console.WriteLine(after1000days.ToString("dd-MM-yyyy"));
        }
    }
}
