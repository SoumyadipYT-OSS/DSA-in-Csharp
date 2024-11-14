using System;
using System.Collections;

class Program {
    static void Main() {
        // Create a new ArrayList
        ArrayList myList = new ArrayList();

        // Add some elements to the ArrayList
        myList.Add(5);
        myList.Add(1);
        myList.Add(4);
        myList.Add(2);
        myList.Add(3);

        // Display the initial ArrayList
        Console.WriteLine("Initial ArrayList:");
        foreach (var item in myList) {
            Console.Write(item + " ");
        }

        // Sort the ArrayList
        myList.Sort();

        // Display the ArrayList after sorting
        Console.WriteLine("\nArrayList after sorting:");
        foreach (var item in myList) {
            Console.Write(item + " ");
        }
    }
}
