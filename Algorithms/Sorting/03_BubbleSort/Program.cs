using System;

namespace BUBBLE_SORT {
    class AlgoBubbleSort {
        protected static void displayArray(int[] arr) {
            for (int i=0;  i<arr.Length; i++) {
                Console.Write(arr[i]+", ");
            }
        }


        protected static void BubbleSort(int[] arr) {
            int size = arr.Length;
            for (int i=0; i<(size-1); i++) {
                for (int j=0; j<size-i-1; j++) {
                    if (arr[j] > arr[j+1]) {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
        }


        // main method
        static void Main(string[] args) {
            int[] arr = { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
            displayArray(arr);
            Console.WriteLine();
            BubbleSort(arr);
            displayArray(arr);
        }
    }
}