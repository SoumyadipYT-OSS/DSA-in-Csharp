/*
    A 'struct' cannot contain a parameterless constructor. It is not possible to have a struct without a constructor.
    It can only contain a parameterized constructor or a static constructor.
    The default constructor is not allowed in a struct. The default constructor is a constructor that takes no parameters.
    The default constructor is automatically called when an object is created.
     - The static constructor is called automatically to initialize the class before the first instance 
        is created or any static members are referenced.
     - A static constructor does not take access modifiers or have parameters.
 */

using System;


namespace Constructors_in_Structure {
    struct Coordinate {
        public int x;
        public int y;
        public Coordinate(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }


    class Soluton {
        static void Main(string[] args) {
            Coordinate point = new Coordinate(10, 15);
            Console.WriteLine("x = " + point.x + " y = " + point.y);

            var point1 = new Coordinate(2, 4);
            Console.WriteLine("x = " + point1.x + " y = " + point1.y);
        }
    }
}