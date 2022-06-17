using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Input a number.");
        string EnterNumber1 = Console.ReadLine();
        int InputNumber1 = Convert.ToInt32(EnterNumber1);
        int Product = InputNumber1 * 50;
        Console.WriteLine("Product of " + 50 + " and " + InputNumber1 + " is: " + Product);
     

        Console.WriteLine("\nInput a number.");
        string EnterNumber2 = Console.ReadLine();
        int InputNumber2 = Convert.ToInt32(EnterNumber2);
        int Sum = InputNumber2 + 25;
        Console.WriteLine("Sum of " + 25 + " and " + InputNumber2 + " is: " + Sum);
     

        Console.WriteLine("\nInput a number.");
        string EnterNumber3 = Console.ReadLine();
        decimal InputNumber3 = Convert.ToDecimal(EnterNumber3);
        decimal Quotient = InputNumber3 / 12.5m;
        Console.WriteLine(InputNumber3 + " divide by " + 12.5 + " is: " + Quotient);
        

        Console.WriteLine("\nInput a number.");
        string EnterNumber4 = Console.ReadLine();
        int InputNumber4 = Convert.ToInt32(EnterNumber4);
        bool TrueorFalse = InputNumber4 > 50;
        Console.WriteLine("Is " + InputNumber4 + " greater than 50? \n" + TrueorFalse.ToString());
       

        Console.WriteLine("\nInput a number.");
        string EnterNumber5 = Console.ReadLine();
        int InputNumber5 = Convert.ToInt32(EnterNumber5);
        int Remainder = InputNumber5 % 7;
        Console.WriteLine("When you divide " + InputNumber5 + " to 7, remainder is: " + Remainder);
        Console.ReadLine();
    }
    }

