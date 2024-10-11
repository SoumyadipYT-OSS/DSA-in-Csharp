using System;
/*
    Initialize Method: Initializes every element of the value-type 'Array' by calling the parameterless constructor 
                of the value type.
*/

namespace ArrayExtensions {
    public static class myCustomArrayClass {
        public static void Initialize<T>(this T[] array) {
            for (int i=0; i<array.Length; i++) {
                array[i] = default(T);
            }
        }
    }
}



class Program {
    // Main method
    static void Main() {
        int[] num = new int[5];

        ArrayExtensions.myCustomArrayClass.Initialize(num);

        Console.WriteLine("Array elements after initialization");
        foreach (int n in num)
            Console.Write(n + " ");
    }
}