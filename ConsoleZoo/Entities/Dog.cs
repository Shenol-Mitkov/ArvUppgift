using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleZoo.Entities
{
    internal class Dog : Animal
    {
        public string Breed { get; set; }

        // Constructor med defaultvärden för både Dog och Animal
        public Dog() : base("Doggo", 3, "Dog", "House", "Dog food")
        {
            Breed = "Mixed";
        }

        public Dog(string name, int age, string habitat, string diet, string breed) : base(name, age, "Dog", habitat, diet)
        {
            Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Woof woof!");
        }

        public void Lick()
        {
            Console.WriteLine($"{Name} is licking something!");
        }
    }
}
