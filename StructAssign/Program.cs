using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Number Num1 = new Number();
            Num1.Amount = 15.12M;


            Console.WriteLine("Value is: " + Num1.Amount);

            Console.ReadLine();
            



        }



    }
    struct Number
    {
        public decimal Amount { get; set; }
    }
}
