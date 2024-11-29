using System;

public class BasicPointerExample {
    public unsafe void Ex1() {
        int number = 42;    // declare an integer variable
        int* pointerToNumber = &number;     // get the address of the variable

        Console.WriteLine($"Value of the variable: {number}");
        Console.WriteLine($"Address of the variable: {(long)pointerToNumber}");

        *pointerToNumber = 100;     // change the value at the address
        Console.WriteLine($"New value of the variable: {number}");
    }


    public unsafe void Ex2() {
        Console.WriteLine("Address-of operator &");
        int number = 27;
        int* pointerToNumber = &number;     // storing the address of the variable

        Console.WriteLine($"Value of the variable: {number}");
        Console.WriteLine($"Address of the variable: {(long)pointerToNumber}");
    }


    public unsafe void Ex3() {
        Console.WriteLine("Pointer indirection operator *");
        char letter = 'A';
        char* pointerToLetter = &letter;
        Console.WriteLine($"Value of the `letter` variable: {letter}");
        Console.WriteLine($"Address of the `letter` variable: {(long)pointerToLetter:X}");

        *pointerToLetter = 'Z';
        Console.WriteLine($"Value of the `letter` variable after update: {letter}");
    }



    public struct Coords {
        public int X;
        public int Y;
        public override string ToString() => $"({X}, {Y})";
    }
    public unsafe void Ex4() {
        Console.WriteLine("Pointer member access operator ->");
        Coords coords;
        Coords* p = &coords;
        p->X = 3;
        p->Y = 4;
        Console.WriteLine(p->ToString());   // output: (3, 4)
    }



    public unsafe void Ex5() {
        Console.WriteLine("Pointer element access operator []");
        char* pointerToChars = stackalloc char[123];

        for (int i=65; i<123; i++) {
            pointerToChars[i] = (char)i;
        }

        Console.Write("Uppercase letters: ");
        for (int i=65; i<91; i++) {
            Console.Write(pointerToChars[i]);
        }
    }



    public unsafe void Ex6() {
        Console.WriteLine("Pointer arithmetic operators");
        const int Count = 3;
        int[] numbers = new int[Count] { 10, 20, 30 };
        fixed (int* pointerToFirst = &numbers[0]) {
            int* pointerToLast = pointerToFirst + (Count - 1);

            Console.WriteLine($"Value {*pointerToFirst} at address {(long)pointerToFirst}");
            Console.WriteLine($"Value {*pointerToLast} at address {(long)pointerToLast}");
        }
    }



    public unsafe void Ex7() {
        Console.WriteLine("Pointer subtraction");
        int* numbers = stackalloc int[] { 0, 1, 2, 3, 4, 5 };
        int* p1 = &numbers[1];
        int* p2 = &numbers[2];
        Console.WriteLine(p2 - p1);
    }



    public unsafe void Ex8() {
        Console.WriteLine("Pointer increment and decrement");
        int* numbers = stackalloc int[] { 0, 1, 2 };
        int* p1 = &numbers[0];
        int* p2 = p1;
        Console.WriteLine($"Before operation: p1 - {(long)p1}, p2 - {(long)p2}");
        Console.WriteLine($"Postfix increment of p1: {(long)(p1++)}");
        Console.WriteLine($"Prefix increment of p2: {(long)(++p2)}");
        Console.WriteLine($"After operation: p1 - {(long)p1}, p2 - {(long)p2}");
    }
}




class Program {
    static void Main() {
        BasicPointerExample obj1 = new BasicPointerExample();

        obj1.Ex1();

        Console.WriteLine();

        obj1.Ex2();

        Console.WriteLine();

        obj1.Ex3();

        Console.WriteLine();

        obj1.Ex4();

        Console.WriteLine();

        obj1.Ex5();

        Console.WriteLine();

        obj1.Ex6();

        Console.WriteLine();

        obj1.Ex7();

        Console.WriteLine();

        obj1.Ex8();

        Console.WriteLine();
    }
}