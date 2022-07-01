using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesandMethodsAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Assign m1 = new Assign();
            int y = m1.sum();
            Console.WriteLine("Sum = " + y);


            Assign m2 = new Assign();
            decimal x = m2.Mulitply();
            Console.WriteLine("Product = " + x);


            Assign m3 = new Assign();
            int w = m3.Add();
            Console.WriteLine("Sum = " + w);




            Console.ReadLine();
        }
        
    }
}
