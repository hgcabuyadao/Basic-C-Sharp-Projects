using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssign1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Id = 123;
            emp1.Name = "Harvey";
           

            Employee emp2 = new Employee();
            emp2.Id = 123;
            emp2.Name = "Sage";
            

            if (emp1==emp2)
            {
                Console.WriteLine(emp1.Name+ " and "+ emp2.Name + " have the same IDs.");
            }
            else
            {
                Console.WriteLine(emp1.Name + " and " + emp2.Name + " don't have the same IDs.");
            }
            Console.ReadLine();

        }
    }
}
