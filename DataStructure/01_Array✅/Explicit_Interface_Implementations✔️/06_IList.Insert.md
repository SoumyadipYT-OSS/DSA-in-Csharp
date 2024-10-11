# IList.Insert(Object) Method for Array Class in C# 12

## 📖 Definition
The `IList.Insert(object)` method is an explicit interface member implementation for arrays in C#. This method inserts an item into the `IList` at the specified index. However, since arrays have a fixed size, calling this method will always throw a `NotSupportedException`.

## 🔄 Overloads
The `IList.Insert(object)` method does not have overloads. It is a single method that attempts to insert an object into the array.

## 💡 Example
Here is an example demonstrating the behavior of the `IList.Insert(object)` method in C# 12:

```csharp
using System;
using System.Collections;

class Program {
    static void Main(string[] args) {
        // Create and initialize an array
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Cast the array to IList to access the Insert method
        IList list = (IList)numbers;

        try {
            // Attempt to insert an element into the array
            list.Insert(2, 6);
        } catch (NotSupportedException e) {
            Console.WriteLine("Exception: " + e.Message);
        }
    }
}
```

🎉 Happy Coding! 😊