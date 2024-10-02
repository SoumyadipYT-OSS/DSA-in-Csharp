﻿# 🔍 Array.BinarySearch Method in C#

Welcome to the comprehensive guide on the `Array.BinarySearch` method in C#! This method is a powerful tool for efficiently searching sorted arrays. Let's dive into its definition, various overloads, and detailed explanations of each.

## 📚 In This Article

1. Definition
2. Overloads
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

1. `BinarySearch(Array, Object)`
2. `BinarySearch(Array, Object, IComparer)`
3. `BinarySearch(Array, Int32, Int32, Object)`
4. `BinarySearch(Array, Int32, Int32, Object, IComparer)`
5. `BinarySearch<T>(T[], T)`
6. `BinarySearch<T>(T[], T, IComparer<T>)`
7. `BinarySearch<T>(T[], Int32, Int32, T)`
8. `BinarySearch<T>(T[], Int32, Int32, T, IComparer<T>)`

## BinarySearch(Array, Object)
Searches an entire one-dimensional sorted array for a specific element, using
the *IComparable* interface implemented by each element of the array and by the specified object.

**Syntax:**
```cs --region BinarySearch(Array, Object)
public static int BinarySearch(Array array, object? value);
```
 
 
## Try .NET Editor

You can try out the code examples directly in your browser using the embedded Try .NET editor below:

```html
<iframe src="https://try.dot.net/?fromGist=df44833326fcc575e8169fccb9d41fc7" width="100%" height="500px"></iframe>
```