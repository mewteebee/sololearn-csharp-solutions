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
            Queue<int> q = new Queue<int>();

            while (q.Count < 3)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                q.Enqueue(num);
            }

            Console.Write("Queue: ");
            foreach (int i in q)
                Console.Write(i + " ");

            Console.WriteLine();
            int[] arr = q.ToArray();
            Array.Sort(arr);
            Console.Write("Sorted: ");
            foreach (int j in arr)
                Console.Write(j + " ");

        }
    }
}