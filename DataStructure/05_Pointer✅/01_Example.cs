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
}


class Program {
    static void Main() {
        BasicPointerExample obj1 = new BasicPointerExample();
        obj1.Ex1();
    }
}