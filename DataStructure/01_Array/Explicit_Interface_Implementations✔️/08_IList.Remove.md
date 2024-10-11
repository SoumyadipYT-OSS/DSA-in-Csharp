# IList.Remove(Object) Method for Array Class in C# 12

## 📖 Definition
The `IList.Remove(object)` method is an explicit interface member implementation for arrays in C#. This method removes the first occurrence of a specific object from the `IList`. However, since arrays have a fixed size, calling this method will always throw a `NotSupportedException`.

## 🔄 Overloads
The `IList.Remove(object)` method does not have overloads. It is a single method that attempts to remove an object from the array.

## 💡 Example
Here is an example demonstrating the behavior of the `IList.Remove(object)` method in C# 12:

```csharp
using System;
using System.Collections;

class Program {
    static void Main(string[] args) {
        // Create and initialize an array
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Cast the array to IList to access the Remove method
        IList list = (IList)numbers;

        try {
            // Attempt to remove an element from the array
            list.Remove(3);
        } catch (NotSupportedException e) {
            Console.WriteLine("Exception: " + e.Message);
        }
    }
}
```

🎉 Happy Coding! 😊