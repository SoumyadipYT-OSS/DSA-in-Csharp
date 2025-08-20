using System;
using System.Collections;



class SampleProgram {
    static void Main() {
        // Creates and initializes a new Queue.
        Queue myQ = new Queue();
        myQ.Enqueue("The");
        myQ.Enqueue("TATA");
        myQ.Enqueue("Harrier");
        myQ.Enqueue("SUV");

        // Displays the Queue. [Enqueue]
        Console.Write("Queue values: ");
        PrintValues(myQ);

        // Removes an element from the Queue. [Dequeue]
        Console.WriteLine("(Dequeue)\t{0}", myQ.Dequeue());

        // Displays the Queue.
        Console.Write("Queue values:");
        PrintValues(myQ);

        // Views the first element in the Queue but does not remove it.
        Console.WriteLine("(Peek)  \t{0}", myQ.Peek());

        // Displays the Queue
        Console.Write("Queue values: ");
        PrintValues(myQ);

        // Contains method
        Console.WriteLine("Does it Contain word \"SUV\"? " + myQ.Contains("SUV"));


        // ToArray Method
        object[] objArr = myQ.ToArray();
        Console.WriteLine("Queue as array: \t" + string.Join(", ", objArr));
    }


    private static void PrintValues(IEnumerable myCollection) {
        foreach (object obj in myCollection)
            Console.Write(" \t {0}", obj);
        Console.WriteLine();
    }
}