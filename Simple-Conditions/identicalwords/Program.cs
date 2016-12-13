using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace identicalwords
{
    class Program
    {
        static void Main(string[] args)
        {
            //string word = null;
            string word1 = null;
            string word = null;

            word = Console.ReadLine().ToLower();
            word1 = Console.ReadLine().ToLower();
            if (word == word1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
