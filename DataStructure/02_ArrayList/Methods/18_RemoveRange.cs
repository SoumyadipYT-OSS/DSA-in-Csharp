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
        myList.Add(40);
        myList.Add(50);
        myList.Add(60);

        // Display the initial ArrayList
        Console.WriteLine("Initial ArrayList:");
        foreach (var item in myList) {
            Console.WriteLine(item);
        }

        // Remove a range of elements starting at index 2 (remove 3 elements)
        myList.RemoveRange(2, 3);

        // Display the ArrayList after removal
        Console.WriteLine("\nArrayList after removing the range of elements:");
        foreach (var item in myList) {
            Console.WriteLine(item);
        }
    }
}