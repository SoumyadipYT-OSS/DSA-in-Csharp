using System;

public class SkipListNode<T> where T : IComparable<T> {
    public T Value { get; set; }
    public SkipListNode<T>[] Forward { get; set; }

    public SkipListNode(int level, T value) {
        Forward = new SkipListNode<T>[level + 1];
        Value = value;
    }
}


public class SkipList<T> where T : IComparable<T> {
    private const double P = 0.5;
    private readonly int maxLevel;
    private int level;
    private readonly SkipListNode<T> header;
    private readonly Random rand;

    public SkipList(int maxLevel) {
        this.maxLevel = maxLevel;
        this.level = 0;
        this.header = new SkipListNode<T>(maxLevel, default(T));
        this.rand = new Random();
    }

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

    // Calculate memory overhead by traversing the bottom-level list (Level 0)
    public (int totalNodes, int totalPointers, double averagePerNode) CalculateMemoryOverhead() {
        int totalNodes = 0;
        int totalPointers = 0;
        SkipListNode<T> current = header.Forward[0];
        while (current != null) {
            totalNodes++;
            // Each node's overhead is its forward pointer array length.
            totalPointers += current.Forward.Length;
            current = current.Forward[0];
        }
        double averagePerNode = totalNodes > 0 ? (double)totalPointers / totalNodes : 0;
        return (totalNodes, totalPointers, averagePerNode);
    }
}


public class Program {
    public static void Main() {
        SkipList<int> skipList = new SkipList<int>(8);

        for (int i = 1; i <= 50; i++) {
            skipList.Insert(i);
        }

        var (totalNodes, totalPointers, averagePerNode) = skipList.CalculateMemoryOverhead();

        Console.WriteLine("Memory Overhead Demo:");
        Console.WriteLine("Total nodes (at level 0): {0}", totalNodes);
        Console.WriteLine("Total forward pointers allocated: {0}", totalPointers);
        Console.WriteLine("Average forward pointers per node: {0:F2}", averagePerNode);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
