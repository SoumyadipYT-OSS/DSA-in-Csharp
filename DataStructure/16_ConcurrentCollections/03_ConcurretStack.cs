using System;
using System.Collections.Concurrent;


public class Program {
    public static void Main() {
        // Create a ConcurrentStack of strings.
        ConcurrentStack<string> stack = new ConcurrentStack<string>();

        // Push items onto the stack.
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");

        // Peek the top element.
        string top;
        if (stack.TryPeek(out top))
            Console.WriteLine("Top of stack: " + top);

        // Pop items off the stack.
        Console.WriteLine("Popping items:");
        string item;
        while (stack.TryPop(out item)) {
            Console.WriteLine("Popped: " + item);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
