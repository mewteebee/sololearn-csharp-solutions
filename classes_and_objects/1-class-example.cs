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
            Welcome welcome = new Welcome();
            welcome.WelcomeMessage();
        }
    }
    
    class Welcome
    {
        public void WelcomeMessage()  
        {
            Console.Write("Welcome to OOP");
        }
    }
}