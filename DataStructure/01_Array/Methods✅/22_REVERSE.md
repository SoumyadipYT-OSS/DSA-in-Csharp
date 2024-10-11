## Array.Reverse Method

##### *In this article we will learn* 📚
|   • Definition 📖
|   • Overloads 🔄
|   • Reverse(Array) 🔍
|   • Reverse(Array, Int32, Int32) 🔍
|   • Reverse<T>(T[]) 🔍
|   • Reverse<T>(T[], Int32, Int32) 🔍


#### Definition 📖
	- **Namespace**: System
	- **Assembly**: System.Runtime.dll

Reverses the order of the elements in a one-dimensional Array or in a portion of the Array.



## Overloads 🔄
| Method Signature | Description |
|------------------|-------------|
| `Reverse(Array)`   | Reverses the sequence of the elements in the entire one-dimensional Array. |
| `Reverse(Array, Int32, Int32)` | Reverses the sequence of a subset of the elements in the one-dimensional Array. |
| `Reverse<T>(T[])`  | Reverses the sequence of the elements in the one-dimensional generic array. |
| `Reverse<T>(T[], Int32, Int32)` | Reverses the sequence of a subset of the elements in the one-dimensional generic array. |



## Reverse(Array)
Reverses the sequence of the elements in the entire one-dimensional `Array`.

```csharp
public static void Reverse (Array array);
```

### Example 💡
```csharp
using System;
public class SamplesArray  {

   public static void Main()  {

      // Creates and initializes a new Array.
      Array myArray=Array.CreateInstance( typeof(string), 9 );
      myArray.SetValue( "The", 0 );
      myArray.SetValue( "quick", 1 );
      myArray.SetValue( "brown", 2 );
      myArray.SetValue( "fox", 3 );
      myArray.SetValue( "jumps", 4 );
      myArray.SetValue( "over", 5 );
      myArray.SetValue( "the", 6 );
      myArray.SetValue( "lazy", 7 );
      myArray.SetValue( "dog", 8 );

      // Displays the values of the Array.
      Console.WriteLine( "The Array initially contains the following values:" );
      PrintIndexAndValues( myArray );

      // Reverses the sort of the values of the Array.
      Array.Reverse( myArray );

      // Displays the values of the Array.
      Console.WriteLine( "After reversing:" );
      PrintIndexAndValues( myArray );
   }

   public static void PrintIndexAndValues( Array myArray )  {
      for ( int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++ )
         Console.WriteLine( "\t[{0}]:\t{1}", i, myArray.GetValue( i ) );
   }
}
/*
This code produces the following output.

The Array initially contains the following values:
    [0]:    The
    [1]:    quick
    [2]:    brown
    [3]:    fox
    [4]:    jumps
    [5]:    over
    [6]:    the
    [7]:    lazy
    [8]:    dog
After reversing:
    [0]:    dog
    [1]:    lazy
    [2]:    the
    [3]:    over
    [4]:    jumps
    [5]:    fox
    [6]:    brown
    [7]:    quick
    [8]:    The
*/
```


### Remarks 📘
After a call to this method, the element at `myArray[i]`, where `i` is any index in the array, moves to `myArray[j]`, 
where `j` equals `(myArray.Length + myArray.GetLowerBound(0)) - (i - myArray.GetLowerBound(0)) - 1`.

This method is an O(`n`) operation, where `n` is the __Length__ of `array`.




## Reverse(Array, Int32, Int32)
Reverse the sequence of a subset of the elements in the one-dimensional `Array`.

```csharp
public static void Reverse (Array array, int index, int length);
```

### Example 💡
```csharp
using System;
public class SamplesArray1  {

   public static void Main()  {

      // Creates and initializes a new Array.
      Array myArray=Array.CreateInstance( typeof(string), 9 );
      myArray.SetValue( "The", 0 );
      myArray.SetValue( "QUICK", 1 );
      myArray.SetValue( "BROWN", 2 );
      myArray.SetValue( "FOX", 3 );
      myArray.SetValue( "jumps", 4 );
      myArray.SetValue( "over", 5 );
      myArray.SetValue( "the", 6 );
      myArray.SetValue( "lazy", 7 );
      myArray.SetValue( "dog", 8 );

      // Displays the values of the Array.
      Console.WriteLine( "The Array initially contains the following values:" );
      PrintIndexAndValues( myArray );

      // Reverses the sort of the values of the Array.
      Array.Reverse( myArray, 1, 3 );

      // Displays the values of the Array.
      Console.WriteLine( "After reversing:" );
      PrintIndexAndValues( myArray );
   }

   public static void PrintIndexAndValues( Array myArray )  {
      for ( int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++ )
         Console.WriteLine( "\t[{0}]:\t{1}", i, myArray.GetValue( i ) );
   }
}
/*
This code produces the following output.

The Array initially contains the following values:
    [0]:    The
    [1]:    QUICK
    [2]:    BROWN
    [3]:    FOX
    [4]:    jumps
    [5]:    over
    [6]:    the
    [7]:    lazy
    [8]:    dog
After reversing:
    [0]:    The
    [1]:    FOX
    [2]:    BROWN
    [3]:    QUICK
    [4]:    jumps
    [5]:    over
    [6]:    the
    [7]:    lazy
    [8]:    dog
*/
```




## Reverse<T>(T[])
Reverses the sequence of the elements in the one-dimensional generic array.

```csharp
public static void Reverse<T> (T[] array);
```




## Reverse<T>(T[], Int32, Int32)
Reverses the sequence of a subset of the elements in the one-dimensional generic array.

```csharp
public static void Reverse<T> (T[] array, int index, int length);
```


## Contributing 🤝
Feel free to contribute to this repository by submitting issues or pull requests. Let's make this resource better together!

## License 📄
This project is licensed under the MIT License - see the LICENSE file for details.


![signature](https://github.com/user-attachments/assets/748d14a3-56b1-4b11-abff-0a75eff93b16)

Happy coding! 🚀