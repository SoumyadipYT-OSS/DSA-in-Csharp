using System;

/*
    Jagged Array in C#:
    
    Jagged array is such an array which have elements of different dimensions.
 */

class JaggedArray {
    public void jaggedArray() {
        int[][] jArr = new int[3][]; // Declaration of Jagged Array

        // Initialization of Jagged Array
        jArr[0] = new int[3] { 1, 2, 3 };
        jArr[1] = new int[2] { 4, 5 };
        jArr[2] = new int[4] { 6, 7, 8, 9 };


        // Accessing Jagged Array
        for (int i = 0; i < jArr.Length; i++) {
            for (int j = 0; j < jArr[i].Length; j++) {
                Console.Write(jArr[i][j] + " ");
            }
            Console.WriteLine();
        }

        /*
            Visual representation of this jagged array example:
            jArr[0] = new int[3] { 1, 2, 3 };
            jArr[1] = new int[2] { 4, 5 };
            jArr[2] = new int[4] { 6, 7, 8, 9 };

            [
                [1 2 3]
                [4 5]
                [6 7 8 9]
            ]

            The array contains 3 elements, where each element is an array of integers.
            So here, the first element is an array of 3 integers, 
            the second element is an array of 2 integers, 
            and the third element is an array of 4 integers.

            In the real life scenario where jagged array is used?
            ans: In the real life scenario, jagged array is used when we have to store the data of different dimensions.
                Say, an example of a school where we have to store the marks of students of different classes.
        */
    }


    // main method
    static void Main(string[] args) {
        JaggedArray jar = new JaggedArray();
        jar.jaggedArray();
    }
}
