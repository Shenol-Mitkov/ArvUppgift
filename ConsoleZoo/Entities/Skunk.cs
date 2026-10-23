using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleZoo.Entities
{
    internal class Skunk : Animal
    {
        public string Color { get; set; }

        // Constructor med defaultvärden för både Skunk och Animal
        public Skunk() : base("Stinky", 2, "Skunk", "Forest", "Insects")
        {
            Color = "Black and white";
        }

        public Skunk(string name, int age, string habitat, string diet, string color) : base(name, age, "Skunk", habitat, diet)
        {
            Color = color;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Hiss hiss!");
        }

        public void Spray()
        {
            Console.WriteLine($"{Name} is spraying foul odor!");
        }
    }
}
