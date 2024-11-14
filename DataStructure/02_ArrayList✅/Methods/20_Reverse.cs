using System;
using System.Collections;

class Program {
    static void Main() {
        // Create a new ArrayList
        ArrayList myList = new ArrayList();

        // Add some elements to the ArrayList
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(4);
        myList.Add(5);

        // Display the initial ArrayList
        Console.WriteLine("Initial ArrayList:");
        foreach (var item in myList) {
            Console.Write(item + " ");
        }

        // Reverse the ArrayList
        myList.Reverse();

        // Display the ArrayList after reversing
        Console.WriteLine("\nArrayList after reversing:");
        foreach (var item in myList) {
            Console.Write(item + " ");
        }
    }
}
