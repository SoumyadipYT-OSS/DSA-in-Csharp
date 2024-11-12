using System;

class Program {
    static void Main() {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Original Array:");
        foreach (int num in arr) {
            Console.Write(num + " ");
        }

        Array.Reverse(arr);

        Console.WriteLine("\nReversed Array:");
        foreach(int num in arr) {
            Console.Write(num + " ");
        }
    }
}