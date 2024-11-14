/*
    
    Method: ArrayList.Clone
    This built-in method is used for shallow copy of the ArrayList.
 
*/

using System;
using System.Collections;

class Program {
    static void Main() {
        // Create a new ArrayList
        ArrayList originalList = new ArrayList();

        // Add some elements to the ArrayList
        originalList.Add(1);
        originalList.Add(2);
        originalList.Add(3);

        // Display elements of the original ArrayList
        Console.WriteLine("Original ArrayList:");
        foreach (var item in originalList) {
            Console.WriteLine(item);
        }

        // Clone the ArrayList
        ArrayList clonedList = (ArrayList)originalList.Clone();

        // Display elements of the cloned ArrayList
        Console.WriteLine("\nCloned ArrayList:");
        foreach (var item in clonedList) {
            Console.WriteLine(item);
        }

        // Modify the cloned ArrayList
        clonedList[0] = 10;
        Console.WriteLine("\nAfter modifying cloned ArrayList:");
        foreach (var item in clonedList) {
            Console.WriteLine(item);
        }

        // Display elements of the original ArrayList to show it remains unchanged
        Console.WriteLine("\nOriginal ArrayList remains unchanged:");
        foreach (var item in originalList) {
            Console.WriteLine(item);
        }
    }
}
