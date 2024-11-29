using System;
using System.Collections;


class SampleProgram {
    static void Main() {
        // Creates and initialized a new Stack.
        Stack s1 = new Stack();
        s1.Push("The");
        s1.Push("Extraordinary");
        s1.Push("Powerful");
        s1.Push("SUV");

        // Displays the Stack.
        Console.Write("Stack values: ");
        PrintValues(s1, '\t');

        // Removes an element from the Stack.
        Console.WriteLine("(Pop)\t\t{0}", s1.Pop());

        // Displays the Stack
        Console.Write("Stack values: ");
        PrintValues(s1, '\t');

        // Check the top element of the stack
        Console.WriteLine("Top element: " + s1.Peek());

        // Check the elements contains or not
        Console.WriteLine("Contains \"Extraordinary\": " + s1.Contains("Extraordinary"));

        // ToArray method
        Console.WriteLine("ToArray: " + s1.ToArray());
        object[] strArr = s1.ToArray();
        Console.WriteLine("\nStack as array form: \t[ " + string.Join(", ", strArr) + " ]");
    }


    private static void PrintValues(IEnumerable myCollection, char mySeparator) {
        foreach (object obj in myCollection)
            Console.Write("{0}{1}", mySeparator, obj);
        Console.WriteLine();
    }

    // method overloading (if second parameter is not used)
    private static void PrintValues(IEnumerable myCollection) {
        foreach (object obj in myCollection)
            Console.Write("{0}, ", obj);
        Console.WriteLine();
    }
}