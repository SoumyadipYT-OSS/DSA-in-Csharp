using System;

public abstract class Shape {
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public void Display() {
        Console.WriteLine($"Area: {GetArea()}");
        Console.WriteLine($"Perimeter: {GetPerimeter()}");
    }
}

public class Circle : Shape {
    public double Radius { get; set; }
    public Circle (double radius) {
        Radius = radius;
    }
    public override double GetArea() {
        return Math.PI * Radius * Radius;
    }
    public override double GetPerimeter() {
        return 2 * Math.PI * Radius;
    }
}

public class Rectangle : Shape {
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height) {
        Width = width;
        Height = height;
    }
    public override double GetArea() {
        return Width * Height;
    }

    public override double GetPerimeter() {
        return 2 * (Width + Height);
    }
}


class Concept_Abstraction {
    static void Main() {
        Shape circle = new Circle(5);
        circle.Display();

        Shape rectangle = new Rectangle(4, 6);
        rectangle.Display();
    }
}