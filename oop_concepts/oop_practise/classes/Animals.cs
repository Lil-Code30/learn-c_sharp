namespace oop_practise.classes;
using oop_practise.interfaces;

public class Animals : IAnimal
{
    public void animalSound()
    {
        Console.WriteLine("I am animal");
    }
}

public class Pig : Animals
{
    public void animalSound()
    {
        Console.WriteLine("The pig says : wee wee");
    }
}