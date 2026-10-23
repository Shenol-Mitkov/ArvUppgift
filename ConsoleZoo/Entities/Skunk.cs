using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleZoo.Entities
{
    internal class Skunk : Animal
    {
        public string Color { get; set; }

        public Skunk(string name, int age, string species, string habitat, string diet, string color) : base(name, age, species, habitat, diet)
        {
            Color = color;
        }

        public void Spray()
        {
            Console.WriteLine($"{Name} is spraying foul odor!");
        }

    }
}
