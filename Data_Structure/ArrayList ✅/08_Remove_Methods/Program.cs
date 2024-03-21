using System;
using System.Collections;

/*
    Use the Remove(), RemoveAt(), or RemoveRange methods to remove elements from an ArrayList.
*/


namespace Remove_Methods_ArrayList {
    public class Solution {
        // method to display ArrayList
        protected static void Display(ArrayList al) {
            foreach (var obj in al) {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

        // main method
        static void Main(string[] args) {
            ArrayList al = new ArrayList() {
                "A1", "B2", "C3", "D4", "E5", "F6"
            };

            Display(al);
            al.Remove(null);    // Removes first occurrence of null
            Display(al);
            al.Remove("A1");
            Display(al);
            al.RemoveAt(2);     // Removes element at index 2
            Display(al);
            al.RemoveRange(1, 2);    // Removes elements from index 1 to 2
            Display(al);

        }
    }
}