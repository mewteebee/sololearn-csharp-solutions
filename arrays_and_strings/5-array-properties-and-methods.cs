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
        int[] nums = new int[5];
        int count = 0;

        while (count < 5)
        {
            nums[count] = Convert.ToInt32(Console.ReadLine());
            count++;
        }
            Console.WriteLine(nums.Max() + nums.Min());
        }
    }
}