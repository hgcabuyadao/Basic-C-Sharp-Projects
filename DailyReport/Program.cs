using System;


    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Academy of Learning Career College \nStudent Daily Report");
       

        Console.WriteLine("\n\nWhat course are you in?");
        string course = Console.ReadLine();

        Console.WriteLine("\n\nWhat page number?");
        string PageNumber = Console.ReadLine();
        uint PageNum = Convert.ToUInt16(PageNumber);

        Console.WriteLine("\n\nDo you need help with anything? Please answer “true” or “false”.");
        string NeedHelp = Console.ReadLine();
         

        Console.WriteLine("\n\nWere there any positive experiences you’d like to share? Please give specifics.");
        string ShareExperience = Console.ReadLine();

        Console.WriteLine("\n\nIs there any other feedback you’d like to provide? Please be specific.");
        string Feedback = Console.ReadLine();


        Console.WriteLine("\n\nHow many hours did you study today?");
        string hours = Console.ReadLine();
        uint NumHours = Convert.ToUInt16(hours);

        Console.WriteLine("\n\nThank you for your answers. An Instructor will respond shortly. Have a great day!");
        Console.ReadLine();

    }
}

