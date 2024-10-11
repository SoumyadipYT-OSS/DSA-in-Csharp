using System;
using System.Drawing;

public class Example {
    public static void Example1() {
        // Create an array of five Point structures.
        Point[] points = { new Point(100, 200),
            new Point(150, 250), new Point(250, 375),
            new Point(275, 395), new Point(295, 450) };

        // Find the first Point structure for which X times Y
        // is greater than 100000.
        Point first = Array.Find(points, ProductGT10);

        // Display the first structure found.
        Console.WriteLine("First structure found: X = {0}, Y = {1}", first.X, first.Y);
    }

    // Return true if X times Y is greater than 100000.
    private static bool ProductGT10(Point p) {
        return p.X * p.Y > 100000;
    }


    public static void Example2() {
        Point[] _points_ = { new Point(100, 200),
            new Point(150, 250), new Point(250, 375),
            new Point(275, 395), new Point(295, 450) };

        // Find the first Point structure for which X times Y
        // is greater than 100000. Avoid the first point and access the next
        Point first = Array.Find(_points_, p => p.X * p.Y > 100000);

        // Display the second structure found.
        Console.WriteLine("First structure found: X = {0}, Y = {1}", first.X, first.Y);
    }


    // Main method
    static int Main(string[] args) {
        Console.WriteLine("---Example 1----");
        Example1();
        Console.WriteLine("---Example 2----");
        Example2();

        return 0;
    }
}
// The example displays the following output: X = 275, Y = 395;
// The Example2 displays the following output: X = 295, Y = 450;