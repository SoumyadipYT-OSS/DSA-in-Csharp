# Array.CopyTo Method in C#

## In This Article
- Definition
- Overloads
- CopyTo(Array, Int32)
- CopyTo(Array, Int64)

## Definition
**Namespace**: System  
**Assembly**: System.Runtime.dll

## Overloads
| Method Signature | Description |
|------------------|-------------|
| `CopyTo(Array, Int32)` | Copies all elements of the current one-dimensional array to the specified one-dimensional array starting at the specified destination array index (32-bit integer). |
| `CopyTo(Array, Int64)` | Copies all elements of the current one-dimensional array to the specified one-dimensional array starting at the specified destination array index (64-bit integer). |

## CopyTo(Array, Int32)
Copies all elements of the current one-dimensional array to the specified one-dimensional array starting at the specified destination array index (32-bit integer).

### Example
```cs
int[] sourceArray = { 1, 2, 3, 4, 5 };
int[] targetArray = new int[10];

Console.WriteLine("Before CopyTo:");
foreach (var num in targetArray) Console.Write(num + " ");
Console.WriteLine();

sourceArray.CopyTo(targetArray, 3);

Console.WriteLine("After CopyTo:");
foreach (var num in targetArray) Console.Write(num + " ");
Console.WriteLine();
```