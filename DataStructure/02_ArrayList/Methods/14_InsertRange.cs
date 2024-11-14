using System;
using System.Collections;

class Program {
    static void Main() {
        // Create a new ArrayList
        ArrayList myList = new ArrayList();

        // Add some initial elements to the ArrayList
        myList.Add(1);
        myList.Add(2);
        myList.Add(5);

        // Create another collection to insert
        ArrayList newElements = new ArrayList { 3, 4 };

        // Insert the new elements at index 2
        myList.InsertRange(2, newElements);

        // Display the ArrayList after insertion
        Console.WriteLine("ArrayList after InsertRange:");
        foreach (var item in myList) {
            Console.WriteLine(item);
        }
    }
}