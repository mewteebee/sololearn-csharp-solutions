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
            double salaryBudget = Convert.ToDouble(Console.ReadLine());
            double percent = Convert.ToDouble(Console.ReadLine());
            double afterIncrease;

            Console.WriteLine("Before the increase: " + salaryBudget);
            
            //complete the method call
            afterIncrease = Increase(salaryBudget, percent);

            Console.WriteLine("After the increase: " + afterIncrease);
        }
        //complete the method
        static double Increase(double x, double y)
        {
            x = x + (x * (y/100));
            return x;
        }
    }
}