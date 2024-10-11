# Array.IList.RemoveAt(Int32) Method for Array Class in C# 12

## 📖 Definition
The `Array.IList.RemoveAt(Int32)` method is an explicit interface member implementation for arrays in C#. This method removes the element at the specified index in the `IList`. However, since arrays have a fixed size, calling this method will always throw a `NotSupportedException`.

## 🔄 Overloads
The `Array.IList.RemoveAt(Int32)` method does not have overloads. It is a single method that attempts to remove an element at a specified index.

## 💡 Example
Here is an example demonstrating the behavior of the `Array.IList.RemoveAt(Int32)` method in C# 12:

```csharp
using System;
using System.Collections;

class Program {
    static void Main(string[] args) {
        // Create and initialize an array
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Cast the array to IList to access the RemoveAt method
        IList list = (IList)numbers;

        try {
            // Attempt to remove an element at a specific index
            list.RemoveAt(2);
        } catch (NotSupportedException e) {
            Console.WriteLine("Exception: " + e.Message);
        }
    }
}
```

🎉 Happy Coding! 😊