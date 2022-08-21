using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            int x = 0;

            string letter = Console.ReadLine();

            int count = 0;
            
            for (; count < 10; count++)
            {
                if (words[count].Contains(letter) == true)
                {
                    Console.WriteLine(words[count]);
                    x = 2;
                }

            
            }

            if ( x < 2)
            {
                Console.WriteLine("No match");
            }

            
            
        }
    }
}