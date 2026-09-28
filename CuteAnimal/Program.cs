using System;

namespace CuteAnimal
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP!");
            Cat cat = new Cat("Goku");
            Cat cat2 = new Cat("Gohan",16, (Mood)2,(Feed)1);
            Console.WriteLine(cat.GetEnergy());
            Console.WriteLine(cat2.GetEnergy());
        }
    }
}
