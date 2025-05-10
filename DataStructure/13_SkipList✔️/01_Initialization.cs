using System;

// Node class for the Skip List
public class SkipListNode<T> where T : IComparable<T> {
	public T Value { get; set; }
	public SkipListNode<T>[] Forward { get; set; }

	public SkipListNode(int level, T value) {
		// Allocate the forward pointer array for levels 0 through level.
		Forward = new SkipListNode<T>[level + 1];
		Value = value;
	}
}

// Skip List class
public class SkipList<T> where T : IComparable<T> {
	private const double P = 0.5;          // Probability factor for node level assignment
	private readonly int maxLevel;         // Maximum level allowed
	private int level;                     // Current highest level in the Skip List
	private readonly SkipListNode<T> header; // The header (dummy) node
	private readonly Random rand;          // Random number generator

	public SkipList(int maxLevel) {
		this.maxLevel = maxLevel;
		this.level = 0; // Initially no elements, so current level is 0
						// Create the header/dummy node. Its value is default(T) because it holds no meaningful data.
		this.header = new SkipListNode<T>(maxLevel, default(T));
		// Initialize the random generator (for later use when inserting nodes)
		this.rand = new Random();
	}

	// A simple method to display key information.
	// This uses 'level', so the warning CS0414 is eliminated.
	public void PrintInfo() {
		Console.WriteLine("SkipList created.");
		Console.WriteLine("Max Level: " + maxLevel);
		Console.WriteLine("Current Level: " + level);
	}
}


// Program entry point class
public class Program {
	public static void Main() {
		// Create an instance of SkipList for integers with a maximum level of 5.
		SkipList<int> skipList = new SkipList<int>(5);
		// Use the PrintInfo method to demonstrate the basic initialization.
		skipList.PrintInfo();

		// Keep the console window open (if needed)
		Console.WriteLine("\nPress any key to exit...");
		Console.ReadKey();
	}
}
