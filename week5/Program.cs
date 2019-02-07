
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        private readonly object myfavouritevariables;

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




    class dog
    {
        public dog(string name,string breed)
        {
            dog_name = name;
            dog_breed = breed;
        }
        public string dog_name;
        public string dog_breed;
        public dog next_dog;
        public dog previous_dog;

    }
    class birthday_party
        {
        public dog fifi;
        public dog peanut;
        public dog clarence;
        public dog roy;
        public dog head;

        public dog temporary { get; private set; }

        public void setupPartyList()
        {
            peanut = new dog("peanut", "bichon");
            fifi = new dog("fifi", "poodle");
            clarence = new dog("clarance", "german sheppard");
            roy = new dog("roy", "beagle");

            peanut.previous_dog = null;
            peanut.next_dog = null;
            fifi.previous_dog = peanut;
            fifi.next_dog = clarence;
            clarence.previous_dog = fifi;
            clarence.next_dog = roy;
            head.previous_dog = roy;
            head.next_dog = null;

        }
        public string printPartyList()

        {
            string inviteList = "*---";
            temporary = head;
            while(temporary.next_dog!=null)
            {
                inviteList += temporary.dog_name + "*----*";
            }
        }
        return inviteList;
private class inviteList
        {
        }
    }
    
    
}
}
