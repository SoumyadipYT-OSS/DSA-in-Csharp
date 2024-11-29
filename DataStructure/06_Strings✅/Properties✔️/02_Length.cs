/*

    String.Length Property
    
    Gets the number of characters in the current `String` object.
 
*/
using System;


class Program {
    static void Main() {
        string str = "abcdefg";
        Console.WriteLine("1) The length of '{0}' is {1}", str, str.Length);
        Console.WriteLine("2) The length of '{0}' is {1}", "xyz", "xyz".Length);

        int length = str.Length;
        Console.WriteLine("3) The length of '{0}' is {1}", str, length);
    }
}