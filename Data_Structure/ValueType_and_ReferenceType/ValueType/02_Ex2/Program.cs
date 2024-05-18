using System;

namespace Example2 
{
    class Solution {
        protected static void ChangeValue(String str) {
            str = "New Value";
            Console.WriteLine(str);
        }

        // Main Method
        static void Main(string[] args) {
            String s = "Old Value";

            Console.WriteLine(s);

            ChangeValue(s);

            Console.WriteLine(s);
        }
    }
}