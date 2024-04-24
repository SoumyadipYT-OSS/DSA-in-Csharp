# CSharp - Anonymous Type

In C#, an anonymous type is a type that is inferred by the compiler. 
It is a type that is defined without a name. It is used to create objects without writing a class definition for the data type. 
It is used to create objects on the fly.

You can create an anonymous type using the new keyword followed by
the object initializer.


An anonymous type will always be local to the method where it is defined. It cannot be returned from the method. However, an anonymous type can be passed to the method as object type parameter, but it is not recommended. If you need to pass it to another method, then use struct or class instead of an anonymous type.

Mostly, anonymous types are created using the Select clause of a LINQ queries to return a subset of the properties from each object in the collection.