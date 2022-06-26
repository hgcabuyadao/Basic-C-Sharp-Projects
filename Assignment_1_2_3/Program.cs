using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Assignment 1,2 and 3.");
        int n = 0;
        do
        {
            string[] Words = { "Love", "Hate", "Miss", "Forget" };
            Console.WriteLine("\n");
            Console.WriteLine("Type something.");
            String TypeWord = Console.ReadLine();

            Console.WriteLine("\n\n");

            for (int i = 0; i < Words.Length; i++)
            {

                Console.WriteLine(Words[i] + TypeWord);
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i < Words.Length; i++)
            {

                Console.WriteLine(Words[i]);
            }
            
            n++;
        }
        while (n < 3);
    } 
}
    

