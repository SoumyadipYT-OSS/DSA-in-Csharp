using System;
using System.Collections;

class Program {
    static void Main() {
        // Create a standard array
        int[] myArray = { 1, 2, 3, 4, 5 };

        // Create an ArrayList wrapper around the array
        ArrayList myArrayList = ArrayList.Adapter(myArray);

        // Display elements of the ArrayList
        Console.WriteLine("Elements in the ArrayList:");
        foreach (var item in myArrayList) {
            Console.WriteLine(item);
        }

        // Modify an element in the ArrayList
        myArrayList[2] = 10;
        Console.WriteLine("\nAfter modifying, elements in the ArrayList:");
        foreach (var item in myArrayList) {
            Console.WriteLine(item);
        }

        // Show that changes to the ArrayList affect the original array
        Console.WriteLine("\nElements in the original array:");
        foreach (var item in myArray) {
            Console.WriteLine(item);
        }
    }
}
