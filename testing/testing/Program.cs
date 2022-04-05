using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання2Лаба1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var items = new Dictionary<string, double>();

            

            items.Add("item1", 45.50); 
            items.Add("item2", 35);
            items.Add("item3", 41.30);
            items.Add("item4", 55);
            items.Add("item5", 24);

            var sortedItems = (from number in items
                               orderby number.Value
                               descending
                               select number).ToDictionary
                            (
                            pair => pair.Key,
                            pair => pair.Value
                            ).Take(3);
            

            foreach (var x in sortedItems)
            Console.WriteLine("{0}  {1}", x.Key, x.Value);

            Console.ReadKey();
        }
    }
}
