using System;

namespace NullableType_Methods {
    class Solution {
        static void Main(string[] args) {
            Nullable<int> i = null;

            if (i.HasValue)
                Console.WriteLine(i.Value);
            else
                Console.WriteLine("Null");
        }
    }
}