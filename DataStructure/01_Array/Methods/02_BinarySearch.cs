using System;
using System.Collections.Generic;

class BinarySearchMethods {
    protected static void BinarySearchExample1() {
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13 };
        Arrary.Sort(numbers);

        int valueToFind = 7;

        // BinarySearch(Array, Object)
        int index = Array.BinarySearch(numbers, valueToFind);

        if (index >= 0) Console.WriteLine($"Value {valueToFind} found at index {index}.");
        else Console.WriteLine($"Value {valueToFind} not found. Nearest index: {~index}.");

    }
}