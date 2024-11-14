/*
    Property: ArrayList.SyncRoot
   ------------------------------
    The SyncRoot property is used to synchronize access to 
    the ArrayList, making it thread-safe when working with 
    multiple threads.
    
*/


using System;
using System.Collections;
using System.Threading;

class Program {
    static void Main() {
        // Create a new ArrayList
        ArrayList myList = new ArrayList();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);

        // Get the SyncRoot of the ArrayList
        object syncRoot = myList.SyncRoot;

        // Create and start two threads that will access the ArrayList concurrently
        Thread thread1 = new Thread(() => AccessArrayList(myList, syncRoot, "Thread 1"));
        Thread thread2 = new Thread(() => AccessArrayList(myList, syncRoot, "Thread 2"));

        thread1.Start();
        thread2.Start();

        // Wait for both threads to complete
        thread1.Join();
        thread2.Join();
    }

    static void AccessArrayList(ArrayList list, object syncRoot, string threadName) {
        lock (syncRoot) {
            // Accessing the ArrayList within a lock to ensure thread safety
            Console.WriteLine($"{threadName} accessing the ArrayList:");
            foreach (var item in list) {
                Console.WriteLine($"{threadName} - Item: {item}");
                Thread.Sleep(100); // Simulating some work
            }
        }
    }
}