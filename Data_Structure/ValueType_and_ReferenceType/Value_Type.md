_Value Type_
In C#, value types are stored in the stack memory. Value types are derived from the System.ValueType class. Value types are derived from the System.ValueType class
C# provides the following categories of data types:

1. Value type
2. Reference type
3. Pointer type

A data type is a value type if it holds a data value within its own memory space.
It means variables of these data types directly contain values.

*For example: int i = 100;*
The system stores 100 in the memory space allocated for the variable i. The following
image illustrates how 100 is stored in the memory space allocated for the variable i.


The following data types are all of value type:
- bool
- byte
- char
- decimal
- double
- enum
- float
- int
- long
- sbyte
- short
- struct
- uint
- ulong
- ushort


• Passing Value Type Variables
When you pass a value-type variable from one method to another, the system creates a separate copy of a variable
in another method. If value got changed in the one method, it wouldn't affect the variable in another method.
