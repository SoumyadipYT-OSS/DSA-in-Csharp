using System;
using System.Collections;

namespace Iterate_ArrayList {
    public class Solution {
        static void Main(string[] args) {
            ArrayList al = new ArrayList() {
                10,
                ".NET framework",
                300,
                8.9F
            };

            foreach (var item in al) {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < al.Count; i++) 
                Console.Write(al[i] + ", ");
            }
        }
}