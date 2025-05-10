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

    // Display each level of the skip list.
    public void Display() {
        Console.WriteLine("Multi-Level Structure Demo:");
        for (int i = 0; i <= level; i++) {
            SkipListNode<T> current = header.Forward[i];
            Console.Write("Level {0}: ", i);
            while (current != null) {
                Console.Write(current.Value + " ");
                current = current.Forward[i];
            }
            Console.WriteLine();
        }
    }
}


public class Program {
    public static void Main() {
        // Create a Skip List with a maximum level of 4.
        SkipList<int> skipList = new SkipList<int>(4);

        // Insert some sample elements.
        int[] elements = { 3, 6, 7, 9, 12, 19, 17 };
        foreach (int value in elements) {
            skipList.Insert(value);
        }

        // Display all levels of the skip list.
        skipList.Display();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
