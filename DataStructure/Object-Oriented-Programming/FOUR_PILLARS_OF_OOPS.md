<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>The Four Pillars of OOP in C# 12</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            line-height: 1.6;
            background: #f4f4f4;
            color: #333;
            padding: 20px;
            position: relative;
        }
        h1, h2, h3 {
            color: #0056b3;
        }
        code {
            background: #e8e8e8;
            padding: 2px 4px;
            border-radius: 4px;
        }
        .watermark {
            position: fixed;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%) rotate(-45deg);
            font-size: 100px;
            color: rgba(0, 0, 0, 0.1);
            pointer-events: none;
            user-select: none;
        }
    </style>
</head>
<body>
    <h1>🌟 The Four Pillars of OOP in C# 12 🌟</h1>
    <p>Welcome to the world of Object-Oriented Programming (OOP) in C# 12! 🚀 This guide will introduce you to the four fundamental principles of OOP, which are essential for writing robust and maintainable code. Let's dive in! 🏊‍♂️</p>

    <h2>📚 Table of Contents</h2>
    <ol>
        <li><a href="#encapsulation">Encapsulation</a></li>
        <li><a href="#inheritance">Inheritance</a></li>
        <li><a href="#polymorphism">Polymorphism</a></li>
        <li><a href="#abstraction">Abstraction</a></li>
    </ol>

    <h2 id="encapsulation">🔒 Encapsulation</h2>
    <p>Encapsulation is the practice of keeping fields within a class private, then providing access to them via public methods. This helps to protect the internal state of the object and only expose what is necessary.</p>
    <pre><code>
public class BankAccount
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
    </code></pre>
    <p><strong>Benefits:</strong></p>
    <ul>
        <li>Protects the internal state of the object.</li>
        <li>Promotes modularity and maintainability.</li>
    </ul>

    <h2 id="inheritance">🧬 Inheritance</h2>
    <p>Inheritance allows a class to inherit properties and methods from another class. This promotes code reusability and establishes a natural hierarchy between classes.</p>
    <pre><code>
public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }

    public void Start()
    {
        Console.WriteLine("Vehicle started.");
    }
}

public class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public void Honk()
    {
        Console.WriteLine("Car honking.");
    }
}
    </code></pre>
    <p><strong>Benefits:</strong></p>
    <ul>
        <li>Promotes code reuse.</li>
        <li>Establishes a natural hierarchy.</li>
    </ul>

    <h2 id="polymorphism">🌀 Polymorphism</h2>
    <p>Polymorphism allows methods to do different things based on the object it is acting upon. It can be achieved through method overriding and method overloading.</p>
    <pre><code>
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound.");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark!");
    }
}
    </code></pre>
    <p><strong>Benefits:</strong></p>
    <ul>
        <li>Enhances flexibility and maintainability.</li>
        <li>Allows for dynamic method binding.</li>
    </ul>

    <h2 id="abstraction">🧩 Abstraction</h2>
    <p>Abstraction is the concept of hiding the complex implementation details and showing only the necessary features of an object. It can be achieved using abstract classes and interfaces.</p>
    <pre><code>
public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}
    </code></pre>
    <p><strong>Benefits:</strong></p>
    <ul>
        <li>Reduces complexity.</li>
        <li>Increases code readability and maintainability.</li>
    </ul>

    <h2>🎉 Conclusion</h2>
    <p>Understanding and applying these four pillars of OOP will help you write better, more maintainable code in C# 12. Happy coding! 🎉</p>

    <div class="watermark">C# © 2024</div>
</body>
</html>