using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me your age.");
            try
            {
                int Age = Convert.ToInt32(Console.ReadLine());

                if (Age <= 0)
                {
                    throw new ArgumentException();
                }
                DateTime myDateTime = DateTime.Now;
                string yearpresent = myDateTime.Year.ToString();
                int Birth = Convert.ToInt32(yearpresent);
                int BirthYear = Birth - Age;
                Console.WriteLine("Your birth year is {0} ", BirthYear + ".");
                Console.ReadLine();

            }
            catch (ArgumentException)
            {
                Console.Write("Something you entered is incorrect. Please enter digits only. ");
                Console.ReadLine();
               
            }
        
            catch (Exception)
            {
                Console.Write("An error occurred.");
                Console.ReadLine();
            }
        }
    }
}
