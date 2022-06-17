using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Anonymous Income Comparison Program \n\nPerson 1\nHourly Rate?");
        string HourRate = Console.ReadLine();
        decimal Rate = Convert.ToDecimal(HourRate);
        Console.WriteLine("Hours worked per week?");
        string Hours = Console.ReadLine();
        decimal HoursWeek = Convert.ToDecimal(Hours);


        Console.WriteLine("\n\nPerson 2\nHourly Rate?");
        string HourRate2 = Console.ReadLine();
        decimal Rate2 = Convert.ToDecimal(HourRate2);
        Console.WriteLine("Hours worked per week?");
        string Hours2 = Console.ReadLine();
        decimal HoursWeek2 = Convert.ToDecimal(Hours2);
        

        decimal AnnualSal = (Rate * HoursWeek) * 52;
        Console.WriteLine("\n\nAnnual salary of Person 1: " + AnnualSal);

        decimal AnnualSal2 = (Rate2 * HoursWeek2) * 52;
        Console.WriteLine("\n\nAnnual salary of Person 2: " + AnnualSal2);
        

        bool TrueorFalse = AnnualSal > AnnualSal2;
        Console.WriteLine("\n\nPerson 1 makes more money than Person 2?\n" + TrueorFalse.ToString());
        Console.ReadLine();

    }
    }

