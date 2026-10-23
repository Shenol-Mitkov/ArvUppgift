using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleZoo.Entities
{
    internal class Chihuahua : Dog
    {
        public bool FitsInBag { get; set; }

        // Constructor med defaultvärden för Chihuahua, Dog och Animal
        public Chihuahua() : base("Tiny", 2, "Apartment", "Dog food", "Chihuahua")
        {
            FitsInBag = true;
        }

        public Chihuahua(string name, int age, string habitat, string diet, bool fitsInBag) : base(name, age, habitat, diet, "Chihuahua")
        {
            FitsInBag = fitsInBag;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Yip yip yip!");
        }

        public void Shiver()
        {
            Console.WriteLine($"{Name} is shivering...");
        }
    }
}
