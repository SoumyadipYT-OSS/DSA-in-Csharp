using System;

/*  ToCharArray: Converts the string to a character array.  */

class Program {
    static void Main() {
        string str = "azure";
        char[] chars = str.ToCharArray();   // ['a', 'z', 'u', 'r', 'e']
        Console.WriteLine(chars);

        foreach (char c in chars)
            Console.Write(c + ", ");
    }
}