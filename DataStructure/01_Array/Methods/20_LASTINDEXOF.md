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

class Program {
    static void Main() {
        // Creates and initializes a new Array with three elements of the same value.
        Array myArray=Array.CreateInstance( typeof(string), 12 );
        myArray.SetValue( "the", 0 );
        myArray.SetValue( "quick", 1 );
        myArray.SetValue( "brown", 2 );
        myArray.SetValue( "fox", 3 );
        myArray.SetValue( "jumps", 4 );
        myArray.SetValue( "over", 5 );
        myArray.SetValue( "the", 6 );
        myArray.SetValue( "lazy", 7 );
        myArray.SetValue( "dog", 8 );
        myArray.SetValue( "in", 9 );
        myArray.SetValue( "the", 10 );
        myArray.SetValue( "barn", 11 );

        // Displays the values of the Array.
        Console.WriteLine( "The Array contains the following values:" );
        PrintIndexAndValues( myArray );
        
        // Searches for the last occurrence of the duplicated value.
        string myString = "the";
        int myIndex = Array.LastIndexOf( myArray, myString );
        Console.WriteLine( "The last occurrence of \"{0}\" is at index {1}.", myString, myIndex );
        
        // Searches for the last occurrence of the duplicated value in the first section of the Array.
        myIndex = Array.LastIndexOf( myArray, myString, 8 );
        Console.WriteLine( "The last occurrence of \"{0}\" between the start and index 8 is at index {1}.", myString, myIndex );
        
        // Searches for the last occurrence of the duplicated value in a section of the Array.
        // Note that the start index is greater than the end index because the search is done backward.
        myIndex = Array.LastIndexOf( myArray, myString, 10, 6 );
        Console.WriteLine( "The last occurrence of \"{0}\" between index 5 and index 10 is at index {1}.", myString, myIndex );
        
        void PrintIndexAndValues( Array anArray )  {
           for ( int i = anArray.GetLowerBound(0); i <= anArray.GetUpperBound(0); i++ )
              Console.WriteLine( "\t[{0}]:\t{1}", i, anArray.GetValue( i ) );
        }
    }
}


/*
            This code produces the following output.
            
            The Array contains the following values:
               [0]:    the
               [1]:    quick
               [2]:    brown
               [3]:    fox
               [4]:    jumps
               [5]:    over
               [6]:    the
               [7]:    lazy
               [8]:    dog
               [9]:    in
               [10]:    the
               [11]:    barn
            The last occurrence of "the" is at index 10.
            The last occurrence of "the" between the start and index 8 is at index 6.
            The last occurrence of "the" between index 5 and index 10 is at index 10.
        */
```



## LastIndexOf(Array, Object, Int32) 🔍
Searches for the specified object and returns the zero-based index of the last occurrence within the range of 
elements in the array that extends from the first element to the specified index.

### Example 💡
```csharp
using System;

class Program {
    static void Main() {
        int[] numbers = { 1, 2, 3, 4, 3, 2, 1 };

        // Find the last occurrence of 3, starting from index 3
        int index = Array.LastIndexOf(numbers, 3, 3);
        Console.WriteLine("Last index of 3 starting from index 3: " + index); // Output: 2
    }
}
```



## LastIndexOf(Array, Object, Int32, Int32) 🔍
Searches for the specified object and returns the zero-based index of the last occurrence within the range 
of elements in the array that contains the specified number of elements and ends at the specified index.

### Example 💡
```csharp
using System;

class Program {
    static void Main() {
        int[] numbers = { 1, 2, 3, 4, 3, 2, 1 };

        // Find the last occurrence of 3, starting from index 4 and searching 4 elements
        int index = Array.LastIndexOf(numbers, 3, 4, 4);
        Console.WriteLine("Last index of 3 starting from index 4 and searching 4 elements: " + index); // Output: 2
    }
}
```




## LastIndexOf<T>(T[], T) 🔍
Searches for the specified object and returns the index of the last occurrence within the entire Array.
*This method searches for the specified object and returns the zero-based index of the last occurrence within the entire array.*

### Example 💡
```csharp
using System;

class Program {
    static void Main() {
        string[] words = { "apple", "banana", "cherry", "apple", "date", "banana", "apple" };

        // Find the last occurrence of "apple"
        int index = Array.LastIndexOf(words, "apple");
        Console.WriteLine("Last index of 'apple': " + index); // Output: 6
    }
}
```




## LastIndexOf<T>(T[], T, Int32) 🔍
Searches for the specified object and returns the index of the last occurrence within the range of elements 
in the Array that extends from the first element to the specified index.

### Example 💡
```csharp
using System;

class Program {
    static void Main() {
        string[] words = { "apple", "banana", "cherry", "apple", "date", "banana", "apple" };

        // Find the last occurrence of "banana", starting from index 5
        int index = Array.LastIndexOf(words, "banana", 5);
        Console.WriteLine("Last index of 'banana' starting from index 5: " + index); // Output: 5
    }
}
```