using System;
using System.Text;

// In C#, [object] is used to pass any type of data to a method.

namespace MethodsStringBuilder {
    class Program {
        static void AppendMethod(StringBuilder sb, object val) {
            sb.Append(" ");
            sb.Append(val);
            Console.WriteLine(sb);
        }

        // Insert method specific index
        static void InsertMethod(StringBuilder sb, object val, int index) {
            sb.Insert(index, " ");
            sb.Insert(index + 1, val);
            Console.WriteLine(sb);
        }

        // Main Method
        static void Main(string[] args) {
            StringBuilder sb1 = new StringBuilder("Welcome");
            AppendMethod(sb1, "to");
            AppendMethod(sb1, "C#");
            AppendMethod(sb1, "Programming");

            StringBuilder sb2 = new StringBuilder("dotnet");
            InsertMethod(sb2, "MAUI");
            InsertMethod(sb2, "is", 5);
            InsertMethod(sb2, "awesome", 8);
        }
    }
}