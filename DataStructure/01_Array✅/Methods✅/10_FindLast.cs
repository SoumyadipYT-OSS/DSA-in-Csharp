/*
        Array.FindLast<T>(T[], Predicate<T>) Method

        public static T? FindLast<T> (T[] array, Predicate<T> match);
 */

using System;

class Example {
    static void Main() {
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13, 15 };

        // Define a predicate to find the last odd number greater than 10
        Predicate<int> predicate = n => n > 10;

        // Use Array.FindLast to find the last element matching the predicate
        int lastNum = Array.FindLast(numbers, predicate);

        if (lastNum != 0) Console.WriteLine($"The last number > 10 is: {lastNum}");
        else Console.WriteLine("No number > 10 found");
    }
}