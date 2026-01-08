
namespace _03_BinarySearch;


public class Algorithm
{
    public static int BinarySearch(int[] arr, int target)
    {
        if (arr == null || arr.Length == 0)
            return -1;

        else if (arr.Length == 1)
            return target;

        else
            return BinarySearchAlgo(arr, 0, arr.Length - 1, target);
    }

    private static int BinarySearchAlgo(int[] a, int left, int right, int target)
    {
        if (left > right)
            return -1;

        int mid = left + (right - left) / 2;

        if (a[mid] == target)
            return a[mid];

        else if (target < a[mid])
            return BinarySearchAlgo(a, left, mid - 1, target);

        else
            return BinarySearchAlgo(a, mid + 1, right, target);
    }
}