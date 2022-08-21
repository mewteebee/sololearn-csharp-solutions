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
            int numOfDeps = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (count < numOfDeps)
            {
                string depName = Console.ReadLine();
                Department dep = new Department(depName);
                count++;
            }

            Console.WriteLine("Number of departments: " + (Convert.ToInt32(Department.depCount) + Convert.ToInt32(numOfDeps)));
        }
    }
    class Department
    {
        
        public string depName;
        public static int depCount = 2;
        public Department(string name)
        {
            Console.WriteLine("Department opened: " + name);
            this.depName = name;
        }
    }
}