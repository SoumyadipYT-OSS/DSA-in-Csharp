using System;
using System.Text;

namespace REPLACESTRING {
    class Solution {
        static void ReplaceStringMethod(StringBuilder sb, string oldValue, string newValue) {
            sb.Replace(oldValue, newValue);
            Console.WriteLine(sb);
        }

        static void Main(string[] args) {
            StringBuilder sb = new StringBuilder("This is Visual Studio IDE for C#");
            ReplaceStringMethod(sb, "Visual Studio", "Visual Studio Professional");    // Output: This is Visual Studio Code IDE for C#
        }
    }
}