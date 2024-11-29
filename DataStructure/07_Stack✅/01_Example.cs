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

        // Peek at the top element
        Console.WriteLine("Top element: " + s1.Peek());

        // Pop elements from the stack
        Console.WriteLine("Popped element: " + s1.Pop());
        Console.WriteLine("Popped element: " + s1.Pop());

        // Updated value in the stack
        Console.WriteLine(" >> Updated myStack\n \t Values:");
        PrintValues(s1);

        // Check if the stack is empty
        Console.WriteLine("Is stack empty? " + CheckEmpty(s1));
    }


    private static void PrintValues(IEnumerable myCollection) {
        foreach (object i in myCollection)
            Console.Write(" \t {0}", i);
        Console.WriteLine();
    }

    private static bool CheckEmpty(Stack myStack) {
        return myStack.Count == 0;
    }
}