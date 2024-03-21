using System;
using System.Collections;

/*
    AddRange(ICollection c) method to add an entire Array, HashTable,
    ArrayList, BitArray, Queue and Stack into the ArrayList.
*/

namespace AddRangeMethod_in_ArrayList {
    public class Solution {
        // method to display the elements of the ArrayList
        public static void DisplayElements (ArrayList arrList) {
            foreach (var item in arrList) {
                Console.Write (item + " ");
            }
            Console.WriteLine ();
        }

        // Implementation of AddRange() method
        protected static void AddingArray() {
            var al1 = new ArrayList();
            var al2 = new ArrayList() {
                1, "C#", " ", true, 8.8, null
            };

            int[] arr = { 100, 200, 300, 400 };

            Queue myQ = new Queue();
            myQ.Enqueue("C#");
            myQ.Enqueue("programming");

            al1.AddRange(al2);  // adding arraylist `al2` into `al1` arraylist
            DisplayElements(al1);
            al1.AddRange(arr);  // adding array `arr` into `al1` arraylist
            DisplayElements(al1);
            al1.AddRange(myQ);  // adding queue `myQ` into `al1` arraylist
            DisplayElements(al1);
        }


        // main method
        static void Main(string[] args) {
            AddingArray();
        }
    }
}