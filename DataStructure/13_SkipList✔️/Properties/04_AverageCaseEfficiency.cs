using System;
using System.Diagnostics;

public class SkipListNode<T> where T : IComparable<T> {
    public T Value { get; set; }
    public SkipListNode<T>[] Forward { get; set; }

    public SkipListNode(int level, T value) {
        // Allocate an array of forward pointers for levels 0 to 'level'
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
}


public class Program {
    public static void Main() {
        const int maxLevel = 16;
        const int numElements = 100000;
        SkipList<int> skipList = new SkipList<int>(maxLevel);

        var stopwatch = Stopwatch.StartNew();
        for (int i = 0; i < numElements; i++) {
            skipList.Insert(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Insertion of {0} elements took: {1} ms", numElements, stopwatch.ElapsedMilliseconds);

        stopwatch.Restart();
        int foundCount = 0;
        for (int i = 0; i < numElements; i++) {
            if (skipList.Search(i))
                foundCount++;
        }
        stopwatch.Stop();
        Console.WriteLine("Searching {0} elements took: {1} ms", numElements, stopwatch.ElapsedMilliseconds);
        Console.WriteLine("Found {0} elements.", foundCount);

        stopwatch.Restart();
        int deleteCount = 0;
        for (int i = 0; i < numElements; i += 2) // Delete about half the elements
        {
            if (skipList.Delete(i))
                deleteCount++;
        }
        stopwatch.Stop();
        Console.WriteLine("Deletion of {0} elements took: {1} ms", numElements / 2, stopwatch.ElapsedMilliseconds);
        Console.WriteLine("Deleted {0} elements.", deleteCount);

        Console.WriteLine("\nAverage-Case Efficiency Demo Completed.");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
