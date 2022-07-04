using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMethodsAssign2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                Addition Num = new Addition();


                int a,b,c;
               

                Console.WriteLine("Enter first number: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a second number: ");
                b = Convert.ToInt32(Console.ReadLine());
               


                c = Num.Sum(a, b);
                Console.WriteLine("Sum = " + c);

                
            }
            catch(FormatException)
            {
              ;

                Console.WriteLine("You need to enter a second number");
            }
            Console.ReadLine();
        }
    }
}
