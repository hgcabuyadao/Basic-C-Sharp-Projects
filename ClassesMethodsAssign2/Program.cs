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
           
            
                Addition Num = new Addition();


               int a,e;
               string b;

                Console.WriteLine("Enter a number: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter or not a second number: ");
                b = Console.ReadLine();

            if (b == "")
            {
             Console.WriteLine("Sum = " + Num.Sum(a));
              }

             else
            {
                e = Convert.ToInt32(b);
                Console.WriteLine("Sum = " + Num.Sum(a, e));
            }
                
           

           
            
         
            Console.ReadLine();
        }
           
    }
}
