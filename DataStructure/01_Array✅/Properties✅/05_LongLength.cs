using System;

/*
    Namespace: System;
    Class: Array;

    Property Value: Int64; Gets the total number of elements in all the dimensions of the Array.
    Remarks: LongLength property comes from `System.Array` class.
*/

class Properties_LongLength {
    static void Main(string[] args) {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine(arr.LongLength);

        // LongLength property on a jagged array
        int[][] jaggedArr = new int[2][];
        jaggedArr[0] = new int[2];
        jaggedArr[1] = new int[3];
        Console.WriteLine(jaggedArr.LongLength);
    }
}

// The LongLength property returns the total number of elements in all the dimensions of the Array.