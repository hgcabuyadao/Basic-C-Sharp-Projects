using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Assigment 6 \n");
        List<string> Words = new List<string>() { "Love", "Hate", "Miss", "Forget","Hate" };
        List<string> passing = new List<string>();  
     

        foreach (string Feeling in Words)
        {
             
       
          Console.WriteLine (Feeling + "\t" + Feeling.Contains("Hate")); 

            }
            
           Console.ReadLine();
        }
        }
    

