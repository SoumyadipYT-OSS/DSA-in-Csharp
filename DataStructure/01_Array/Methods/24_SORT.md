# Array.Sort Method in C# 12

## Overview
The `Array.Sort` method in C# 12 is used to sort the elements in a one-dimensional array. 
This method is part of the `System` namespace and provides various overloads to sort arrays based on different criteria.

###### _Sorts the elements in a one-dimensional array._


## 📖 Definition
The `Array.Sort` method is a versatile tool for sorting arrays in C# 12. 
It provides multiple overloads to handle different sorting scenarios, including sorting entire arrays, 
sorting specific ranges within arrays, and using custom comparers or comparison delegates. 
This flexibility makes it suitable for a wide range of applications, from simple sorting 
tasks to complex data manipulation.

## Syntax
```csharp
public static void Sort (Array keys, Array? items, int index, int length, System.Collections.IComparer? comparer);

public static void Sort (Array array, int index, int length, System.Collections.IComparer? comparer);

public static void Sort (Array keys, Array? items, int index, int length);

public static void Sort (Array array, int index, int length);

public static void Sort (Array keys, Array? items, System.Collections.IComparer? comparer);

public static void Sort (Array keys, Array? items);

public static void Sort (Array array);

public static void Sort (Array array, System.Collections.IComparer? comparer);

public static void Sort<T> (T[] array);

public static void Sort<T> (T[] array, System.Collections.Generic.IComparer<T>? comparer);

public static void Sort<T> (T[] array, Comparison<T> comparison);

public static void Sort<T> (T[] array, int index, int length);

public static void Sort<T> (T[] array, int index, int length, System.Collections.Generic.IComparer<T>? comparer);

public static void Sort<TKey,TValue> (TKey[] keys, TValue[]? items, int index, int length, System.Collections.Generic.IComparer<TKey>? comparer);

public static void Sort<TKey,TValue> (TKey[] keys, TValue[]? items);

public static void Sort<TKey,TValue> (TKey[] keys, TValue[]? items, System.Collections.Generic.IComparer<TKey>? comparer);

public static void Sort<TKey,TValue> (TKey[] keys, TValue[]? items, int index, int length);
```


## 🔄 Overloads
| Method | Description |
|--------|-------------|
| Sort(Array, Array, Int32, Int32, IComparer) | Sorts a range of elements in a pair of one-dimensional Array objects (one contains the keys and the other contains the corresponding items) based on the keys in the first Array using the specified IComparer. |
| Sort(Array, Int32, Int32, IComparer) | Sorts the elements in a range of elements in a one-dimensional Array using the specified IComparer. |
| Sort(Array, Array, Int32, Int32) | Sorts a range of elements in a pair of one-dimensional Array objects (one contains the keys and the other contains the corresponding items) based on the keys in the first Array using the IComparable implementation of each key. |
| Sort(Array, Int32, Int32) | Sorts the elements in a range of elements in a one-dimensional Array using the IComparable implementation of each element of the Array. |
| Sort(Array, Array, IComparer) | Sorts a pair of one-dimensional Array objects (one contains the keys and the other contains the corresponding items) based on the keys in the first Array using the specified IComparer. |
| Sort(Array, Array) | Sorts a pair of one-dimensional Array objects (one contains the keys and the other contains the corresponding items) based on the keys in the first Array using the IComparable implementation of each key. |
| Sort(Array) | Sorts the elements in an entire one-dimensional Array using the IComparable implementation of each element of the Array. |
| Sort(Array, IComparer) | Sorts the elements in a one-dimensional Array using the specified IComparer. |
| Sort<T>(T[]) | Sorts the elements in an entire Array using the IComparable<T> generic interface implementation of each element of the Array. |
| Sort<T>(T[], IComparer<T>) | Sorts the elements in an Array using the specified IComparer<T> generic interface. |
| Sort<T>(T[], Comparison<T>) | Sorts the elements in an Array using the specified Comparison<T>. |
| Sort<T>(T[], Int32, Int32) | Sorts the elements in a range of elements in an Array using the IComparable<T> generic interface implementation of each element of the Array. |
| Sort<T>(T[], Int32, Int32, IComparer<T>) | Sorts the elements in a range of elements in an Array using the specified IComparer<T> generic interface. |
| Sort<TKey,TValue>(TKey[], TValue[], Int32, Int32, IComparer<TKey>) | Sorts a range of elements in a pair of Array objects (one contains the keys and the other contains the corresponding items) based on the keys in the first Array using the specified IComparer<T> generic interface. |
| Sort<TKey,TValue>(TKey[], TValue[]) | Sorts a pair of Array objects (one contains the keys and the other contains the corresponding items) based on the keys in the first Array using the IComparable<T> generic interface implementation of each key. |
| Sort<TKey,TValue>(TKey[], TValue[], IComparer<TKey>) | Sorts a pair of Array objects (one contains the keys and the other contains the corresponding items) based on the keys in the first Array using the specified IComparer<T> generic interface. |
| Sort<TKey,TValue>(TKey[], TValue[], Int32, Int32) | Sorts a range of elements in a pair of Array objects (one contains the keys and the other contains the corresponding items) based on the keys in the first Array using the IComparable<T> generic interface implementation of each key. |



## 💡 Examples
### Sort an Entire Array
```csharp
int[] numbers = { 5, 2, 8, 3, 1 };
Array.Sort(numbers);
Console.WriteLine(string.Join(", ", numbers)); // Output: 1, 2, 3, 5, 8
```


🤝 Contribution
We welcome contributions to improve the Array.Sort method documentation and examples. If you have suggestions, bug fixes, or enhancements, please follow these steps:

	1. Fork the Repository: Click the “Fork” button at the top right of this page to 
		create a copy of this repository in your GitHub account.

	2. Clone the Repository: Clone your forked repository to your local machine using:
		`git clone https://github.com/your-username/your-repo-name.git`

	3. **Create a Branch**: Create a new branch for your changes:
		`git checkout -b feature/your-feature-name`

	4. **Make Changes**: Make your changes to the code or documentation.

	5. **Commit Changes**: Commit your changes with a descriptive commit message:
		`git commit -m "Description of your changes"`

	6. **Push Changes**: Push your changes to your forked repository:
		`git push origin feature/your-feature-name`

	7. **Create a Pull Request**: Open a pull request from your forked repository to the main repository. 
								Provide a clear description of your changes and why they are beneficial.

_We appreciate your contributions and will review them as soon as possible._



## 📝 Conclusion
The `Array.Sort` method in C# 12 is a powerful and flexible tool for sorting arrays. 
Whether you need to sort an entire array, a specific range, or use custom sorting logic, 
Array.Sort has you covered. By understanding and utilizing its various overloads, 
you can efficiently manage and manipulate your data.


## 📜 License
This project is licensed under the MIT License - see the LICENSE file for details.

![signature](https://github.com/user-attachments/assets/748d14a3-56b1-4b11-abff-0a75eff93b16)

🎉 Happy Coding! 😊