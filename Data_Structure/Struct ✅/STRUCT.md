# Csharp - Struct

In C# *struct* is the value type (https://www.tutorialsteacher.com/csharp/csharp-value-type-and-reference-type) data type
that represents data structures. It can contain a parameterized constructor, static constructor, constants, fields, 
fields, methods, properties, indexers, operators, events and nested types.

*struct* can be used to hold small data values that do not require inheritance, e.g. coordinate points, key-value pairs,
and complex data structure.


**Structure Declaration**
A structure can be used to hold small data values that do not require inheritance. It is declared using the struct keyword.
A Structure is declared using `struct` keyword. The default modifier is internal for the struct and its members.

`
If you declare a variable of *struct* type without using *new* keyword, it does not call any constructor,
so all the members remain unassigned. Therefore, you must assign values to each member before accessing
them, otherwise, it will throw a compile-time error.
`
