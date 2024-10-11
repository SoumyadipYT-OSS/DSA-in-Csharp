# Explicit Interface Implementation: Array.ICollection.Count Property

## 📖 Definition
The `Array.ICollection.Count` property is an explicit interface member implementation of the `ICollection` interface. It gets the number of elements contained in the array. This property can only be accessed when the array instance is cast to an `ICollection` interface.

## 🔄 Overloads
The `Array.ICollection.Count` property does not have overloads. It is a read-only property that returns the number of elements in the array.

## 💡 Example
Here is an example demonstrating how to use the `Array.ICollection.Count` property in C# 12:

```csharp
using System;
using System.Collections;

class Program {
    static void Main(string[] args) {
        // Create and initialize an array
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Cast the array to ICollection to access the Count property
        ICollection collection = (ICollection)numbers;

        // Display the count of elements in the array
        Console.WriteLine("Number of elements in the array: " + collection.Count);
    }
}
```