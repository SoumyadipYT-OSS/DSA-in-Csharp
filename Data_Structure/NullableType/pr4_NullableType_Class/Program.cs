using System;

namespace NullableTypeClass {
    class MyClass {
        public Nullable<int> i = null;
    }

    class Solution {
        static void Main(string[] args) {
            MyClass mycls = new MyClass();

            if (mycls.i == null)
                Console.WriteLine("Null");
            else
                Console.WriteLine(mycls.i.Value);
        }
    }
}