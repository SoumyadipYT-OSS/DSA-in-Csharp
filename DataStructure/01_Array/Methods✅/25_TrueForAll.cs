/*
    public static bool TrueForAll<T> (T[] array, Predicate<T> match);
*/

using System;

class Example {
    private static bool EndsWithANumber(string value) {
        int s;
        return int.TryParse(value.Substring(value.Length - 1), out s);
    }

    static void Main() {
        string[] values1 = { "Y2K", "A2000", "DC2A6", "MMXIV", "0C3" };
        string[] values2 = { "Y2", "A2000", "DC2A6", "MMXIV_0", "0C3" };

        if (Array.TrueForAll(values1, EndsWithANumber))
            Console.WriteLine("All elements end with an integer.");
        else
            Console.WriteLine("Not all elements end with an integer.");


        if (Array.TrueForAll(values2, EndsWithANumber))
            Console.WriteLine("All elements end with an integer.");
        else
            Console.WriteLine("Not all elements end with an integer.");
    }
}