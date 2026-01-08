using static System.Console;

namespace _03_BinarySearch;


public class Program
{
    static void Main()
    {
        WriteLine("Binary Search algorithm in C#");

        /* 
            Binary Search works on sorted array, for unsorted array 
            sort the array first. It takes O(nlogn) time complexity. 
        */

        int[] arr = { 4, 6, 9, 12, 15, 17, 20 };
        int search = 15;
        WriteLine(Algorithm.BinarySearch(arr, search));
    }
}