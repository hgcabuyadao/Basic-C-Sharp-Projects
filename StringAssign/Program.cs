using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenate two string variables
            string firstName = "Harvey";
            string lastName = "Cabuyadao";
            string name = firstName + " " + lastName;
            Console.WriteLine(name);

            //Convert a string to uppercase
            string Upper = name.ToUpper();
            Console.WriteLine(Upper);

            // StringBuilder
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello ");
            sb.AppendLine("World!");
            sb.AppendLine("Hello C#");
            Console.WriteLine(sb);


            Console.ReadLine();

        }
    }
}
