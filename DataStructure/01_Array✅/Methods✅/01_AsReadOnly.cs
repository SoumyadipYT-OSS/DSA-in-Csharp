using System;
using System.Collections.Generic;

/*
    Namespace: System;
    Class: Array;

    Method: AsReadOnly;
    Return Type: ReadOnlyCollection<T>;
    Remarks: AsReadOnly method comes from `System.Collections.Generic.IList<T>` interface.

    Use Case:
        This method is used to create a read-only wrapper for the specified array.
        The read-only wrapper is a wrapper around the original array that prevents the array from being modified.
        But the original array can still be modified through the wrapper.
*/

class Program {
    protected static void PrintValues(string[] myArr) {
        for (int i=0; i<myArr.Length; i++) {
            Console.WriteLine("     [{0}] : {1}", i, myArr[i]);
        }
        Console.WriteLine();
    }

    protected static void PrintValues(IList<string> myList) {
        for (int i = 0; i < myList.Count; i++) {
            Console.WriteLine("     [{0}] : {1}", i, myList[i]);
        }
    }

    // Main method
    static void Main() {
        string[] myArr = { "C#", "Python", "C++", "Perl" };
        Console.WriteLine("The string array contains initially: ");
        PrintValues(myArr);

        IList<string> myList = Array.AsReadOnly(myArr);
        Console.WriteLine("\nThe read-only collection IList<string> contains: ");
        PrintValues(myList);

        // Attempt to change a value through the wrapper
        try {
            myList[3] = "Rust";
        } catch (NotSupportedException e) {
            Console.WriteLine("{0} - {1}", e.GetType(), e.Message);
            Console.WriteLine();
        }

        // Change a value in the original array
        myArr[2] = "Ruby";

        // Display the values of the array
        Console.WriteLine("After changing the third element, the string array contains the following values:");
        PrintValues(myArr);

        // Display the values of the read-only collection
        Console.WriteLine("The read-only collection IList<string> contains: ");
        PrintValues(myList);
    }
}
