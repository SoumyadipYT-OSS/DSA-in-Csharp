// BlockingCollection (Producer-Consumer)

using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

public class Program {
    public static void Main() {
        // Create a BlockingCollection (default underlying storage is a ConcurrentQueue).
        BlockingCollection<int> blockingCollection = new BlockingCollection<int>();

        // Producer Task: Adds items to the collection.
        Task producer = Task.Run(() => {
            for (int i = 1; i <= 5; i++) {
                blockingCollection.Add(i);
                Console.WriteLine("Produced: " + i);
                Thread.Sleep(500);
            }
            // Signal that no more items will be added.
            blockingCollection.CompleteAdding();
        });

        // Consumer Task: Takes items from the collection.
        Task consumer = Task.Run(() => {
            // GetConsumingEnumerable blocks until CompleteAdding is called and the collection is empty.
            foreach (int item in blockingCollection.GetConsumingEnumerable()) {
                Console.WriteLine("Consumed: " + item);
                Thread.Sleep(1000);
            }
        });

        Task.WaitAll(producer, consumer);
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
