using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_MethodsAssign3
{
    class Add
    {
        public void Numbers(int p, int q)
        {
           
        Console.WriteLine("Enter a number:");
        p = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a second number:");
        q = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Sum of 10 + " + p + " = " + (10+p));
        Console.WriteLine("Second number you entered is: " + q);


        }
    }
}
