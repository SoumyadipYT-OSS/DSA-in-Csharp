// Insertion Sort

using System;

namespace InsertionSorting {
    public class Solution {
        protected static void InsertionSort(int[] arr) {
            Console.WriteLine("Insertion Sort");
            for (int i=1; i<arr.Length; i++) {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key) {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        // method to display array
        protected static void display(int[] arr) {
            for (int i=0; i<arr.Length; i++) {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        // method to user input array
        public static void userInput() {
            Console.WriteLine("Enter the size of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of array: ");
            for (int i=0; i<n; i++) {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array before sorting: ");
            display(arr);
            InsertionSort(arr);
            display(arr);
        }
    }


    public class Program {
        public static void Main(string[] args) {
            Solution.userInput();
        }
    }
}