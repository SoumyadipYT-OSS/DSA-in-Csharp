using System;
using System.Collections;

/* Queue Data Structure using Built-In methods */

class SampleProgram {
    static void Main() {
        // Creates and initializes a new Queue.
        Queue myQ = new Queue();
        myQ.Enqueue("Hey");
        myQ.Enqueue("Learner");
        myQ.Enqueue("!");

        // Displays the properties and values of the Queue.
        Console.WriteLine(" >> myQ");
        Console.WriteLine("\tCount: {0}", myQ.Count);
        Console.WriteLine("\tValues: ");
        PrintValues(myQ);
    }

    private static void PrintValues(IEnumerable myCollection) {
        foreach (object obj in myCollection)
            Console.Write("\t {0}", obj);
        Console.WriteLine();
    }
}