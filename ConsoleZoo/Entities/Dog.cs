using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleZoo.Entities
{
    internal class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, string species, string habitat, string diet, string breed) : base(name, age, species, habitat, diet)
        {
            Breed = breed;
        }
        
        public void Lick()
        {
            Console.WriteLine($"{Name} is licking something!");
        }


    }
}
