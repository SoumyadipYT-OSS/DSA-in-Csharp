using System;
using System.Collections;

namespace ArrayListDemo {
    public class Solution {
        public static bool isEmpty(ArrayList l) {
            return l.Count == 0;
        }

        protected static void printArrayList(ArrayList l) {
            foreach (var item in l) {
                Console.Write(item + ", ");
            } Console.WriteLine("]");
        }

        static void Main(string[] args) {
            ArrayList al = new ArrayList();
            al.Add(1);  // add 1 to the end of the list
            al.Add(2);  // add 2 to the end of the list

            Console.Write("Contents of the ArrayList: [ "); printArrayList(al);
            Console.WriteLine("Array Size: " + al.Count);
            Console.WriteLine("Is ArrayList empty? " + isEmpty(al));
        }
    }
}