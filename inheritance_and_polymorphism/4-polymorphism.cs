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
            Unit unit1 = new Unit();
            Unit musketeer = new Musketeer();
            Unit magician = new Magician();

            unit1.Attack();
            musketeer.Attack();
            magician.Attack();
        }
    }

    class Unit
    {
        public virtual void Attack()
        {
            Console.WriteLine("Using sword!");
        }
    }


    class Musketeer : Unit 
    {
        public override void Attack()
        {
            Console.WriteLine("Using musket!");
        }
    }

    class Magician : Unit
    {
        public override void Attack()
        {
            Console.WriteLine("Using magic!");
        }
    }
}