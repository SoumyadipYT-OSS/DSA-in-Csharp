using System;

class SampleArray {
    static void Main() {
        // Example 1
        Console.WriteLine("Example 1");
        string[] myArr1 = new string[5];
        myArr1.SetValue("three", 3);
        Console.WriteLine("[3]: \t{0}", myArr1.GetValue(3));

        // Example 2
        Console.WriteLine("\nExample 2");
        string[,] myArr2 = new string[5, 5];
        myArr2.SetValue("one-three", 1, 3);
        Console.WriteLine("[1,3]: \t{0}", myArr2.GetValue(1, 3));

        // Example 3
        Console.WriteLine("\nExample 3");
        string[,,] myArr3 = new string[5, 5, 5];
        myArr3.SetValue("one-two-three", 1, 2, 3);
        Console.WriteLine("[1,2,3]: \t{0}", myArr3.GetValue(1, 2, 3));

        // Example 4
        Console.WriteLine("\nExample 4");
        string[,,,,,,] myArr7 = new string[5, 5, 5, 5, 5, 5, 5];
        int[] myIndices = new int[] { 1, 2, 3, 0, 1, 2, 3 };
        myArr7.SetValue("one-two-three-zero-one-two-three", myIndices);
        Console.WriteLine("[1,2,3,0,1,2,3]: \t{0}", myArr7.GetValue(myIndices));
    }
}