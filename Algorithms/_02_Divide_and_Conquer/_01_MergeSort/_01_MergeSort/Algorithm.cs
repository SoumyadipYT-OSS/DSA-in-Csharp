
namespace _01_MergeSort;


public class Algorithm
{
    public static void MergeSort(int[] a)
    {
        if (a == null || a.Length <= 1) return;
        var buf = new int[a.Length];
        SortAlgo(a, 0, a.Length - 1, buf);
    }

    private static void SortAlgo(int[] a, int left, int right, int[] buffer)
    {
        if (left >= right) return;

        int mid = left + (right - left) / 2;
        SortAlgo(a, left, mid, buffer);
        SortAlgo(a, mid + 1, right, buffer);

        if (a[mid] <= a[mid + 1]) return; // already ordered
        MergeAlgo(a, left, mid, right, buffer);
    }

    private static void MergeAlgo(int[] a, int left, int mid, int right, int[] buffer)
    {
        int i = left, j = mid + 1, k = left;

        while (i <= mid && j <= right)
            buffer[k++] = (a[i] <= a[j]) ? a[i++] : a[j++];

        while (i <= mid) buffer[k++] = a[i++];
        while (j <= right) buffer[k++] = a[j++];

        for (int t = left; t <= right; t++) a[t] = buffer[t];
    }
}