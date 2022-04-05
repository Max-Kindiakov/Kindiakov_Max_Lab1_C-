using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            var numbers = Console.ReadLine().Split(',').Select(Int32.Parse).ToList();

            var firstHalf = from x in numbers where x % 2 == 0 select x;
            var secondHalf = from x in numbers where x % 2 != 0 select x;
            Console.WriteLine();
            foreach (Int32 item in firstHalf)
            {
                Console.WriteLine(item.ToString());
            }
            foreach (Int32 item in secondHalf)
            { Console.WriteLine(item.ToString());}
            Console.ReadKey();

        }
    }
}
