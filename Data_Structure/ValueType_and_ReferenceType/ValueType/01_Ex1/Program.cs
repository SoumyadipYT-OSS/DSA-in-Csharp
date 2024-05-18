using System;

namespace ValueTypeExample1 
{
    class Solution {
        protected static void ChangeValue(int x) {
            x = 200;
            Console.WriteLine(x);
        }

        // Main method
        static void Main(string[] args) {
            int i = 100;

            Console.WriteLine(i);

            ChangeValue(i);

            Console.WriteLine(i);
        }
    }
}