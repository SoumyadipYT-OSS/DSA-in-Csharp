using System;

/*
    Implicity Typed Arrays:
    - In C#, we can create an array without specifying the type of the array.
    - The type of the array is determined by the elements that we are going to store in the array.
    - It is used when we want to create an array without specifying the type of the array.
*/

class ImplicityTypedArrays {
    static void Main() {
        // Creating an array without specifying the type of the array
        var arr = new[] { 1, 2, 3, 4, 5 };

        // Displaying the elements of the array
        for (int i = 0; i < arr.Length; i++) {
            Console.Write(arr[i] + " ");
        }
    }
}