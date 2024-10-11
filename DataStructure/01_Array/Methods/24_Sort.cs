using System;
using System.Collections;

class Program {
    private static void PrintKeyAndValues(string[] myKeys, string[] myValues) {
        for (int i=0; i<myKeys.Length; i++) {
            Console.WriteLine("\t {0 - 10}: {1}", myKeys[i], myValues[i]);
        }
        Console.WriteLine();
    }

    protected class myReverserClass : Icomparer {
        int IComparer.Compare(object x, object y) {
            return ( (new CaseInsensitiveComparer()).Compare(y, x) );
        }
    }
}