using System;

/*  Insert: A new string that is equivalent to this instance, but with value inserted at position startIndex. */


class Program {
    static void Main() {
        string original = "aaabbb";
        Console.WriteLine($"The original string: {original}");
        string modified = original.Insert(3, " ");
        Console.WriteLine($"The modified string: {modified}");
    }
}