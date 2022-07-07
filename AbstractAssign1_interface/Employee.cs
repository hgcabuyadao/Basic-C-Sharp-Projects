using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssign1
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + lastName);
            base.SayName();
        }
        

        public void Quit()
        {
            Console.WriteLine("\nI don't want to quit..");
        }
    }
}