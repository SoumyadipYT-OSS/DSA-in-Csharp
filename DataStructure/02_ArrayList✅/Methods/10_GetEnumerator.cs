/*
    Method: GetEnumerator
    Returns an enumerator that iterates through the ArrayList.      
*/


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

        // Get an enumerator for the ArrayList
        IEnumerator enumerator = myList.GetEnumerator();

        // Use the enumerator to iterate through the ArrayList
        Console.WriteLine("Elements in the ArrayList:");
        while (enumerator.MoveNext()) {
            Console.WriteLine(enumerator.Current);
        }
    }
}