// You are writing a program to calculate the area of a rectangle. Currently it takes the the length and the height as inputs.
// Complete the given method to take them as arguments, then calculate and return the area. 

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
            int length = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Area(length,height));
        }
        static int Area(int x, int y)
        {          
            int z;  
            z = x * y;

            return z;

        }
    }
}