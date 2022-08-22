using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            WayStatus status = new WayStatus();
        }
    }
    class Flight
    {
        public Flight()
        {
            Console.WriteLine("Registration");
        }
        ~Flight()
        {
            Console.WriteLine("Closed");
        }
    }
    class WayStatus : Flight
    {
        public WayStatus()
        {
            Console.WriteLine("On the way");
        }
        ~WayStatus()
        {
            Console.WriteLine("Landed");
        }



    }
}