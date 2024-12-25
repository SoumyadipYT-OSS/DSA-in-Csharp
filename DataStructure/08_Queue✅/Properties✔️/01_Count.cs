using System;
using System.Collections;

class Propety_Count {
    static void Main() {
        Queue q = new Queue();

        q.Enqueue("First");
        q.Enqueue("Second");
        q.Enqueue("Third");

        Console.WriteLine("Number of elements in the queue: " + q.Count);

        q.Dequeue();

        Console.WriteLine("Number of elements in the Queue after Dequeue: " + q.Count);
    }
}