using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace IOAssign
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number.");

            int number = Convert.ToInt32(Console.ReadLine());
            string Num = number.ToString();
         
            File.WriteAllText(@"C:\Users\Master Quincy\Desktop\Basic_C#_Programs 2\Screenshots\Module 7\log.txt", Num);
            Console.WriteLine("You entered {0}!",Num);
            Console.ReadLine();

          





        }
    }
}
