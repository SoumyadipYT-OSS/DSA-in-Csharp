# Array.IList.Add(Object) Method

## 📖 Definition
The `Array.IList.Add(Object)` method is an explicit interface member implementation of the `IList` interface for arrays in C#. This method is designed to add an object to an `IList`. However, because arrays have a fixed size, calling this method will always throw a `NotSupportedException`.

## 🔄 Overloads
The `Array.IList.Add(Object)` method does not have overloads. It is a single method that attempts to add an object to the array.

## 💡 Example
Here is an example demonstrating the behavior of the `Array.IList.Add(Object)` method in C# 12:

```csharp
using System;
using System.Collections;

class Program {
    static void Main(string[] args) {
        // Create and initialize an array
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Cast the array to IList to access the Add method
        IList list = (IList)numbers;

        try {
            // Attempt to add an element to the array
            list.Add(6);
        } catch (NotSupportedException e) {
            Console.WriteLine("Exception: " + e.Message);
        }
    }
}
```

🎉 Happy Coding! 😊