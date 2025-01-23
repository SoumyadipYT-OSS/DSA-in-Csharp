using System;
using System.Collections;


public class Example {
    public static void Main() {
        // Create a new Hashtable
        Hashtable hashtable = new Hashtable();

        // Add some elements to the Hashtable
        hashtable.Add("apple", 1);
        hashtable.Add("banana", 2);
        hashtable.Add("cherry", 3);

        // Display the values in the Hashtable using the Values property
        Console.WriteLine("Values in the Hashtable:");
        foreach (var value in hashtable.Values) {
            Console.WriteLine(value);
        }

        // Add another element
        hashtable.Add("date", 4);

        // Display the updated values in the Hashtable
        Console.WriteLine("Updated values in the Hashtable:");
        foreach (var value in hashtable.Values) {
            Console.WriteLine(value);
        }
    }
}