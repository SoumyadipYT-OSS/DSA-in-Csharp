using System;

/*
    Namespace: System;
    Class: Array;

    Property Value: Int32; Gets the total number of elements in all the dimensions of the Array.
    Remarks: Length property comes from `System.Array` class.
*/

class Properties_ArrayLength {
    static void Main(string[] args) {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine(arr.Length);
    }
}

// The Length property returns the total number of elements in all the dimensions of the Array.