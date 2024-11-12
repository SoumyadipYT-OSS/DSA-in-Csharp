# Welcome to the ArrayList Guide for C# 12!

**Get ready to harness the power of dynamic collections with ArrayList!** 🚀

**ArrayList** is a part of the **System.Collections** namespace in C# and offers a flexible array that grows dynamically as you add elements. Let's dive in!

---

## 🧩 What is ArrayList?

An **ArrayList** is a non-generic collection designed to store elements of any data type. It's particularly useful when you need a collection that can handle different types of objects without predefined size.

### Key Features:
- **Dynamic Sizing**: Automatically resizes as elements are added or removed.
- **Heterogeneous Storage**: Stores items of different types.
- **Index-based Access**: Elements can be accessed using an index.

---

## 🛠️ Usage

Here's a quick guide to get started with `ArrayList` in C#:

### 1. **Creating an ArrayList:**
```csharp
using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList arrayList = new ArrayList();
    }
}
```


## 🌟 ArrayList Methods

| **Method**               | **Description**                                                                 |
|--------------------------|---------------------------------------------------------------------------------|
| **Add(object value)**    | Adds an element to the end of the ArrayList.                                     |
| **Clear()**              | Removes all elements from the ArrayList.                                         |
| **Contains(object value)**| Checks if the ArrayList contains the specified element.                         |
| **IndexOf(object value)** | Returns the index of the first occurrence of the specified element.             |
| **Insert(int index, object value)** | Inserts an element at the specified index.                            |
| **Remove(object value)**  | Removes the first occurrence of the specified element.                         |
| **RemoveAt(int index)**   | Removes the element at the specified index.                                     |
| **Sort()**               | Sorts the elements in the ArrayList.                                             |



## 🚀 Why Use ArrayList?
#### *Pros:*
• Flexible sizing
• Can store different types of elements
• Easy to use for small collections
#### *Cons:*
• Not type-safe (runtime errors if wrong types are accessed)
• Less efficient compared to generic collections