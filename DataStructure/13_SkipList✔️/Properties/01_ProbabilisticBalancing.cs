using System;

public class SkipListNode<T> where T : IComparable<T> {
    public T Value { get; set; }
    public SkipListNode<T>[] Forward { get; set; }
    public int NodeLevel { get; private set; }

    public SkipListNode(int level, T value) {
        Forward = new SkipListNode<T>[level + 1];
        Value = value;
        NodeLevel = level; // store the level this node spans
    }
}

public class SkipList<T> where T : IComparable<T> {
    private const double P = 0.5;
    private readonly int maxLevel;
    private int level; // current highest level in the list
    private readonly SkipListNode<T> header;
    private readonly Random rand;

    public SkipList(int maxLevel) {
        this.maxLevel = maxLevel;
        this.level = 0;
        this.header = new SkipListNode<T>(maxLevel, default(T));
        this.rand = new Random();
    }

    // Generates a random level for a new node.
    private int RandomLevel() {
        int lvl = 0;
        while (rand.NextDouble() < P && lvl < maxLevel) {
            lvl++;
        }
        return lvl;
    }

    public void Insert(T value) {
        SkipListNode<T>[] update = new SkipListNode<T>[maxLevel + 1];
        SkipListNode<T> current = header;

        for (int i = level; i >= 0; i--) {
            while (current.Forward[i] != null && current.Forward[i].Value.CompareTo(value) < 0) {
                current = current.Forward[i];
            }
            update[i] = current;
        }
        current = current.Forward[0];

        // Only insert if the value isn't already present.
        if (current == null || current.Value.CompareTo(value) != 0) {
            int rLevel = RandomLevel();
            if (rLevel > level) {
                for (int i = level + 1; i <= rLevel; i++) {
                    update[i] = header;
                }
                level = rLevel;
            }
            SkipListNode<T> newNode = new SkipListNode<T>(rLevel, value);
            for (int i = 0; i <= rLevel; i++) {
                newNode.Forward[i] = update[i].Forward[i];
                update[i].Forward[i] = newNode;
            }
        }
    }

    // Returns the current maximum level in the skip list.
    public int GetCurrentMaxLevel() => level;
}

public class Program {
    public static void Main() {
        // Create a Skip List for integers with a maximum level of 16.
        SkipList<int> skipList = new SkipList<int>(16);

        // Insert many elements to test probabilistic balancing.
        int n = 1000;
        for (int i = 1; i <= n; i++) {
            skipList.Insert(i);
        }

        // Report the maximum level reached.
        Console.WriteLine("Probabilistic Balancing Demo:");
        Console.WriteLine("Inserted {0} elements.", n);
        Console.WriteLine("Maximum level reached in the skip list: {0}", skipList.GetCurrentMaxLevel());

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
