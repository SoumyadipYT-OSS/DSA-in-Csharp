/*
 
    Method: Contains
    ArrayList.Contains method, which checks whether a 
    specific object is present in the ArrayList.

*/


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
        myList.Add("Hello");
        myList.Add("World");

        // Check if the ArrayList contains specific elements
        bool contains10 = myList.Contains(10);
        bool contains40 = myList.Contains(40);
        bool containsHello = myList.Contains("Hello");
        bool containsUniverse = myList.Contains("Universe");

        // Display the results
        Console.WriteLine("ArrayList contains 10: " + contains10);
        Console.WriteLine("ArrayList contains 40: " + contains40);
        Console.WriteLine("ArrayList contains 'Hello': " + containsHello);
        Console.WriteLine("ArrayList contains 'Universe': " + containsUniverse);
    }
}
