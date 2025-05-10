using System;
using System.Collections.Concurrent;

public class Program {
    public static void Main() {
        // Create a ConcurrentQueue of integers.
        ConcurrentQueue<int> queue = new ConcurrentQueue<int>();

        // Enqueue items.
        queue.Enqueue(100);
        queue.Enqueue(200);
        queue.Enqueue(300);


        // Peek at the front element.
        int result;
        if (queue.TryPeek(out result))
            Console.WriteLine("Peek: " + result);

        // Dequeue items.
        Console.WriteLine("Dequeueing items:");
        while (queue.TryDequeue(out result)) {
            Console.WriteLine("Dequeued: " + result);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
