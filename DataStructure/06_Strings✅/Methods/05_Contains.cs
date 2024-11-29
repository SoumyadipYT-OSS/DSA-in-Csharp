using System;

/*  Contains: Checks if the string contains a specified substring   */


class Program {
    static void Main() {
        string str = "Enterprise";
        bool contains = str.Contains("erp");
        Console.WriteLine(contains);


        string str2 = "Business";
        bool contains2 = str2.Contains("B");    // we can't use single quote '' here.
        Console.WriteLine(contains2);
    }
}