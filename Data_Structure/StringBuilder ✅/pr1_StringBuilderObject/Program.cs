using System;
using System.Text;

namespace pr1_StringBuilderConcept {
    class StringBuilderConcept {
        static void Main(string[] args) {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine(sb);
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.ToString());

            StringBuilder sb1 = new StringBuilder("C#");
            Console.WriteLine("sb1: " + sb1);
            Console.WriteLine(sb1.Capacity);
            Console.WriteLine(sb1.Length);
            Console.WriteLine(sb1.ToString());

            StringBuilder sb2 = new StringBuilder("C# Programming Language", 50);
            Console.WriteLine("sb2: " + sb2);
            Console.WriteLine(sb2.Capacity);
            Console.WriteLine(sb2.Length);
            Console.WriteLine(sb2.ToString());

            StringBuilder sb3 = new StringBuilder(".NET programming");
            Console.Write("sb3: ");
            for (int i=0; i<sb3.Length; i++) {
                Console.Write(sb3[i]);
            }
        }
    }
}