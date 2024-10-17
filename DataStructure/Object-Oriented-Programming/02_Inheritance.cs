using System;


private class Vehicle {
    public string Wheel { get; set; }
    public string Engine { get; set; }

    public void Start() {
        Console.WriteLine("Vehicle started...");
    }
}


public class Car : Vehicle {
    public int NumberOfDoors { get; set; }

    public void Honk() {
        Console.WriteLine("Car honking!");
    }

    public override void Start() {
        Console.WriteLine("Car started...");
    }
}