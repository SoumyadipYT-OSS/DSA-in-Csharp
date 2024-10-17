# 🎓 Mastering Object-Oriented Programming in C# 12

Welcome to your journey of mastering Object-Oriented Programming (OOP) in C# 12! 🚀 This guide will help you understand and implement the fundamental principles of OOP with practical examples and exercises.

## 📚 Table of Contents
1. Introduction to OOP
2. Classes and Objects
3. Encapsulation
4. Inheritance
5. Polymorphism
6. Abstraction
7. Practical Examples
8. Exercises
9. Resources

## 🧑‍🏫 Introduction to OOP
Object-Oriented Programming (OOP) is a programming paradigm based on the concept of "objects", which can contain data and code to manipulate that data. The four main principles of OOP are:

- **Encapsulation**
- **Inheritance**
- **Polymorphism**
- **Abstraction**

## 🏗️ Classes and Objects
A **class** is a blueprint for creating objects. An **object** is an instance of a class.

```csharp
public class Car {
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public void Drive() {
        Console.WriteLine("The car is driving.");
    }
}
```


## 🔒 Encapsulation
**Encapsulation** is the concept of wrapping data and methods that operate on the data within a single unit, typically a class.

```csharp
public class BankAccount {
    private decimal balance;

    public void Deposit(decimal amount) {
        balance += amount;
    }

    public decimal GetBalance() {
        return balance;
    }
}
```


## 🧬 Inheritance
**Inheritance** allows a class to inherit properties and methods from another class.
```csharp
public class ElectricCar : Car {
    public int BatteryCapacity { get; set; }

    public void ChargeBattery() {
        Console.WriteLine("Charging the battery.");
    }
}
```


## 🌀 Polymorphism
**Polymorphism** allows methods to do different things based on the object it is acting upon.
```csharp
public class Animal {
    public virtual void MakeSound() {
        Console.WriteLine("Some generic animal sound.");
    }
}

public class Dog : Animal {
    public override void MakeSound() {
        Console.WriteLine("Bark!");
    }
}
```


## 🧩 Abstraction
**Abstraction** is the concept of hiding the complex implementation details and showing only the necessary features of an object.
```csharp
public abstract class Shape {
    public abstract double GetArea();
}

public class Circle : Shape {
    public double Radius { get; set; }

    public override double GetArea() {
        return Math.PI * Radius * Radius;
    }
}
```


## 💡 Practical Examples
**• Bank Account System:** Implement different types of bank accounts using inheritance.
**• Vehicle Management System:** Create a hierarchy of vehicles with common and specific properties.