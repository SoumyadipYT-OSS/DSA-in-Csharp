using System;

class Program {
    // method for CopyTo(Array, Int32)
    protected static void CopyToInt32() {
        int[] sourceArray = { 1, 2, 3, 4, 5 };
        int[] targetArray = new int[10];

        Console.WriteLine("Before CopyTo (Int32): ");
        foreach (var num in targetArray) Console.Write(num + " ");
        Console.WriteLine();

        sourceArray.CopyTo(targetArray, 3);

        Console.WriteLine("After CopyTo (Int32): ");

        foreach (var num in targetArray) Console.Write(num + " ");
        Console.WriteLine();
    }

    // method for CopyTo(Array, Int64)
    protected static void CopyToInt64() {
        int[] sourceArray = { 1, 2, 3, 4, 5 };
        int[] targetArray = new int[10];
        Console.WriteLine("Before CopyTo (Int64):");
        foreach (var num in targetArray) Console.Write(num + " ");
        Console.WriteLine();
        // Copying elements from sourceArray to targetArray starting at index 3 (Int64)
        sourceArray.CopyTo(targetArray, 3L);

        Console.WriteLine("After CopyTo (Int64):");
        foreach (var num in targetArray) Console.Write(num + " ");
        Console.WriteLine();
    }


    // Main method
    static void Main() {
        Console.WriteLine("---- CopyTo(Int32)----");
        CopyToInt32();
        Console.WriteLine("---- CopyTo(Int64)----");
        CopyToInt64();
    }
}