# Array.Sort Method in C# 12

## Overview
The `Array.Sort` method in C# 12 is used to sort the elements in a one-dimensional array. 
This method is part of the `System` namespace and provides various overloads to sort arrays based on different criteria.

####### _Sorts the elements in a one-dimensional array._

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
