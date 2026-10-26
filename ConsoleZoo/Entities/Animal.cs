using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleZoo.Entities
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }

        // Constructor med defaultvärden
        

        public Animal(string name, int age, string species, string habitat, string diet)
        {
            Name = name;
            Age = age;
            Species = species;
            Habitat = habitat;
            Diet = diet;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Habitat: {Habitat}");
            Console.WriteLine($"Diet: {Diet}");
        }

        // virtual gör att subklasserna kan skriva över metoden med override
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }

        public void GiveFood()
        {
            Console.WriteLine($"{Name} is eating {Diet}.");
        }
    }
}
