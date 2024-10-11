using System;

/*
    Namespace: System;
    Class: Array;

    Property Value: Int32; Gets the rank (number of dimensions) of the Array.
    Remarks: Rank property comes from `System.Array` class.
*/

class Properties_Rank {
    static void Main(string[] args) {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine(arr.Rank);    // Output: 1 because it is a single-dimensional array

        // Rank property on a jagged array
        int[][] jaggedArr = new int[2][];
        jaggedArr[0] = new int[2];
        jaggedArr[1] = new int[3];
        Console.WriteLine(jaggedArr.Rank);  // Output: 1 because it is a single-dimensional array

        // Rank property on a multi-dimensional array
        int[,] multiDimArr = new int[2, 3];
        Console.WriteLine(multiDimArr.Rank);    // Output: 2 because it is a two-dimensional array

        // Rank property on a three-dimensional array
        int[,,] threeDimArr = new int[2, 3, 4];
        Console.WriteLine(threeDimArr.Rank);    // Output: 3 because it is a three-dimensional array
    }
}

// The Rank property returns the rank (number of dimensions) of the Array.