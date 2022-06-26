using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Assignment 4 and 5");
      
        
        List<string> myFriends = new List<string> { "Lukas", "Quincy", "Harvey", "Bunch", "Lourdes", "Bunch" };
       
            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();


     
        for (int i = 0; i < myFriends.Count; i++)
        {

            
                if (myFriends[i] == name)
                {
                    Console.WriteLine("Index is at " + i);

                }
            else
                {
                Console.WriteLine("Name not found in the given list.");

            }
        }


            Console.ReadLine();
        }
    }

