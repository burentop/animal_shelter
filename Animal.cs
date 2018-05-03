using System;
using System.Collections.Generic;

public class Animal
{
  public int Age;
  public string Species;
}

public class Program
{
  public static void Main()
  {
    Animal vader = new Animal();
    vader.Age = 15;
    vader.Species = "Black Lab";

    Animal frank = new Animal();
    frank.Age = 5;
    frank.Species = "Tabby Cat";

    Animal pal = new Animal();
    pal.Age = 7;
    pal.Species = "Mutt";

    List<Animal> Animals = new List<Animal>() { vader, frank, pal };

    Console.WriteLine("Enter maximum age: ");
    string stringMaxAge = Console.ReadLine();
    int maxAge = int.Parse(stringMaxAge);

    Console.WriteLine("Here are the animals that meet your criteria: ");
    foreach (Animal pet in Animals)
    {
      if (pet.Age <= maxAge)
      {
        Console.WriteLine(pet.Species);
      }
    }

    vader.Age = 9;

    Console.WriteLine("We have a new pet; please enter your max age again: ");
    string newStringMaxAge = Console.ReadLine();
    int newMaxAge = int.Parse(newStringMaxAge);

    foreach (Animal pet in Animals)
    {
      if (pet.Age <= newMaxAge)
      {
        Console.WriteLine(pet.Species);
      }
    }
  }
}