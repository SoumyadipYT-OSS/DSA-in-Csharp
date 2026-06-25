
namespace _02_KadaneAlgorithm
{
    public class Algorithm
    {
        // Kadane: O(n)
        public static int Kadane(int[] a)
        {
            if (a == null || a.Length == 0)
                throw new ArgumentException("Empty Array");

            int best = a[0], cur = a[0];
            for (int i = 1; i < a.Length; i++) {
                cur = Math.Max(a[i], cur + a[i]);
                best = Math.Max(best, cur);
            }
            return best;
        }


        // Divide & Conquer: O(n log n)
        public static int KadaneAlgo_Divide_and_Conquer(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Empty Array");

            return Algo(arr, 0, arr.Length - 1);
        }

        private static int Algo(int[] a, int left, int right)
        {
            if (left == right) return a[left];

            int mid = left + (right - left) / 2;

            int bestLeft = Algo(a, left, mid);
            int bestRight = Algo(a, mid + 1, right);

            int sum = 0, leftCross = int.MinValue;
            for (int i = mid; i >= left; i--) {
                sum += a[i];
                leftCross = Math.Max(leftCross, sum);
            }

            sum = 0; int rightCross = int.MinValue;
            for (int i = mid + 1; i <= right; i++) {
                sum += a[i];
                rightCross = Math.Max(rightCross, sum);
            }

            int cross = leftCross + rightCross;
            return Math.Max(Math.Max(bestLeft, bestRight), cross);
        }
    }
}