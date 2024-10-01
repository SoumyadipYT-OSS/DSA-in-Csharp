using System;

/*
    Namespace: System;
    Class: Array;

    Property Value: Boolean; Gets a value indicating whether the Array is read-only
    Remarks: IsReadOnly property comes from `System.Collections.IList` interface.
*/

class Properties_IsReadOnly {
    static void Main(string[] args) {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine(arr.IsReadOnly);
    }
}

// This property is always false for all arrays.