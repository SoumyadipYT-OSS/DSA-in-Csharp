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


### 📝 Exercises
1.  Create a class Person with properties Name and Age. Implement methods to display these details.        
2.  Implement a class hierarchy for Employee and Manager with appropriate inheritance.

3.  Create an abstract class Appliance with a method TurnOn. Implement this method in derived classes WashingMachine and Refrigerator.



## 🚀 Some Extra Features of OOPs in C# 12 🌟

In this section, we'll explore some advanced and exciting features of Object-Oriented Programming (OOP) in C# 12. These features will help you write more efficient, maintainable, and scalable code. Let's dive in! 🏊‍♂️

### 🔗 Interfaces
Interfaces define a contract that implementing classes must follow. They can contain method signatures, properties, events, and indexers.
```csharp
public interface IDriveable {
    void Drive();
}

public class Car : IDriveable {
    public void Drive() {
        Console.WriteLine("The car is driving.");
    }
}
```

### 🏠 Properties
Properties provide a flexible mechanism to read, write, or compute the values of private fields.
```csharp
public class Person {
    private string name;

    public string Name {
        get { return name; }
        set { name = value; }
    }
}
```

### 📢 Events
Events provide a way for a class to notify other classes or objects when something of interest occurs.
```csharp
public class Alarm {
    public event Action OnAlarmRaised;

    public void RaiseAlarm() {
        OnAlarmRaised?.Invoke();
    }
}
```

### 🧬 Generics
Generics allow you to define classes, methods, and interfaces with a placeholder for the type of data they store or use.
```csharp
public class GenericList<T> {
    private List<T> items = new List<T>();

    public void Add(T item) {
        items.Add(item);
    }

    public T Get(int index) {
        return items[index];
    }
}
```

### 🌌 Abstract Classes
Abstract classes cannot be instantiated and are designed to be inherited by subclasses that implement or override its abstract methods.

### 🔌 Extension Methods
Extension methods allow you to add new methods to existing types without modifying their source code.

### 🧑‍🤝‍🧑 Delegates     ✔️
Delegates are type-safe function pointers that allow methods to be passed as parameters.

### 🧪 LINQ (Language Integrated Query)   ✔️
LINQ provides a consistent query experience for objects, databases, XML, and more.

Happy coding! 🎉




## 🤝 Contributing

We welcome contributions! Please read our Contributing Guidelines for more details.

## 📜 License

This project is licensed under the Siksha 'O' University, IIT Bombay License - see the LICENSE file for details.

---

![signature](https://github.com/user-attachments/assets/c0f3155e-d875-4627-87e9-89ecaab93eca)

---


## ╾━╤デ╦︻ (▀̿ĺ̯▀̿ ̿)   📖 Extra Resources please refer:
• Microsoft Learn: Object-Oriented Programming in C#

• W3Schools: C# OOP

• freeCodeCamp: Master OOP and Design Patterns in C#

!Happy Coding 🚀