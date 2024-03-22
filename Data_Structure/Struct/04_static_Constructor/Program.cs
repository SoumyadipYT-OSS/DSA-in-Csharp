using System;

namespace staticConstructor_in_struct {
    struct ShapeArea {
        public int area;

        public ShapeArea(int a) {
            this.area = a;
        }

        public static ShapeArea GetArea() {
            return new ShapeArea();
        }
    }

    // Main method
    public class Solution {
        static void Main(string[] args) {
            ShapeArea p = ShapeArea.GetArea();
            Console.WriteLine(p.area);  // Output: 0

            ShapeArea p1 = new ShapeArea(10);
            Console.WriteLine(p1.area);  // Output: 10
        }
    }
}