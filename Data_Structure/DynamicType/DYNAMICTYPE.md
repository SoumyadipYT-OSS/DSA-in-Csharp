# CSharp - Dynamic Types

C# 4.0 (.NET 4.5) introduced a new type called dynamic that avoids compile-time type checking. A dynamic type escapes type checking at compile-time; instead, it resolves type at run time.
The dynamic type is a static type, but an object of type dynamic bypasses static type checking. In most cases, it functions like it has type object. At compile time, an element that is typed as dynamic is assumed to support any operation. Therefore, you can call any method, access any property, or index any object without warning.

The compiler compiles the code without any error and the runtime handles the object according to the type of data it is holding.

Dynamic types change types at run-time on the assigned value.