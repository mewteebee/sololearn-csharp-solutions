using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] numbers = new int[5];
            int count = 0;
            while (count <5)
            {
                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0) 
                {
                    sum = sum + numbers[i];
                }

            }
            
            Console.WriteLine(sum);

            
        }
    }
}