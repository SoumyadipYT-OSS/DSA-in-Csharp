using System;
using System.Collections;
using System.Collections.Generic;

/*  EqualityComparer: Gets the IEqualityComparer to use for the Hashtable.  */

public class CustomEqualityComparer : IEqualityComparer {
    public new bool Equals(object x, object y) {
        return StringComparer.OrdinalIgnoreCase.Equals(x, y);
    }

    public int GetHashCode(object obj) {
        return StringComparer.OrdinalIgnoreCase.GetHashCode(obj);
    }
}

public class Example {
    public static void Main() {
        // Create a custom equality comparer
        IEqualityComparer customComparer = new CustomEqualityComparer();

        // Create a new Hashtable with the custom equality comparer
        Hashtable hashtable = new Hashtable(customComparer);

        // Add some elements to the Hashtable
        hashtable.Add("apple", 1);
        hashtable.Add("banana", 2);
        hashtable.Add("cherry", 3);

        // Display the number of elements in the Hashtable using the Count property
        Console.WriteLine("Number of elements in the Hashtable: " + hashtable.Count);

        // Check if the Hashtable contains a key using the custom equality comparer
        Console.WriteLine("Contains 'APPLE': " + hashtable.Contains("APPLE")); // True
        Console.WriteLine("Contains 'banana': " + hashtable.Contains("banana")); // True

        // Display the equality comparer used by the Hashtable
        Console.WriteLine("EqualityComparer: " + customComparer);
    }
}