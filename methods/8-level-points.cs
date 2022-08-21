using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
        }

        
        static int Points(int levels, int points = 0)
        {
            while (levels > 0)
            {
                points = points + levels;
                levels--;
            }

            return points;
        }

    }

}