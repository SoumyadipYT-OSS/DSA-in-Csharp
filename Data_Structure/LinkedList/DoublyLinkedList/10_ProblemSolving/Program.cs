using System;

/*
    Triangle of user defined of integer sum in triangle pattern
*/


namespace triangleIntegerSumTrianglePattern {
    class Solution() {
        protected static void Sum(int indexVal) {
            for (int i=1; i<=indexVal; i++) {
                int sum = 0;
                for (int j=1; j<=i; j++) {
                    sum += j;
                    if (j==i) {
                        Console.Write(j);
                    } else {
                        Console.Write(j + "+");
                    }
                }
                Console.WriteLine("=" + sum);
            }
        }

        static void Main(string[] args) {
            int n = 5;
            Sum(n);
        }
    }
}