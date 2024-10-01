using System;

/*
    Namespace: System;
    Class: Array;

    Property Value: Boolean;  Gets a value indicating whether access to the Array is synchronized (thread safe).
    Remarks: IsSynchronized property comes from `System.Collections.ICollection` interface.
*/

class Properties_IsSynchronized {
    public void SyncRootProperty() {
        int[] arr = { 3, 4 };
        lock (arr.SyncRoot) {
            Console.WriteLine("Locked");
            for (int obj = 0; obj < arr.Length; obj++) {
                Console.Write(arr[obj] + " ");
            }
        }
        Console.WriteLine("\nUnlocked");
    }

    // main method
    static void Main(string[] args) {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Example 1:\n" + arr.IsSynchronized + "\n\nExample 2:");

        Properties_IsSynchronized p1 = new Properties_IsSynchronized();
        p1.SyncRootProperty();
    }
}

// The IsSynchronized property is always false for all arrays.
// The SyncRoot property is used to perform thread-safe operations on the array.

/*
    When it is used?
    - When you want to perform thread-safe operations on the array.
    - When you want to lock the array to perform thread-safe operations.
    - When you want to check whether the array is synchronized or not.

    When we need thread-safe operations?
    - When multiple threads are accessing the same array.
    - When multiple threads are modifying the same array.
    - When multiple threads are reading the same array.
    - When multiple threads are writing the same array.

    What is the advantage of thread-safe operations?
    - It prevents data corruption.
    - It prevents data loss.
    - It prevents data inconsistency.
*/