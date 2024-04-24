using System;

namespace NullableTypeCompare {
    class Solution {
        static void Main(string[] args) {
            int? i = null;
            int j = 10;

            if (i < j)
                Console.WriteLine("i < j");
            else if (i > 10)
                Console.WriteLine("i > j");
            else if (i == 10)
                Console.WriteLine("i == j");
            else
                Console.WriteLine("Could not compare");
        }
    }
}