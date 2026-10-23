using ConsoleZoo.Entities;

namespace ConsoleZoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Djur som skapas med defaultvärden
            Dog dog = new Dog();
            Elephant elephant = new Elephant();
            Skunk skunk = new Skunk();
            Bulldog bulldog = new Bulldog();
            Chihuahua chihuahua = new Chihuahua();

            // Djur som skapas med egna värden
            Dog rex = new Dog("Rex", 4, "Farm", "Meat", "German Shepherd");
            Elephant ella = new Elephant("Ella", 25, "Jungle", "Fruit", "2 meters");
            Skunk pepe = new Skunk("Pepe", 3, "City", "Trash", "Black");
            Bulldog tank = new Bulldog("Tank", 6, "Garden", "Chicken", 35);
            Chihuahua bella = new Chihuahua("Bella", 1, "Handbag", "Treats", true);

            // Alla djur kan ligga i samma lista eftersom de ärver från Animal
            List<Animal> animals = new List<Animal>
            {
                dog, elephant, skunk, bulldog, chihuahua,
                rex, ella, pepe, tank, bella
            };

            Console.WriteLine("=== Alla djur låter ===");
            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }

            Console.WriteLine();
            Console.WriteLine("=== Djurens egna metoder ===");
            rex.Lick();
            ella.Trumpet();
            pepe.Spray();
            tank.Snore();
            tank.Lick(); // Bulldog har ärvt Lick() från Dog
            bella.Shiver();

            Console.WriteLine();
            Console.WriteLine("=== Info om ett djur ===");
            tank.DisplayInfo();
            Console.WriteLine($"Breed: {tank.Breed}");
            Console.WriteLine($"Wrinkles: {tank.WrinkleCount}");
            tank.GiveFood();

            Console.ReadKey();
        }
    }
}
