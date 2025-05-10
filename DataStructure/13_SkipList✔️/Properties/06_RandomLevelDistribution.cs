using System;


public class RandomLevelDistributionDemo {
    // The probability factor and maximum level should match your skip list settings.
    private const double P = 0.5;
    private const int maxLevel = 16;
    private static Random rand = new Random();

    // Simulate the RandomLevel method from the SkipList.
    public static int GenerateRandomLevel() {
        int lvl = 0;
        while (rand.NextDouble() < P && lvl < maxLevel) {
            lvl++;
        }
        return lvl;
    }

    // Main method
    public static void Main() {
        int trials = 10000;
        // Array to count frequency of each level.
        int[] frequency = new int[maxLevel + 1];

        for (int i = 0; i < trials; i++) {
            int lvl = GenerateRandomLevel();
            frequency[lvl]++;
        }

        Console.WriteLine("Random Level Distribution Demo (after {0} trials):", trials);
        for (int i = 0; i <= maxLevel; i++) {
            double percentage = (frequency[i] / (double)trials) * 100;
            Console.WriteLine("Level {0}: {1} times ({2:F2}%)", i, frequency[i], percentage);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
