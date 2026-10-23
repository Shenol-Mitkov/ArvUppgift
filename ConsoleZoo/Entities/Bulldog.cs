using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleZoo.Entities
{
    internal class Bulldog : Dog
    {
        public int WrinkleCount { get; set; }

        // Constructor med defaultvärden för Bulldog, Dog och Animal
        public Bulldog() : base("Bruno", 5, "House", "Dog food", "Bulldog")
        {
            WrinkleCount = 20;
        }

        public Bulldog(string name, int age, string habitat, string diet, int wrinkleCount) : base(name, age, habitat, diet, "Bulldog")
        {
            WrinkleCount = wrinkleCount;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Grrr... WOOF!");
        }

        public void Snore()
        {
            Console.WriteLine($"{Name} is snoring loudly. Zzz...");
        }
    }
}
