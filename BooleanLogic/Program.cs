using System;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("What is your age?");
        string EnterAge = Console.ReadLine();
        byte Age = Convert.ToByte(EnterAge);

        Console.WriteLine("Have you ever had a DUI? (true or false)");
        string TrueOrFalse = Console.ReadLine();
        bool DUI = Convert.ToBoolean(TrueOrFalse);
     
        Console.WriteLine("How many speeding tickets do you have?");
        string Ticket = Console.ReadLine();
        byte SpeedTicket = Convert.ToByte(Ticket);
        
        bool isQualified = (Age > 15 && DUI == false && SpeedTicket <= 3);
        Console.WriteLine("Qualified?\n" + isQualified);
        Console.ReadLine();
        }
    }

