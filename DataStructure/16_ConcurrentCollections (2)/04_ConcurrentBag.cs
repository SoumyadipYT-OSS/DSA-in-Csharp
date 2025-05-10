using System;
using System.Collections.Concurrent;


public class Program {
    public static void Main() {
        // Create a ConcurrentBag of doubles.
        ConcurrentBag<double> bag = new ConcurrentBag<double>();

        // Add items to the bag.
        bag.Add(3.14);
        bag.Add(2.718);
        bag.Add(1.618);

        // Enumerate through the bag (order is not guaranteed).
        Console.WriteLine("Items in ConcurrentBag:");
        foreach (double d in bag) {
            Console.WriteLine(d);
        }

        // Try to take an item from the bag.
        double result;
        if (bag.TryTake(out result))
            Console.WriteLine("Took item: " + result);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
