using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b=10,c,d,e;
            MathOps Operation = new MathOps();
            Console.WriteLine("Enter a number: ");

            a = Convert.ToInt32(Console.ReadLine());
            c = Operation.Sum(a,b);
            d = Operation.Multiply(a,b);
            e = Operation.Subtract(a,b);

            Console.WriteLine("Sum = " + c);
            Console.WriteLine("Product = " + d);
            Console.WriteLine("Difference = " + e);


            Console.ReadLine();

        }
    }
}

