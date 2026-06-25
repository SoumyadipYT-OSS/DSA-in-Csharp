
using static System.Console;

namespace _04_QuickSort;


public class Program
{
    static void Main()
    {
        WriteLine("Quick Sort algorithm");
        int[] array1 = { 5, 2, 1, 4, 8, 5 };

        WriteLine("Before: " + string.Join(", ", array1));
        Algorithm.QuickSort(array1);
        WriteLine("After:  " + string.Join(", ", array1));
    }
}