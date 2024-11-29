using System;

/* CompareTo: Compares the current string with another string.  */

class Program {
    static void Main() {
        Console.WriteLine("1. Comparing Two Different Strings");
        string str1 = "apple";
        string str2 = "banana";
        int res = str1.CompareTo(str2);     // -1; (str1 is less than str2)
        Console.WriteLine(res);

        Console.WriteLine("2. Comparing Two Identical Strings");
        string str3 = "apple";
        string str4 = "apple";  // 0; (Since two strings are identical, indicating that the strings are equal.
        int res2 = str3.CompareTo(str4);
        Console.WriteLine(res2);

        Console.WriteLine("3. Comparing Strings with Different Cases");
        string str5 = "Apple";
        string str6 = "apple";
        int res3 = str5.CompareTo(str6);
        Console.WriteLine(res3);    // -1; (By default `CompareTo()` is case-sensitive. Since "Apple" precedes "apple" in the sort order.

        Console.WriteLine("4. Comparing Strings with Different Lengths");
        string str7 = "apple";
        string str8 = "apples";
        int res4 = str7.CompareTo(str8);
        Console.WriteLine(res4);    // -1; (Since "apple" is shorter than "apples" and precedes it in the sort order

        Console.WriteLine("5. Comparing Strings with Different Lengths");
        string str9 = "capcicum";
        string str10 = "carrot";
        int res5 = str9.CompareTo(str10);
        Console.WriteLine(res5);    // 1; (Since "capcicum" is bigger than "carrot"

        Console.WriteLine("6. Comparing Strings with Special Characters");
        string str11 = "coding!";
        string str12 = "coding";
        int res6 = str11.CompareTo(str12);
        Console.WriteLine(res6);    // 1; (Since "coding!" precedes "coding" in the sort order)

        Console.WriteLine("7. Comparing Strings with Null");
        string str13 = 
    }
}