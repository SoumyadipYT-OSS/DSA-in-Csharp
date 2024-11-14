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

        // Display the initial ArrayList
        Console.WriteLine("Initial ArrayList:");
        foreach (var item in myList) {
            Console.WriteLine(item);
        }

        // Remove the element at index 2
        myList.RemoveAt(2);

        // Display the ArrayList after removal
        Console.WriteLine("\nArrayList after removing the element at index 2:");
        foreach (var item in myList) {
            Console.WriteLine(item);
        }
    }
}