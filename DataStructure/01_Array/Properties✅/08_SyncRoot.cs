using System;
/*
    Namespace: System;
    Class: Array;

    Property Value: Object; Gets an object that can be used to synchronize access to the Array.
    Remarks: SyncRoot property comes from `System.Array` class.
*/

class Properties_SyncRoot {
    static void Main(string[] args) {
        int[] arr = { 1, 2, 3, 4, 5 };
        var syncRoot = arr.SyncRoot;
        Console.WriteLine(syncRoot);
    }
}

// The SyncRoot property returns an object that can be used to synchronize access to the Array.