using System;

/*  Replace: Replaces all occurrences of a specified substring with another substring.  */


class Program {
    static void Main() {
        string str = "fatman";
        string replaced = str.Replace("f", "B");
        Console.WriteLine(replaced);    // Batman


        string str2 = "cat";
        string replaced2 = str2.Replace("c", "R");
        replaced2 = replaced2.Replace("a", "A");
        replaced2 = replaced2.Replace("t", "T");
        Console.WriteLine(str2);
        Console.WriteLine(replaced2);   // RAT


        string str3 = "abc";
        string replaced3 = str3.Replace("b", " ");
        Console.WriteLine(str3);
        Console.WriteLine(replaced3);   // a c


        string str4 = "Deoo";
        string replaced4 = str4.Replace("o", "l");
        Console.WriteLine(str4);
        Console.WriteLine(replaced4);   // Dell
    }
}