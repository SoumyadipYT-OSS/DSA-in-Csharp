using System;

class Program {
    static void Main(string[] args) {
        int[] arr1;     // declaration without initialization
        int[] arr2 = new int[5];    // declaration with size
        int[] arr3 = new int[] { 1, 2, 3, 4, 5 };    // declaration with initialization

        /* Using Collection Expressions (New in C# 12) */
        int[] arr4 = [1, 2, 3, 4, 5];

        int[] arr5 = new int[5] { 1, 2, 3, 4, 5 };    // declaration with size and initialization
        // !Error: int[] arr6 = new int[6] { 1, 2, 3, 4, 5 };    // Error: Size of array initializer must match the size of array

        // Console.WriteLine("Array 1: " + arr1);    // Error: Use of unassigned local variable 'arr1'
        Console.WriteLine("Array 2: " + arr2);    // Output: Array 2: System.Int32[]
        Console.WriteLine("Array 3: " + arr3);    // Output: Array 3: System.Int32[]
        Console.WriteLine("Array 4: " + arr4);    // Output: Array 4: System.Int32[]
        Console.WriteLine("Array 5: " + arr5);    // Output: Array 5: System.Int32[]
    }
}
