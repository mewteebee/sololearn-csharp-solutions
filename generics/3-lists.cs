using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPlayers = Convert.ToInt32(Console.ReadLine());

            List<int> scores = new List<int>();
            int count = 0;
            while (count < numOfPlayers)
            {
                int score = Convert.ToInt32(Console.ReadLine());
                scores.Add(score);
                count++;

            }
            List<int> scores1 = new List<int>();
            scores.Sort();
            count = 0;
            while (count < numOfPlayers)
            {
                Console.WriteLine(scores[count++] + " ");
            }

        }
    }
}
