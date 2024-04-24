# CSharp - Nullable Types

As you know, a value type cannot be assigned a null value. For example, int i = null will give you a compile time error.

C# 2.0 introduced nullable types that allow you to assign null to value type variables. You can declare nullable types using Nullable<t> where T is a type.


A nullable type can represent the correct range of values for its underlying value type, plus an additional null value. For example, Nullable<int> can be assigned any value from -2147483648 to 2147483647, or a null value.

The Nullable types are instances of System.Nullable<T> struct. Think it as something like the following structure.


A nullable of type int is the same as an ordinary int plus a flag that says whether the int has a value or not (is null or not). All the rest is compiler magic that treats "null" as a valid value.

The HasValue returns true if the object has been assigned a value; if it has not been assigned any value or has been assigned a null value, it will return false.

Accessing the value using NullableType.value will throw a runtime exception if nullable type is null or not assigned any value. For example, i.Value will throw an exception if i is null:


