using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesandMethodsAssignment1
{
    class Assign
    {
     public int sum()
        {
            int a, b=10;
            Console.WriteLine("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            return (a + b);
        }

        public decimal Mulitply()
        {
            decimal c, d = 10;
            Console.WriteLine("\nEnter a decimal: ");
            c = Convert.ToDecimal(Console.ReadLine());
            return decimal.Multiply(c, d);
        }

        public int Add()
        {
            string f = "10";
            Console.WriteLine("\nEnter a number: ");
            string g = Console.ReadLine();
            int h = Convert.ToInt32(f);
            int i = Convert.ToInt32(g);
            return (h + i);
        }

    }
}
