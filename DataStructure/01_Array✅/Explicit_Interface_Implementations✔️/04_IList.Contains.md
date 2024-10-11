# IList.Contains(Object) Method for Array Class in C# 12

## 📖 Definition
The `IList.Contains(object)` method is an explicit interface member implementation for arrays in C#. This method determines whether an element is in the `IList`. When using this method with arrays, it checks if a specified object exists within the array.

## 🔄 Overloads
The `IList.Contains(object)` method does not have overloads. It is a single method that checks for the presence of an object in the array.

## 💡 Example
Here is an example demonstrating the behavior of the `IList.Contains(object)` method in C# 12:

```csharp
using System;
using System.Collections;

class Program {
    static void Main(string[] args) {
        // Create and initialize an array
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Cast the array to IList to access the Contains method
        IList list = (IList)numbers;

        // Check if the array contains specific elements
        Console.WriteLine("Contains 3: " + list.Contains(3)); // Output: True
        Console.WriteLine("Contains 6: " + list.Contains(6)); // Output: False
    }
}
```
🎉 Happy Coding! 😊