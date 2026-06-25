
using static System.Console;

namespace _01_MergeSort
{
    public class MergeSortAlgorithm
    {
        static void Main()
        {
            WriteLine("Merge Sort (Divide and Conquer approach)");
            int[] arr = { 4, 2, 6, 9, 3 };
            Algorithm.MergeSort(arr);
            WriteLine(string.Join(", ", arr)); // 2, 3, 4, 6, 9
        }
    }
}