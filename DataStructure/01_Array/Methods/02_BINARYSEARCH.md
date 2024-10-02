# 🔍 Array.BinarySearch Method in C#

Welcome to the comprehensive guide on the `Array.BinarySearch` method in C#! This method is a powerful tool for efficiently searching sorted arrays. Let's dive into its definition, various overloads, and detailed explanations of each.

## 📚 In This Article

1. *Definition*
2. *Overloads*
3. BinarySearch(Array, Object)
4. BinarySearch(Array, Object, IComparer)
5. BinarySearch(Array, Int32, Int32, Object)
6. BinarySearch(Array, Int32, Int32, Object, IComparer)
7. [BinarySearch<T>(T[], T)](#binarysearcht-t-t)
8. [BinarySearch<T>(T[], T, IComparer<T>)](#binarysearcht-t-t-icomparert)
9. [BinarySearch<T>(T[], Int32, Int32, T)](#binarysearcht-t-int32-int32-t)
10. [BinarySearch<T>(T[], Int32, Int32, T, IComparer<T>)](#binarysearcht-t-int32-int32-t-icomparert)

## Definition

The `Array.BinarySearch` method performs a binary search on a sorted array, using the binary search algorithm. This algorithm repeatedly divides the search interval in half, making it highly efficient with a time complexity of O(log n).

## Overloads

The `Array.BinarySearch` method comes with several overloads to cater to different needs:
-------------
| Overload | Description |
|:-|:-|
| BinarySearch(Array, Object) | Searches an entire one-dimensional sorted array for a specific element, using the *IComparable* interface implemented by each element of the array and by the specified object. |
| BinarySearch(Array, Object, IComparer) | Searches an entire one-dimensional sorted array for a specific element, using the specified comparer. |
| BinarySearch(Array, Int32, Int32, Object) | Searches a range of elements in a one-dimensional sorted array for a specific element, using the *IComparable* interface implemented by each element of the array and by the specified object. |
| BinarySearch(Array, Int32, Int32, Object, IComparer) | Searches a range of elements in a one-dimensional sorted array for a specific element, using the specified comparer. |
| BinarySearch\<T>(T[], T) | Searches an entire one-dimensional sorted generic array for a specific element. |
| BinarySearch\<T>(T[], T, IComparer\<T>) | Searches an entire one-dimensional sorted generic array for a specific element, using the specified comparer. |
| BinarySearch\<T>(T[], Int32, Int32, T) | Searches a range of elements in a one-dimensional sorted generic array for a specific element. |
| BinarySearch\<T>(T[], Int32, Int32, T, IComparer\<T>) | Searches a range of elements in a one-dimensional sorted generic array for a specific element, using the specified comparer. |
-------------



## BinarySearch(Array, Object)
Searches an entire one-dimensional sorted array for a specific element, using
the *IComparable* interface implemented by each element of the array and by the specified object.

**Syntax:**
```cs --region BinarySearch(Array, Object)
public static int BinarySearch(Array array, object? value);
```

**Example:**
```cs
using System;

public class BinarySearchExample {
    public static void Main() {
        // Create and sort an array
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13 };
        Array.Sort(numbers);

        // Value to search for
        int valueToFind = 7;

        // Perform binary search
        int index = Array.BinarySearch(numbers, valueToFind);

        // Check the result
        if (index >= 0) {
            Console.WriteLine($"Value {valueToFind} found at index {index}.");
        } else {
            Console.WriteLine($"Value {valueToFind} not found. Nearest index: {~index}.");
        }
    }
}
```



## BinarySearch(Array, Object, IComparer)
Searches an entire one-dimensional sorted array for a specific element, using the specified comparer.

**Syntax:**
```cs --region BinarySearch(Array, Object, IComparer)
public static int BinarySearch(Array array, object? value, IComparer comparer);
```

**Example:**
```cs
using System;
using System.Collections;

public class BinarySearchExample {
    public static void Main() {
        // Create and sort an array of strings
        string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Fig", "Grape" };
        Array.Sort(fruits);

        // Value to search for
        string valueToFind = "Cherry";

        // Perform binary search using a custom comparer
        int index = Array.BinarySearch(fruits, valueToFind, new CaseInsensitiveComparer());

        // Check the result
        if (index >= 0) {
            Console.WriteLine($"Value '{valueToFind}' found at index {index}.");
        }
        else {
            Console.WriteLine($"Value '{valueToFind}' not found. Nearest index: {~index}.");
        }
    }
}

// Custom comparer for case-insensitive comparison
public class CaseInsensitiveComparer : IComparer {
    public int Compare(object x, object y) {
        return string.Compare(x?.ToString(), y?.ToString(), StringComparison.OrdinalIgnoreCase);
    }
}
```



## BinarySearch(Array, Int32, Int32, Object)
Searches a range of elements in a one-dimensional sorted array for a value, 
using the IComparable interface implemented by each element 
of the array and by the specified value.

**Syntax:**
```cs --region BinarySearch(Array, Int32, Int32, Object)
public static int BinarySearch (Array array, int index, int length, object? value, System.Collections.IComparer? comparer);
```

**Example:**
```cs
using System;

public class BinarySearchExample {
    public static void Main() {
        // Create and sort an array
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        Array.Sort(numbers);

        // Define the range to search within
        int startIndex = 2; // Starting index of the range
        int length = 5;     // Number of elements in the range

        // Value to search for
        int valueToFind = 11;

        // Perform binary search within the specified range
        int index = Array.BinarySearch(numbers, startIndex, length, valueToFind);

        // Check the result
        if (index >= 0) {
            Console.WriteLine($"Value {valueToFind} found at index {index}.");
        }
        else {
            Console.WriteLine($"Value {valueToFind} not found. Nearest index: {~index}.");
        }
    }
}

```



## BinarySearch<T>(T[], T)
Searches an entire one-dimensional sorted array for a specific element, 
using the IComparable<T> generic interface implemented by each element 
of the Array and by the specified object.

**Syntax:**
```cs --region BinarySearch<T>(T[], T)
public static int BinarySearch<T> (T[] array, T value);
```

**Example:**
```cs
using System;

public class BinarySearchExample {
    public static void Main() {
        // Create and sort an array of integers
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13 };
        Array.Sort(numbers);

        // Value to search for
        int valueToFind = 7;

        // Perform binary search
        int index = Array.BinarySearch<int>(numbers, valueToFind);

        // Check the result
        if (index >= 0) {
            Console.WriteLine($"Value {valueToFind} found at index {index}.");
        } else {
            Console.WriteLine($"Value {valueToFind} not found. Nearest index: {~index}.");
        }
    }
}

```



## BinarySearch<T>(T[], T, IComparer<T>)
Searches an entire one-dimensional sorted array 
for a value using the specified IComparer<T> generic interface.

**Syntax:**
```cs --region BinarySearch<T>(T[], T, IComparer<T>)
public static int BinarySearch<T> (T[] array, T value, System.Collections.Generic.IComparer<T>? comparer);
```

**Example:**
```cs
using System;
using System.Collections.Generic;

public class BinarySearchExample {
    public static void Main() {
        // Create and sort an array of custom objects
        Person[] people = {
            new Person("Alice", 30),
            new Person("Bob", 25),
            new Person("Charlie", 35),
            new Person("Diana", 28)
        };
        Array.Sort(people, new PersonComparer());

        // Value to search for
        Person personToFind = new Person("Charlie", 35);

        // Perform binary search using a custom comparer
        int index = Array.BinarySearch(people, personToFind, new PersonComparer());

        // Check the result
        if (index >= 0) {
            Console.WriteLine($"Person {personToFind.Name} found at index {index}.");
        } else {
            Console.WriteLine($"Person {personToFind.Name} not found. Nearest index: {~index}.");
        }
    }
}

public class Person {
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age) {
        Name = name;
        Age = age;
    }
}

public class PersonComparer : IComparer<Person> {
    public int Compare(Person x, Person y) {
        if (x == null || y == null) {
            return 0;
        }
        return x.Name.CompareTo(y.Name);
    }
}

```



## BinarySearch<T>(T[], Int32, Int32, T)
Searches a range of elements in a one-dimensional sorted array for 
a value, using the IComparable<T> generic interface implemented 
by each element of the Array and by the specified value.

**Syntax:**
```cs --region BinarySearch<T>(T[], Int32, Int32, T)
public static int BinarySearch<T> (T[] array, int index, int length, T value);
```

**Example:**
```cs
using System;

public class BinarySearchExample {
    public static void Main() {
        // Create and sort an array of integers
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        Array.Sort(numbers);

        // Define the range to search within
        int startIndex = 2; // Starting index of the range
        int length = 5;     // Number of elements in the range

        // Value to search for
        int valueToFind = 11;

        // Perform binary search within the specified range
        int index = Array.BinarySearch<int>(numbers, startIndex, length, valueToFind);

        // Check the result
        if (index >= 0) {
            Console.WriteLine($"Value {valueToFind} found at index {index}.");
        } else {
            Console.WriteLine($"Value {valueToFind} not found. Nearest index: {~index}.");
        }
    }
}
```



## BinarySearch<T>(T[], Int32, Int32, T, IComparer<T>)
Searches a range of elements in a one-dimensional sorted 
array for a value, using the specified IComparer<T> generic interface.

**Syntax:**
```cs --region BinarySearch<T>(T[], Int32, Int32, T, IComparer<T>)
public static int BinarySearch<T> (T[] array, int index, int length, T value, System.Collections.Generic.IComparer<T>? comparer);
```

**Example:**
```cs
using System;
using System.Collections.Generic;

public class BinarySearchExample {
    public static void Main() {
        // Create and sort an array of custom objects
        Person[] people = {
            new Person("Alice", 30),
            new Person("Bob", 25),
            new Person("Charlie", 35),
            new Person("Diana", 28),
            new Person("Eve", 22)
        };
        Array.Sort(people, new PersonComparer());

        // Define the range to search within
        int startIndex = 1; // Starting index of the range
        int length = 3;     // Number of elements in the range

        // Value to search for
        Person personToFind = new Person("Charlie", 35);

        // Perform binary search within the specified range using a custom comparer
        int index = Array.BinarySearch(people, startIndex, length, personToFind, new PersonComparer());

        // Check the result
        if (index >= 0) {
            Console.WriteLine($"Person {personToFind.Name} found at index {index}.");
        }
        else {
            Console.WriteLine($"Person {personToFind.Name} not found. Nearest index: {~index}.");
        }
    }
}

public class Person {
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age) {
        Name = name;
        Age = age;
    }
}

public class PersonComparer : IComparer<Person> {
    public int Compare(Person x, Person y) {
        if (x == null || y == null) {
            return 0;
        }
        return x.Name.CompareTo(y.Name);
    }
}

```

## 📚 Conclusion
Binary Search is a built-in method of `Array` class in C#. It is a powerful tool for efficiently searching sorted arrays. 
By understanding the various overloads of the `Array.BinarySearch` method, you can leverage its capabilities to perform 
binary searches on both primitive and custom data types. This method is particularly useful when working with large 
datasets where performance is critical.


Happy coding! 🚀