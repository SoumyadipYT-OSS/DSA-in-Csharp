/*

    Method. ArrayList.Synchronized
    This method returns a synchronized (thread-safe) wrapper for the ArrayList.
    This is useful when multiple threads need to access and modify the
    ArrayList concurrently.

*/


using System;
using System.Collections;
using System.Threading;

class Program {
    static void Main() {
        // Create a new ArrayList
        ArrayList myList = new ArrayList();

        // Add some elements to the ArrayList
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);

        // Create a synchronized wrapper around the ArrayList
        ArrayList syncList = ArrayList.Synchronized(myList);

        // Create and start two threads that will access the ArrayList concurrently
        Thread thread1 = new Thread(() => AccessArrayList(syncList, "Thread 1"));
        Thread thread2 = new Thread(() => AccessArrayList(syncList, "Thread 2"));

        thread1.Start();
        thread2.Start();

        // Wait for both threads to complete
        thread1.Join();
        thread2.Join();
    }

    static void AccessArrayList(ArrayList list, string threadName) {
        lock (list.SyncRoot) {
            // Accessing the ArrayList within a lock to ensure thread safety
            Console.WriteLine($"{threadName} accessing the ArrayList:");
            foreach (var item in list) {
                Console.WriteLine($"{threadName} - Item: {item}");
                Thread.Sleep(100); // Simulating some work
            }
        }
    }
}