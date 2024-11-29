/*
    Here is my custom implementation of Stack class without
    using any built-in function of 'Collections' namespace
    in C#. (Stack data structure -> LIFO)
*/


using System;


class CustomStack<T> {
    private T[] elements;
    private int size;
    private int capacity;

    public CustomStack(int capacity = 10) {
        this.capacity = capacity;
        elements = new T[capacity];
        size = 0;
    }

    
    // Push: Add an element to the stack
}