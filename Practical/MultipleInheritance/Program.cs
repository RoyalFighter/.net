// See https://aka.ms/new-console-template for more information
//In C#, a class cannot directly inherit from multiple classes.
//However, you can achieve a form of multiple inheritance using interfaces.
//Here's a simple example to demonstrate multiple inheritance using interfaces:
using System;

interface IAnimal
{
    void Eat();
}

interface IFlyable
{
    void Fly();
}

class Bird : IAnimal, IFlyable
{
    public void Eat()
    {
        Console.WriteLine("Bird is eating.");
    }

    public void Fly()
    {
        Console.WriteLine("Bird is flying.");
    }
}

class Program
{
    static void Main()
    {
        Bird bird = new Bird();
        bird.Eat();
        bird.Fly();

     
    }
}

