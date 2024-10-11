# IList.Clear Method for Array Class in C# 12

## 📖 Definition
The `IList.Clear` method is an explicit interface member implementation for arrays in C#. This method is designed to remove all items from an `IList`. However, since arrays have a fixed size, calling this method will always throw a `NotSupportedException`.

## 🔄 Overloads
The `IList.Clear` method does not have overloads. It is a single method that attempts to clear the array.

## 💡 Example
Here is an example demonstrating the behavior of the `IList.Clear` method in C# 12:

```csharp
using System;
using System.Collections;

class Program {
    static void Main(string[] args) {
        // Create and initialize an array
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Cast the array to IList to access the Clear method
        IList list = (IList)numbers;

        try {
            // Attempt to clear the array
            list.Clear();
        } catch (NotSupportedException e) {
            Console.WriteLine("Exception: " + e.Message);
        }
    }
}
```

🎉 Happy Coding! 😊