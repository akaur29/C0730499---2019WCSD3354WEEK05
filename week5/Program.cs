
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new TestQuestion2();
            a.PlayingWithForLoops();
        }
        class TestQuestion2
        {
            public void PlayingWithForLoops()
            {
                for (; mymethod();)
                {
                    if (myfavouritevariables > 10)
                    {
                        Console.WriteLine("i am in for loops");
                        break;
                    }
                }
                Console.WriteLine("oh no i have to go through this stupoid loop again");
            }
        }
        public bool mymethod()
        {
            myfavouritevariables
                return true;
        }
    }
}
}
