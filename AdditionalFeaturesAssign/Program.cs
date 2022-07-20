using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesAssign
{
    class Program
    {
        public int Age;
        public string LastName;

        static void Main(string[] args)
        {
            const string Me = "Harvey";
            var varInt = 1;
            var varChar = 'h';
            var varString = "abcdef";
            Console.WriteLine("{0}\n{1}\n{2}", varInt, varChar, varString);

            Program Myself = new Program();
            Console.WriteLine("My name is {0} ",Me +" "+ Myself.LastName + " and I am "+ Myself.Age + " years old.");
            Console.ReadLine();
        }

        public Program ():this(20,"Cabuyadao")
        {
            
          
        }

        public Program(int Age,string LastName)
        {
            this.Age = Age;
            this.LastName = LastName;
        }
        
    }

}
