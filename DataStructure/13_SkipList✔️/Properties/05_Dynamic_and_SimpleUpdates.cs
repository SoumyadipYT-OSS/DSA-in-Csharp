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

    public bool Search(T value) {
        SkipListNode<T> current = header;
        for (int i = level; i >= 0; i--) {
            while (current.Forward[i] != null && current.Forward[i].Value.CompareTo(value) < 0) {
                current = current.Forward[i];
            }
        }
        current = current.Forward[0];
        return current != null && current.Value.CompareTo(value) == 0;
    }

    public bool Delete(T value) {
        SkipListNode<T>[] update = new SkipListNode<T>[maxLevel + 1];
        SkipListNode<T> current = header;
        for (int i = level; i >= 0; i--) {
            while (current.Forward[i] != null && current.Forward[i].Value.CompareTo(value) < 0) {
                current = current.Forward[i];
            }
            update[i] = current;
        }
        current = current.Forward[0];
        if (current != null && current.Value.CompareTo(value) == 0) {
            for (int i = 0; i <= level; i++) {
                if (update[i].Forward[i] != current)
                    break;
                update[i].Forward[i] = current.Forward[i];
            }
            while (level > 0 && header.Forward[level] == null) {
                level--;
            }
            return true;
        }
        return false;
    }

    // Display the structure of the Skip List (by levels)
    public void Display() {
        Console.WriteLine("Skip List Structure:");
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
        SkipList<int> skipList = new SkipList<int>(4);

        int[] elements = { 5, 10, 15, 20, 25, 30 };
        Console.WriteLine("Inserting elements: " + string.Join(", ", elements));
        foreach (int value in elements) {
            skipList.Insert(value);
        }

        Console.WriteLine("\nSkip List after insertions:");
        skipList.Display();

        int[] toDelete = { 10, 20 };
        Console.WriteLine("\nDeleting elements: " + string.Join(", ", toDelete));
        foreach (int value in toDelete) {
            skipList.Delete(value);
        }

        Console.WriteLine("\nSkip List after deletions:");
        skipList.Display();

        Console.WriteLine("\nDynamic and Simple Updates Demo Completed.");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
