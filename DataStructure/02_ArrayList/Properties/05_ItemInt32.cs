using System;
using System.Collections;

class Program {
    static void Main() {
        // Create a new ArrayList
        ArrayList myList = new ArrayList();

        // Add some elements to the ArrayList
        myList.Add(10);
        myList.Add(20);
        myList.Add(30);

        // Access elements using the Item[Int32] property (indexer)
        Console.WriteLine("Element at index 0: " + myList[0]);
        Console.WriteLine("Element at index 1: " + myList[1]);
        Console.WriteLine("Element at index 2: " + myList[2]);

        // Modify elements using the Item[Int32] property (indexer)
        myList[1] = 25;
        Console.WriteLine("After modification, element at index 1: " + myList[1]);

        // Display all elements in the ArrayList
        Console.WriteLine("All elements in the ArrayList:");
        foreach (var item in myList) {
            Console.WriteLine(item);
        }
    }
}
