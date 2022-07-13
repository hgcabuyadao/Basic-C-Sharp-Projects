using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssign
{
    class Emp
    {
        public string FName { get; set; }
        public string Lname { get; set; }
        public int Id { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {

            List<Emp> Employees = new List<Emp>()
            {
            new Emp() { FName = "Joe", Lname = "Lukas", Id = 1 },
            new Emp() { FName = "Joe", Lname = "Sage", Id = 2 },
            new Emp() { FName = "Harvey", Lname = "Cabu", Id = 3 },
            new Emp() { FName = "Quin", Lname = "Sy", Id = 4 },
            new Emp() { FName = "Marie", Lname = "Tes", Id = 5 },
            new Emp() { FName = "Alex", Lname = "Patullo", Id = 6 },
            new Emp() { FName = "Bunch", Lname = "Choi", Id =7 },
            new Emp() { FName = "Ming", Lname = "Yao", Id = 8 },
            new Emp() { FName = "Fremont", Lname = "Murphy", Id = 9 },
            new Emp() { FName = "Noena", Lname = "Marcos", Id = 10 }
            };
            Console.WriteLine("Using for each:");

            foreach (Emp emp in Employees)
            {
                if (emp.FName == "Joe")
                {
                    Console.WriteLine(emp.FName + " " + emp.Lname);
                }

            }

            Console.WriteLine("\n\nUsing Lambda: Employees with the first name Joe ");
            List<Emp> EmpList = Employees.Where(x => x.FName == "Joe").ToList();
            foreach (Emp emp1 in EmpList)
            {
                Console.WriteLine(emp1.FName + " " + emp1.Lname);
            }

            Console.WriteLine("\n\nUsing Lambda: Employees with an Id number greater than 5");
            List<Emp> IDList = Employees.Where(x => x.Id > 5).ToList();
            foreach (Emp ids in IDList)
            {
                Console.WriteLine(ids.FName + " " + ids.Lname);
            }





            Console.ReadLine();


        }
        
    }
}
