# Array.Clear Method in C#

## In This Article
- Definition
- Overloads
- Clear(Array)
- Clear(Array, Int32, Int32)

## Definition
**Namespace**: System  
**Assembly**: System.Runtime.dll

## Overloads
| Method Signature | Description |
|------------------|-------------|
| `Clear(Array)` | Clears the contents of an array. |
| `Clear(Array, Int32, Int32)` | Sets a range of elements in an array to the default value of each element type. |


`Clear Array`
```cs --region Clear(Array)
public static void Clear (Array array);
```

`Clear(Array, Int32, Int32)`
**Syntax:**
```cs --region Clear(Array, Int32, Int32)
public static void Clear (Array array, int index, int length);
```

**Example:**
```cs
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
Console.WriteLine("Before Clear:");
foreach (var num in numbers) Console.Write(num + " ");
Console.WriteLine();

Array.Clear(numbers, 2, 5);
Console.WriteLine("After Clear:");
foreach (var num in numbers) Console.Write(num + " ");
Console.WriteLine();
```

## Notes
**•Default Values**: Clears elements to their default values (e.g., 0 for integers, null for reference types).
**•Exceptions**: Throws ArgumentNullException if the array is null, ArgumentOutOfRangeException if the index or length is out of range.

Happy Coding! 😇