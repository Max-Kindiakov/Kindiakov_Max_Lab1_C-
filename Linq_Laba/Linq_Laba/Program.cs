using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Laba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Int32> numbers = new List<Int32>() { 1, -3, -7, -8, -84, 321, -45, 26, -81, -34, -26, 22};

            var result =  numbers.Where(x => x < 0 && x % 2 == 0).OrderByDescending(x => x).Distinct().Reverse();

            foreach (Int32 x in result)
            {
                Console.WriteLine(x);
                               
            }
            Console.ReadKey();

        }
    }
}
