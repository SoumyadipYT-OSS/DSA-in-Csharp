using System;

public class Vehicle {
    public string Wheel { get; set; }
    public string Engine { get; set; }

    public virtual void Start() {
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

public class Bike : Vehicle {
    public int NumberOfDoors { get; set; }

    public void Honk() {
        Console.WriteLine("Bike honk!");
    }

    public override void Start() {
        Console.WriteLine("Bike started...");
    }
}



public class Concept_Inheritance {
    static void Main() {
        Car c = new Car();
        c.Honk();
        c.Start();

        Bike b = new Bike();
        b.Honk();
        b.Start();
    }
}