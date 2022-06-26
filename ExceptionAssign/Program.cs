using System;
using System.Collections.Generic;

class Program
{
   
    static void Main(string[] args)
    {
        try
        {
            List<int> Numbers = new List<int>() { 2, 4, 6, 8, 10, 12, 14 };
        Console.WriteLine("Enter a number.");
        int Enter = Convert.ToInt32(Console.ReadLine());

        foreach (int Answer in Numbers)
        {
            int Divide = Answer / Enter;

            Console.WriteLine("\n" + Divide);
           
        }
    }  
    catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by Zero");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number");
        }
        Console.ReadLine();

    }
    }

