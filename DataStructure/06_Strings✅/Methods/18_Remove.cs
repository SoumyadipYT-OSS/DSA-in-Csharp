using System;

/*  Remove: Returns a new string in which a specified number of characters from the current string are deleted. */

class Program {
    static void Main() {
        string s = "abc---def";

        Console.WriteLine("Index: 012345678");
        Console.WriteLine("1) \t {0}", s);
        Console.WriteLine("2) \t {0}", s.Remove(3));
        Console.WriteLine("3) \t {0}", s.Remove(3, 3));
    }
}