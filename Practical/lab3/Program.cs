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

// Derived class (child class)
class Car : Vehicle
{
    public void Accelerate()
    {
        Console.WriteLine("Car is accelerating.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of the Car class
        Car myCar = new Car();

        // Accessing methods from both base and derived classes
        myCar.Start();       // Inherited from Vehicle class
        myCar.Accelerate();  // Specific to Car class
        myCar.Stop();        // Inherited from Vehicle class
        Console.WriteLine("Name:Robin Devkota \nRoll:23498 6th-sem-prime");
    }
}
