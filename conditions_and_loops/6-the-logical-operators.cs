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
            int attendance = Convert.ToInt32(Console.ReadLine());
            int avgScore = Convert.ToInt32(Console.ReadLine());

            //your code goes here
            if (attendance >= 95 && avgScore >= 80)
            {
                Console.WriteLine("Accepted");
            }
            else
            {
                Console.WriteLine("Denied");
            }
            
        }
    }
}