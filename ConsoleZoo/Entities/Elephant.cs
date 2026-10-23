using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleZoo.Entities
{
    internal class Elephant : Animal
    {
        public string TuskLength { get; set; }

        public Elephant(string name, int age, string species, string habitat, string diet, string tuskLength) : base(name, age, species, habitat, diet)
        {
            TuskLength = tuskLength;
        }

        public void Trumpet()
        {
            Console.WriteLine($"{Name} is trumpeting!");
        }
    }
}
