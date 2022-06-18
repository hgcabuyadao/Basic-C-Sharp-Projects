using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Welcome to Package Express \n\nPlease follow the instructions below.");
        Console.WriteLine("\n\nPlease enter the package weight:");
        decimal Weight = Convert.ToDecimal(Console.ReadLine());
        string result1 = Weight > 50 ? "Package too heavy to be shipped via Package Express. Have a good day." : "Please enter the package width:";
        Console.WriteLine(result1);

        decimal Width = Convert.ToDecimal(Console.ReadLine());
     

        Console.WriteLine("Please enter the package height:");
        decimal Height = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Please enter the package lenght:");
        decimal Lenght = Convert.ToDecimal(Console.ReadLine());

        decimal TotalDim = Width + Height + Lenght;

        decimal Area = (Width * Height * Lenght) * Weight;
        decimal TotalPrice = Area / 100;


        string result2 = TotalDim > 50 ? "\n\nPackage too big to be shipped via Package Express." : "\n\nYour estimated total for shipping this package is: " + string.Format("{0:C2}", TotalPrice) + "\n\nThank You.";
        Console.WriteLine(result2);

        Console.ReadLine();
    }
    }

