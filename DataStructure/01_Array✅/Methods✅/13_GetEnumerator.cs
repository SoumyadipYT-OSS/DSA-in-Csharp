using System;

class Example {
    static void Main() {
        string[] myArr = new string[10];
        myArr[0] = "The";
        myArr[1] = "quick";
        myArr[2] = "brown";
        myArr[3] = "fox";
        myArr[4] = "jumps";
        myArr[5] = "over";
        myArr[6] = "the";
        myArr[7] = "lazy";
        myArr[8] = "dog";

        // Displays the values of the Array.
        int i = 0;
        System.Collections.IEnumerator myEnumerator = myArr.GetEnumerator();
        Console.WriteLine("The array contains the following values:");
        while ((myEnumerator.MoveNext()) && (myEnumerator.Current != null)) {
            Console.WriteLine("[{0}] {1}", i++, myEnumerator.Current);
        }
    }
}