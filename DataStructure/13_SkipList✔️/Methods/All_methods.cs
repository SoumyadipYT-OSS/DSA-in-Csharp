using System;


// Node class for the Skip List.
public class SkipListNode<T> where T : IComparable<T> {
    public T Value { get; set; }
    public SkipListNode<T>[] Forward { get; set; }

    public SkipListNode(int level, T value) {
        // Create an array of pointers for levels 0 through 'level'.
        Forward = new SkipListNode<T>[level + 1];
        Value = value;
    }
}

// Skip List class.
public class SkipList<T> where T : IComparable<T> {
    private const double P = 0.5;          // Probability factor for node level assignment.
    private readonly int maxLevel;         // Maximum level allowed.
    private int level;                     // Current highest level in the Skip List.
    private readonly SkipListNode<T> header;  // Header (dummy) node.
    private readonly Random rand;          // Random number generator.

    public SkipList(int maxLevel) {
        this.maxLevel = maxLevel;
        this.level = 0; // Empty list initially; current level is 0.
        // Create the header (dummy) node with default(T) as its value.
        this.header = new SkipListNode<T>(maxLevel, default(T));
        // Initialize the random generator (used later in RandomLevel).
        this.rand = new Random();
    }


    // RandomLevel: Generates a random level for the new node.
    private int RandomLevel() {
        int lvl = 0;
        while (rand.NextDouble() < P && lvl < maxLevel) {
            lvl++;
        }
        return lvl;
    }

    // Insert: Adds an element to the Skip List.
    public void Insert(T value) {
        // Create an update array to hold pointers that will need to be updated.
        SkipListNode<T>[] update = new SkipListNode<T>[maxLevel + 1];
        SkipListNode<T> current = header;

        // Traverse from the highest level to level 0.
        for (int i = level; i >= 0; i--) {
            while (current.Forward[i] != null && current.Forward[i].Value.CompareTo(value) < 0) {
                current = current.Forward[i];
            }
            update[i] = current;
        }
        current = current.Forward[0];

        // Only insert if the value isn't already present.
        if (current == null || current.Value.CompareTo(value) != 0) {
            // Get a random level for the new node.
            int rLevel = RandomLevel();
            // If new node's level is greater than current level, update the update array.
            if (rLevel > level) {
                for (int i = level + 1; i <= rLevel; i++) {
                    update[i] = header;
                }
                level = rLevel;
            }
            // Create new node with the randomly determined level.
            SkipListNode<T> newNode = new SkipListNode<T>(rLevel, value);
            // Update forward pointers.
            for (int i = 0; i <= rLevel; i++) {
                newNode.Forward[i] = update[i].Forward[i];
                update[i].Forward[i] = newNode;
            }
        }
    }

    // Search: Checks if a value exists in the Skip List.
    public bool Search(T value) {
        SkipListNode<T> current = header;
        // Traverse the levels from top to bottom.
        for (int i = level; i >= 0; i--) {
            while (current.Forward[i] != null && current.Forward[i].Value.CompareTo(value) < 0) {
                current = current.Forward[i];
            }
        }
        current = current.Forward[0];
        return (current != null && current.Value.CompareTo(value) == 0);
    }

    // Delete: Removes a value from the Skip List.
    public bool Delete(T value) {
        SkipListNode<T>[] update = new SkipListNode<T>[maxLevel + 1];
        SkipListNode<T> current = header;

        // Find position for deletion.
        for (int i = level; i >= 0; i--) {
            while (current.Forward[i] != null && current.Forward[i].Value.CompareTo(value) < 0) {
                current = current.Forward[i];
            }
            update[i] = current;
        }
        current = current.Forward[0];

        // If found, remove the node.
        if (current != null && current.Value.CompareTo(value) == 0) {
            for (int i = 0; i <= level; i++) {
                if (update[i].Forward[i] != current)
                    break;
                update[i].Forward[i] = current.Forward[i];
            }
            // Adjust the current level of the skiplist if necessary.
            while (level > 0 && header.Forward[level] == null) {
                level--;
            }
            return true;
        }
        return false;
    }

    // Display: Prints out the Skip List's structure level by level.
    public void Display() {
        Console.WriteLine("Skip List:");
        for (int i = 0; i <= level; i++) {
            SkipListNode<T> current = header.Forward[i];
            Console.Write("Level " + i + ": ");
            while (current != null) {
                Console.Write(current.Value + " ");
                current = current.Forward[i];
            }
            Console.WriteLine();
        }
    }
}



// Example usage in a Program class with Main() as the entry point.
public class Program {
    public static void Main() {
        // Create a Skip List for integers with a maximum level of 5.
        SkipList<int> skipList = new SkipList<int>(5);

        // Insert some elements.
        skipList.Insert(3);
        skipList.Insert(6);
        skipList.Insert(7);
        skipList.Insert(9);
        skipList.Insert(12);
        skipList.Insert(19);

        Console.WriteLine("After insertions:");
        skipList.Display();

        // Perform some searches.
        Console.WriteLine("Searching for 7: " + (skipList.Search(7) ? "Found" : "Not Found"));
        Console.WriteLine("Searching for 15: " + (skipList.Search(15) ? "Found" : "Not Found"));

        // Delete an element.
        Console.WriteLine("Deleting 9: " + (skipList.Delete(9) ? "Deleted" : "Not Found"));
        Console.WriteLine("After deletion:");
        skipList.Display();

        // Keep console open.
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
