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
            int hours = 1;
            int kph = 80;

            while (hours <= 5)
            {
                Console.WriteLine(hours * kph);
                hours++;
            }
        }
    }
}