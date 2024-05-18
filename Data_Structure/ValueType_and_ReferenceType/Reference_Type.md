_Reference Type_

Unlike value types, reference types are not copied when they are assigned to a variable or constant, or when they are passed to a function. Rather than a copy, a reference to the same existing instance is used instead.
A reference type doesn't store its value directly. Instead, it stores the address where the values is being stored. In other words, a reference type contains a pointer to another memory location that
holds the data.

For example, consider the following string variable:
string s = "Hello, World!";

now suppose, string data-type 's' pointing to "0x803200" memory location.
In the RAM(Random Access Memory) of the computer, the string "Hello, World!" is stored at the memory location "0x803200". 
The variable 's' contains the address of the memory location where the string is stored.

Now reference type variable contains the address "0x600000" where the actual data is stored. 
When we assign the reference type variable to another variable, the address of the memory location is copied, not the actual data. 

the system selects a random location in memory (0x803200) for the variable s. The value of a variable s is 0x600000, 
which is the memory address of the actual data value. 
Thus, reference type stores the address of the location where the actual value is stored instead of the value itself.


• Passing Reference Type Variables

When you pass a reference type variable from one method to another, it doesn't create a new copy; instead, it passes
the variable's address. So, If we change the value of a variable in a mehtod, it will also be reflected in the calling method.
