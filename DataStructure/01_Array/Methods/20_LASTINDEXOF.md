# Array.LastIndexOf Method in C# 🎯

## In This Article 📚
- Definition 📖
- Overloads 🔄
- LastIndexOf(Array, Object) 🔍
- LastIndexOf(Array, Object, Int32) 🔍
- LastIndexOf(Array, Object, Int32, Int32) 🔍
- Examples 💡
- Notes 📝
- Additional Resources 📘

## Definition 📖
**Namespace**: System  
**Assembly**: System.Runtime.dll

The `Array.LastIndexOf` method searches for the specified object and returns the zero-based index of the last occurrence within the entire array or a portion of it.

## Overloads 🔄
| Method Signature | Description |
|------------------|-------------|
| `LastIndexOf(Array, Object)` | Searches for the specified object and returns the zero-based index of the last occurrence within the entire array. |
| `LastIndexOf(Array, Object, Int32)` | Searches for the specified object and returns the zero-based index of the last occurrence within the range of elements in the array that extends from the first element to the specified index. |
| `LastIndexOf(Array, Object, Int32, Int32)` | Searches for the specified object and returns the zero-based index of the last occurrence within the range of elements in the array that contains the specified number of elements and ends at the specified index. |
| `LastIndexOf<T>(T[], T)` | Searches for the specified object and returns the index of the last occurrence within the entire Array. |
| `LastIndexOf<T>(T[], T, Int32)` | Searches for the specified object and returns the index of the last occurrence within the range of elements in the Array that extends from the first element to the specified index. |
| `LastIndexOf<T>(T[], T, Int32, Int32)` | Searches for the specified object and returns the index of the last occurrence within the range of elements in the Array that contains the specified number of elements and ends at the specified index. |


## LastIndexOf(Array, Object) 🔍
Searches for the specified object and returns the zero-based index of the last occurrence within the entire array.

### Example 💡
```csharp
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 3, 2, 1 };

        // Find the last occurrence of 3
        int index = Array.LastIndexOf(numbers, 3);
        Console.WriteLine("Last index of 3: " + index); // Output: 4
    }
}
```