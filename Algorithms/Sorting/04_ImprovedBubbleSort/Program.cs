using System;

namespace IMPROVED_BUBBLE_SORT {
    class Solution {
        protected static void displayArray(int[] arr) {
            for (int i=0; i<arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }
        }

        protected static void ImprovedBubbleSort(int[] arr) {
            int size = arr.Length;
            int i, j, temp, swapped = 1;(
            for (i=0; i<(size-1) && swapped == 1; i++) {
                swapped = 0;
                for (j=0; j<size-i-1; j++) {
                    if (arr[j] > arr[j+1]) {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
        }


        // main method
        static void Main(string[] args) {
            int[] arr = { 4, 2, 6, 1, 3 };
            displayArray(arr);
            Console.WriteLine();
            ImprovedBubbleSort(arr);
            displayArray(arr);
        }
    }
}