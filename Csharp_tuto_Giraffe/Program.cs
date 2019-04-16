using System;

namespace Csharp_tuto_Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Bernardo";
            int characterAge;
            characterAge = 92;


            Console.WriteLine("there once was a man named " + characterName);
            Console.WriteLine("he was " + characterAge + " yrs old");

            characterName = "Bobby Brian";
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("but didn't like being "  + characterAge);

            Console.ReadLine();
        }  
    }
} 
