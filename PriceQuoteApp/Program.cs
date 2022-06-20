using System;

class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to Package Express \n\nPlease follow the instructions below.");

        Console.WriteLine("\n\nPlease enter the package weight:");
        decimal Weight = Convert.ToDecimal(Console.ReadLine());

        if (Weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
        }
        else
        {
            Console.WriteLine("Please enter the package width:");
            decimal Width = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            decimal Height = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the package lenght:");
            decimal Lenght = Convert.ToDecimal(Console.ReadLine());

            decimal TotalDim = Width + Height + Lenght;
            decimal Area = (Width * Height * Lenght) * Weight;
            decimal TotalPrice = Area / 100;


            if (TotalDim > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is: " + string.Format("{0:C2}", TotalPrice) + "\n\nThank You.");
            }
                Console.ReadLine();
            }

        }
    }



