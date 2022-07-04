using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodModule4
{
    class Class1
    {
        public void divide(int p)
        {
            Console.WriteLine("Quotient = " + (p / 2));
        }
        public void divide(out int p1)
        {
            Console.WriteLine("Enter a second number: ");
            p1 = Convert.ToInt32(Console.ReadLine());
            
        }


    }
}
