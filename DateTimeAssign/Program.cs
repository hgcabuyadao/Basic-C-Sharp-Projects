using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("F"));
            Console.WriteLine("\nEnter a number.");
            int number = Convert.ToInt32(Console.ReadLine());
            DateTime After = now.AddHours(number);
            Console.WriteLine("The time will be "+ After.ToString("t") + " after {0}",number + " hours!");


            Console.ReadLine();
        }
    }
}
