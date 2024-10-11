/*
     Array.Resize<T>(T[], Int32) method
*/
using System;

class SampleArray {
    protected static void PrintIndexAndValues(string[] myArr) {
        for (int i=0; i<myArr.Length; i++) {
            Console.WriteLine("\t [{0}] : {1}", i, myArr[i]);
        }
        Console.WriteLine();
    }

    // Main method
    static void Main() {
        string[] programmingLanguages = { "C#", "C++", "Python", "Rust" };
        PrintIndexAndValues(programmingLanguages);
    }
}


/*
This code produces the following output.

The string array initially contains the following values:
   [0] : The
   [1] : quick
   [2] : brown
   [3] : fox
   [4] : jumps
   [5] : over
   [6] : the
   [7] : lazy
   [8] : dog

After resizing to a larger size,
the string array contains the following values:
   [0] : The
   [1] : quick
   [2] : brown
   [3] : fox
   [4] : jumps
   [5] : over
   [6] : the
   [7] : lazy
   [8] : dog
   [9] :
   [10] :
   [11] :
   [12] :
   [13] :

After resizing to a smaller size,
the string array contains the following values:
   [0] : The
   [1] : quick
   [2] : brown
   [3] : fox

*/