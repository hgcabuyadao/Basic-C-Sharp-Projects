using System;
using System.Collections.Generic;



    class Program
    {
        static void Main(string[] args)
        {
        //string array
       
        string[] stringArray = { "Harvey", "Sage", "Lukas", "QUincy" };
        Console.WriteLine("Select index from 0 to 3.");
        int Num = Convert.ToByte(Console.ReadLine());
        if (Num <= 3)
        {
            Console.WriteLine("You picked " + stringArray[Num] + "!");
        }
        else
        {
          Console.WriteLine("Index that doesn’t exist");
            
        }
        

        //integer array
        int[] stringArray2 = { 100,200,300,400};
        Console.WriteLine("\n\nSelect index from 0 to 3.");
        int Num2 = Convert.ToByte(Console.ReadLine());

        if (Num2 <= 3)
        {
           Console.WriteLine("You picked " + stringArray2[Num2] + "!");
        }
        else
        {
            Console.WriteLine("Index that doesn’t exist");
        }

        //string list
        List<string> StringList = new List<string>();
        StringList.Add("Hi");
        StringList.Add("Hello");
        StringList.Add("Ola");
        StringList.Add("Aloha");


        Console.WriteLine("\n\nSelect index from 0 to 3.");
        int Num3 = Convert.ToByte(Console.ReadLine());

        if (Num3 <= 3)
        {
            Console.WriteLine(StringList[Num3] + "!");
        }
        else
        {
            Console.WriteLine("Index that doesn’t exist");
        }



        Console.ReadLine();

        }
    }

