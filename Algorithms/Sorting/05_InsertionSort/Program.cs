using System;

namespace INSERTION_SORT_ALGO {
    class Solution {
        protected static void displayArray(int[] arr) {
            for (int i=0; i<arr.Length; i++) {
                Console.Write(arr[i] + ", ");
            }
        }

        private static Boolean more(int v1, int v2) {
            return v1 > v2;
        }

        protected static void InsertionSort(int[] arr) {
            int size = arr.Length; int temp = 0; int j = 0;
            for (int i=1; i<size; i++) {
                temp = arr[i];
                for (j=i; j>0  && more(arr[j-1], temp); j--) {
                    arr[j] = arr[j - 1];
                }
                arr[j] = temp;
            }
        }


        // main method
        static void Main(string[] args) {
            int[] array = { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
            displayArray(array);
            Console.WriteLine();
            InsertionSort(array);
            displayArray(array);
        }
    }
}