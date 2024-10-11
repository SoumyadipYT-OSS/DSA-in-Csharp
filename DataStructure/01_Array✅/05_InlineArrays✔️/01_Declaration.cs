using System;

/*
    ---- New feature of C# 12 ----
    Inline Arrays:
    - An array can be declared and initialized in a single statement.
    - This is called an inline array. 
 */

class InlineArrays {
    static void Main(string[] args) {
        // Inline array declaration
        int[] numbers = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Inline Array:");
        foreach (var number in numbers) {
            Console.Write(number + " ");
        }

        // Inline array declaration with type inference
        var names = new string[] { "John", "Doe", "Jane", "Doe" };
        Console.WriteLine("\nInline Array with type inference:");
        foreach (var name in names) {
            Console.Write(name + " ");
        }
    }
}