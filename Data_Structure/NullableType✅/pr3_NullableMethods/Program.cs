using System;

namespace NullableType_Methods {
    class Solution {
        static void GetValueOrDefault_Method() {
            Nullable<int> i = null;
            Console.WriteLine(i.GetValueOrDefault());
        }

        static void HasValue_Method() {
            Nullable<int> i = null;

            if (i.HasValue)
                Console.WriteLine(i.Value);
            else
                Console.WriteLine("Null");
        }

        static void ShortHandSyntax() {
            int? i = null;
            double? d = null;
            char? c = null;
            bool? b = null;
            Console.WriteLine(i);
            Console.WriteLine(d);
            Console.WriteLine(c);
            Console.WriteLine(b);
        }

        static void OperatorMethod() {
            int? i = null;
            int j = i ?? 0;
            Console.WriteLine(j);
        }


        static void Main(string[] args) {
            GetValueOrDefault_Method();
            HasValue_Method();
            ShortHandSyntax();
            OperatorMethod();
        }
    }
}