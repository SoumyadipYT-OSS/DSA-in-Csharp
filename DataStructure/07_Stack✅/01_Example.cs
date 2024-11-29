using System;
using System.Collections;

/* System.Collections (Built-In Stack)  */


class SampleStack {
    static void Main() {
        // Creates and initialized a new Stack.
        Stack s1 = new Stack();
        s1.Push("One");
        s1.Push("Two");
        s1.Push("Three");

        // Displays the properties and values of the Stack.
        Console.WriteLine(" >> myStack");
        Console.WriteLine("\t Count:  \t {0}", s1.Count);
        Console.WriteLine("\t Values: ");
        PrintValues(s1);
    }


    private static void PrintValues(IEnumerable myCollection) {
        foreach (object i in myCollection)
            Console.Write(" \t {0}", i);
        Console.WriteLine();
    }
}