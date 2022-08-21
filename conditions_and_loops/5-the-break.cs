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
           
            int maxBid = Convert.ToInt32(Console.ReadLine());

            int bid = Convert.ToInt32(Console.ReadLine());

            while (bid < maxBid)
            {
                bid = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sold: " + bid);
            
        }
    }
}