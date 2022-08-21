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
            int number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Sum(number));
        }
        
        static int Sum(int num, int x = 0)
        {
            while (num > 0) 
            {
                x = x + num;
                num--;
            }
            
            return x;
        }
    }
}