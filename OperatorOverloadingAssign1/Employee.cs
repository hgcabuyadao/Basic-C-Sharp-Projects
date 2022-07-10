using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssign1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        

        public static bool operator == (Employee emp1, Employee emp2)
        {
            if (emp1.Id.Equals(emp2.Id))
            {
            return true;
            }
            return false;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            if (!emp1.Id.Equals(emp2.Id))
            {
            return true;
            }
            return false;
        }
    }
}
