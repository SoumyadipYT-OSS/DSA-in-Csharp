using System;


public interface IShape {
    double GetArea();
}

public class Circle : IShape {
    public double Radius { get; set; }

    public double GetArea() {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : IShape {
    public double Width { get; set; }
    public double Height { get; set; }

    public double GetArea() {
        return Width * Height;
    }
}



class ConceptPolymorphism {
    // Main method
    static void Main() {
        IShape circle = new Circle { Radius = 5 };
        IShape rectangle = new Rectangle { Width = 4, Height = 6 };

        Console.WriteLine($"Circle Area: {circle.GetArea()}"); // Output: Circle Area: 78.53981633974483
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}"); // Output: Rectangle Area: 24
    }
}