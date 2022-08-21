using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };
            
              int i = Convert.ToInt32(Console.ReadLine());

            if (i >=5 || i < 0)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                Console.WriteLine(games[i]);
            }
          
        }
    }
}