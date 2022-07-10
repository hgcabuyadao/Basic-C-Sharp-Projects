using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<int> Number = new Employee<int>();
            Number.things.Add(3);
            Number.things.Add(2);
            Number.things.Add(1);
            Number.things.Add(0);

            Employee<string> Letters = new Employee<string>();
            Letters.things.Add("H");
            Letters.things.Add("A");
            Letters.things.Add("R");
            Letters.things.Add("V");
            Letters.things.Add("E");
            Letters.things.Add("Y");

            for (int i = 0; i < Number.things.Count; i++)
            Console.WriteLine(Number.things[i]);
            Console.WriteLine("\n");
            for (int i = 0; i < Letters.things.Count; i++)
            Console.WriteLine(Letters.things[i]);


            Console.ReadLine();

        }
    }
}
