using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssign1
{
    
    class Employee : Person, IQuittable
    {
      public string ManagerName { get; set; }
        public override void SayName()
        {
           

            Console.WriteLine("Name: " + firstName + lastName);
            base.SayName();
        }
        

        public void Quit()
        {
            Console.WriteLine("\nIf you want to quit, call Harvey ");
        }
     
        
    }
}