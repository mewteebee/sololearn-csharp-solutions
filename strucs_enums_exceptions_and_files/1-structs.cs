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
            int x;
            int y;

            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());

            Cuboid cuboid = new Cuboid();

            x = cuboid.Volume(length, width, height);
            y = cuboid.Perimeter(length, width, height);

            Console.WriteLine("Volume: " + x);
            Console.WriteLine("Perimeter: " + y);
        }
    }
    struct Cuboid
    {
        public int length;
        public int width;
        public int height;

        //create a constructor
        public Cuboid (int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        //complete this method
        public int Volume(int length, int width, int height)
        {
            return length * width * height;
        }
        //complete this method
        public int Perimeter(int length, int width, int height)
        {
            return 4 * (length + width + height);
        }
    }
}