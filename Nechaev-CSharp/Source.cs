using System;
using System.Diagnostics;
 
class Animal
{
    public string Name { get; set; }
    public string Color { get; set; }
    public uint Legs { get; set; }
    public Animal(string name, string color, uint legs)
    {
        Name = name;
        Color = color;
        Legs = legs;
    }
}
class AnimalPerformance
{
    public string Name { get; set; }
    public uint Legs { get; set; }
    public AnimalPerformance(string name, uint legs)
    {
        Name = name;
        Legs = legs;
    }
}
class Source
{
    string whoIsMe = "я редиска";
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>(new[] { new Animal("cat", "brown", 4), new Animal("dog", "white", 4), new Animal("racoon", "gray", 4), new Animal("kangoroo", "orange", 2), new Animal("human", "normal", 2), });
        var animalPerformance = from animal in animals select new AnimalPerformance(animal.Name, animal.Legs);

        Queue<AnimalPerformance> twoLegsAnimal = new Queue<AnimalPerformance>();
        Queue<AnimalPerformance> fourLegsAnimal = new Queue<AnimalPerformance>();
        foreach (var animal in animalPerformance)
        {
            if (animal.Legs == 2) twoLegsAnimal.Enqueue(animal);
            else if (animal.Legs == 4) fourLegsAnimal.Enqueue(animal);
        }
    }
}