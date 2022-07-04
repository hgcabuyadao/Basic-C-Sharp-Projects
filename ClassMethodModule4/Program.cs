using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodModule4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 p1 = new Class1();
            Console.WriteLine("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            p1.divide(x);

            int y;
            p1.divide(out y);
            Console.WriteLine("You entered number: " + y);
            Console.ReadLine();
        }
        
       
    }
}
