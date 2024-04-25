using System;
using System.Text;

namespace REMOVESTRING {
    class Solution {
        static void RemoveStringMethod(StringBuilder sb, int index, int length) {
            sb.Remove(index, length);
            Console.WriteLine(sb);
        }

        static void Main(string[] args) {
            StringBuilder sb = new StringBuilder("This is Visual Studio IDE for C#");
            RemoveStringMethod(sb, 10, 8);    // Output: This is Studio IDE for C#
        }
    }
}