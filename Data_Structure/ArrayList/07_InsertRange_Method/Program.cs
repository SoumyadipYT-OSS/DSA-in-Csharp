using System;
using System.Collections;


/*
    Use the InsertRange() method to insert a collection in an ArrayList at the specfied index.
    Signature: Void InsertRange(int index, ICollection c)
 */

namespace Insert_Range_ArrayList {
    public class Solution() {
        static void Main(string[] args) {
            ArrayList al1 = new ArrayList() {
                100, 200, 600
            };

            ArrayList al2 = new ArrayList() {
                300, 400, 500
            };

            al1.InsertRange(2, al2);


            foreach (var item in al1)
                Console.Write(item + ", ");
        }
    }
}