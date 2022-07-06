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


               int a,c,e;
               string b;

                Console.WriteLine("Enter a number: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter or not a second number: ");
                b = Console.ReadLine();


                
             if (b == "")
            {
             Console.WriteLine("Sum = " + Num.Sum(a));
                }

             if (b.Length>0)
            {
            e = Convert.ToInt32(b);
            c = Num.Sum(a, e);
            Console.WriteLine("Sum = " + c);
            }

           
            
         
            Console.ReadLine();
        }
           
    }
}
