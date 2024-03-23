using System;

namespace declaration_Struct {
    struct Coordinate {
        public int x;
        public int y;
    }

    public class Program {
        public static void Main() {
            Coordinate point = new Coordinate();
            Console.WriteLine(point.x); // 0
            Console.WriteLine(point.y); // 0

            point.x = 10;
            point.y = 20;
            
            Console.WriteLine(point.x); // 10
            Console.WriteLine(point.y); // 20
        }
    }
}