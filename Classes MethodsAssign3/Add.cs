using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_MethodsAssign3
{
    class Add
    {
        public void Numbers()
        {
            int a, b, c;
            Console.WriteLine("Enter a number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number:");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + 10;
            Console.WriteLine("Sum of 10 and "+ a + " = " + c);
            Console.WriteLine("Second number you entered is: " + b);

        }
    }
}
