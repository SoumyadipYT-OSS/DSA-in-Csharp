# Array.FindIndex Method in C#

## In This Article
- Definition
- Overloads
- FindIndex(Array, Predicate<T>)
- FindIndex(Array, Int32, Predicate<T>)
- FindIndex(Array, Int32, Int32, Predicate<T>)
- Examples
- Notes
- Additional Resources

## Definition
**Namespace**: System  
**Assembly**: System.Runtime.dll

The `Array.FindIndex` method searches for an element that matches the conditions defined by a specified predicate and returns the zero-based index of the first occurrence within an array or a portion of it.

## Overloads
| Method Signature | Description |
|------------------|-------------|
| `FindIndex<T>(T[], Predicate<T>)` | Searches for an element that matches the conditions defined by the specified predicate and returns the zero-based index of the first occurrence within the entire array. |
| `FindIndex<T>(T[], Int32, Predicate<T>)` | Searches for an element that matches the conditions defined by the specified predicate and returns the zero-based index of the first occurrence within the range of elements in the array that extends from the specified index to the last element. |
| `FindIndex<T>(T[], Int32, Int32, Predicate<T>)` | Searches for an element that matches the conditions defined by the specified predicate and returns the zero-based index of the first occurrence within the range of elements in the array that starts at the specified index and contains the specified number of elements. |

## FindIndex(Array, Predicate<T>)
Searches for an element that matches the conditions defined by the specified predicate and returns the zero-based index of the first occurrence within the entire array.

### Example
```csharp
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15 };
        Predicate<int> predicate = num => num > 10;
        int index = Array.FindIndex(numbers, predicate);

        Console.WriteLine($"The first number greater than 10 is at index: {index}");
        Console.WriteLine($"The number is: {numbers[index]}");
    }
}