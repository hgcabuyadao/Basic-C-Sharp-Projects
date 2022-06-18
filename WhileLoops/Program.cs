using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Guess a day.");
            string day = Console.ReadLine();
            bool isGuessed = day == "Sunday";

            while (!isGuessed)
            {
                switch (day)
                {
                    case "Monday":
                        Console.WriteLine("You guessed Monday. Try again");
                        Console.WriteLine("Guess a day.");
                        day = Console.ReadLine();
                        break;
                    case "Tuesday":
                        Console.WriteLine("You guessed Tuesday. Try again");
                        Console.WriteLine("Guess a day.");
                        day = Console.ReadLine();
                        break;
                    case "Wednesday":
                        Console.WriteLine("You guessed Wednesday. Try again");
                        Console.WriteLine("Guess a day.");
                        day = Console.ReadLine();
                        break;
                    case "Thursday":
                        Console.WriteLine("You guessed Thursday. Try again");
                        Console.WriteLine("Guess a day.");
                        day = Console.ReadLine();
                        break;
                    case "Friday":
                        Console.WriteLine("You guessed Friday. Try again");
                        Console.WriteLine("Guess a day.");
                        day = Console.ReadLine();
                        break;
                    case "Saturday":
                        Console.WriteLine("You guessed Saturday. Try again");
                        Console.WriteLine("Guess a day.");
                        day = Console.ReadLine();
                        break;
                    case "Sunday":
                        Console.WriteLine("You guessed it right! Sunday is the day.");
                        isGuessed = true;
                        break;

                }
                Console.ReadLine();
            }
        }
    }
}

