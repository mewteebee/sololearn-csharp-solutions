using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalPrice = Convert.ToDouble(Console.ReadLine());


            if (totalPrice >= 10000)
            {
                Console.WriteLine(Discount(totalPrice));
            }
            else
            {
                Console.WriteLine(totalPrice);
            }
            
        }
        //complete the method declaration
        static double Discount(double x)
        {
            x = x - (x * 0.20);
            return x;            
        }
    }
}