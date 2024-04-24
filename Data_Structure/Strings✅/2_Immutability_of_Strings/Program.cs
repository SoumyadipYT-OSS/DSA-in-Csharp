using System;
/*
    String objects are immutable: they can't be changed after they've been created. 
    All of the String methods and C# operators that appear to modify a string actually 
    return the results in a new string object. 
*/
namespace pr2
{
    class q2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("__Example 1__");
            string s1 = "C# programming language needs ";
            string s2 = ".NET platform to run it.";

            // string concatenation.
            s1 += s2;  // creates a new string object and stores it in s1, releasing the reference to the original object.
            System.Console.WriteLine(s1);


            Console.WriteLine("__Example 2__");
            string str1 = "This is Visual ";
            string str2 = str1;
            str1 += "Studio IDE C# Console";
            Console.WriteLine("str1: " + str1);
            Console.WriteLine($"str2: {str2}");

        }
    }
}
