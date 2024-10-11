using System;

/*
    Namespace: System;
    Class: Array;
    
    Property Value: Boolean; Gets a value indicating whether the Array has a fixed size.
    Remarks: IsFixedSize property comes from `System.Collections.IList` interface.
*/

class Properties_IsFixedSize {
    static void Main(string[] args) {
        int[] arr1 = new int[5];
        Console.WriteLine(arr1.IsFixedSize);
    }
}

// This property is always true for all arrays.