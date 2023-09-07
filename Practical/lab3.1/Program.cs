using System;

// Base class (parent class)
class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle started.");
    }

    public void Stop()
    {
        Console.WriteLine("Vehicle stopped.");
    }
}

// Derived class (child class) inheriting from Vehicle
class Car : Vehicle
{
    public void Accelerate()
    {
        Console.WriteLine("Car is accelerating.");
    }
}

// Another derived class (grandchild class) inheriting from Car
class SportsCar : Car
{
    public void TurboBoost()
    {
        Console.WriteLine("Sports car is turbo boosting!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the SportsCar class
        SportsCar mySportsCar = new SportsCar();

        // Accessing methods from all three levels of inheritance
        mySportsCar.Start();       // Inherited from Vehicle class
        mySportsCar.Accelerate();  // Inherited from Car class
        mySportsCar.TurboBoost();  // Specific to SportsCar class
        mySportsCar.Stop();        // Inherited from Vehicle class
        Console.WriteLine("Name:Robin Devkota \nRoll:23498 6th-sem-prime");
    }
}
