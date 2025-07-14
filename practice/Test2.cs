using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    // Create a base class Animal
    // Properties: name, age
    // Method: Speak()

    // Create class Dog : Animal
    // Override Speak() to print "The dog barks."

    // Create class Cat : Animal
    // Override Speak() to print "The cat meows."

    // In Main(), create one Dog and one Cat object
    // Set name and age and call Speak() for both.

    public class Animal
    {
        public int age;
        public string name="";
                        
        public virtual void Speak()
        {
            Console.WriteLine("Animal can make sound");
        }
        public int Animalsliving(int animalcount)
        {
            Console.WriteLine($"There are {animalcount} animals used in the project");
            return animalcount;
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("the Dog is barking");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("the cat is meow");
        }
    }

    class Hen : Animal
    {
        public void Fly()
        {
            Console.WriteLine("The Hen can fly");
        }

        public override void Speak()
        {
            base.Speak();
        }
    }

    class Peackok : Animal
    {
        public void parts(int legs,string gender)
        {
            Console.WriteLine($"A peackok has {legs} legs and it has {gender} gender");
        }
    }

    class Anotherpeackok : Animal
    {
        public void parts(string gender,int legs,int age)
        {
            Console.WriteLine($"A peackok has {legs} legs and it has {gender} gender and age is{age}");
        }

        public void showliving()
        {
            Animalsliving(6);
        }
       
    }
}
