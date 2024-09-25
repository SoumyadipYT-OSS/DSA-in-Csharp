using System.Collections.Generic;
using System;

class Program {
    static int Main(string[] args) {
        // define the dictionary
        Dictionary<int,string> dict = new Dictionary<int, string>();

        // adding key-value pairs
        dict[1] = "Apple";
        dict[2] = "Banana";

        foreach (KeyValuePair<int,string> ele in dict) {
            Console.WriteLine("{0} : {1}", ele.Key, ele.Value);
        }



        /* Another way to define dictionary */
        Dictionary<int,string> dict2 = new Dictionary<int,string> {
            {7, "Cristiano Ronaldo"},
            {11, "Sunil Chettri"},
            {1, "Sandesh Jinghan"},
            {2, "Pritam Kotal"},
            {10, "Ishan Pandita"}
        };

        foreach (KeyValuePair<int,string> it in dict2) {
            Console.WriteLine("JerseyNo: {0} -> Player Name: {1}", it.Key, it.Value);
        }

        return 0;
    }
}
