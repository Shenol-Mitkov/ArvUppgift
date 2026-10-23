using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleZoo.Entities
{
    internal class Elephant : Animal
    {
        public string TuskLength { get; set; }

        // Constructor med defaultvärden för både Elephant och Animal
        public Elephant() : base("Dumbo", 10, "Elephant", "Savanna", "Grass")
        {
            TuskLength = "1 meter";
        }

        public Elephant(string name, int age, string habitat, string diet, string tuskLength) : base(name, age, "Elephant", habitat, diet)
        {
            TuskLength = tuskLength;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Pawoooo!");
        }

        public void Trumpet()
        {
            Console.WriteLine($"{Name} is trumpeting!");
        }
    }
}
