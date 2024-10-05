using System;

namespace CuteAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cat cat = new Cat("Olá");
            Cat cat2 = new Cat() {name = "Oi", energy = 4, moodStatus = Mood.Grumpy | Mood.Happy, feedStatus = Feed.Hungry};
            //Console.WriteLine($"{cat.GetName()}: {cat.GetEnergy()}, {cat.GetMood()}, {cat.GetFeed()}");
            Console.WriteLine($"{cat2.GetName()}: {cat2.GetEnergy()}, {cat2.GetMood()}, {cat2.GetFeed()}");
        }
    }
}
