using static System.Console;

namespace _02_SumOfArray;

public class Program
{
    public static int SumRecursiveArr(int[] arr) 
    {
        return arr is null ? throw new ArgumentNullException(nameof(arr)) : Algo(arr, 0);
    }

    private static int Algo(int[] arr, int idx)
    {
        if (idx >= arr.Length)
            return 0;

        return arr[idx] + Algo(arr, idx + 1);    // This line contains recursive algorithm logic
    }


    static void Main()
    {
        WriteLine("Finding the sum of array");
        int[] inputArr = { 2, 5, 8, 3 };
        WriteLine(SumRecursiveArr(inputArr));
    }
}