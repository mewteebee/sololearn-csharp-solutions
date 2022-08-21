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
            //taking the age as input
            int age = Convert.ToInt32(Console.ReadLine());

            //your code goes here

            if (age <= 19)
            {
                Console.WriteLine("Take your kindle");
            }
            else
            {
                Console.WriteLine();
            }

        }
    }
}