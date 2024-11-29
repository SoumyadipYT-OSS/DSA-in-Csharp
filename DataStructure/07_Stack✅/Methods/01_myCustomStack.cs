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
    
    // Resize: Double the capacity of the stack
    private void Resize() {
        capacity *= 2;
        T[] newElements = new T[capacity];
        Array.Copy(elements, newElements, size);
        elements = newElements;
    }

    // Property to get the current size of the stack
    public int Count {
        get { return size; }
    }
    
    // Clear: Remove all elements from the stack
    public void Clear() {
        for (int i=0; i<size; i++) {
            elements[i] = default(T);
        }
        size = 0;
    }


    
    // Push: Add an element to the stack
    public void Push(T item) {
        if (size == capacity) {
            Console.WriteLine("Stack Overflow!");
            Console.WriteLine("Want to increase stack capacity? (y/N): ");
            char input;
            input = Console.ReadKey().KeyChar;
            if (input == 'y') {
                Resize();
            } else if (input == 'N') {
                Console.WriteLine("Okay, user. Stack Overflow!");
            } else {
                Console.WriteLine("Invalid input!");
            }
        }
        elements[size++] = item;
    }

    // Peek: View the top element without removing it
    public T Peek() {
        if (size == 0) {
            throw new InvalidOperationException("Stack is empty.");
        }
        return elements[size - 1];
    }

    // Pop: Remove the top element from the stack
    public T Pop() {
        if (size == 0) {
            throw new InvalidOperationException("Stack underflow");
        }
        T item = elements[--size];
        elements[size] = default(T);    // Clear the reference
        return item;
    }

    // Contains: Check if the stack contains a specific element
    public bool Contains(T item) {
        for (int i=0; i<size; i++) {
            if (elements[i].Equals(item))
                return true;
        }
        return false;
    }

    // ToArray: Convert the stack to an array
    public T[] ToArray() {
        T[] array = new T[size];
        Array.Copy(elements, array, size);
        return array;
    }
}




class Program {
    static void Main() {
        CustomStack<int> stack = new CustomStack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine("Top element: " + stack.Peek());
        Console.WriteLine("Popped element: " + stack.Pop());
        Console.WriteLine("Contains 2? " + stack.Contains(2));
        Console.WriteLine("Contains 4? " + stack.Contains(4));

        int[] array = stack.ToArray();
        Console.WriteLine("Stack as array: " + string.Join(", ", array));

        stack.Clear();
        Console.WriteLine("Stack cleared! \nCount: " + stack.Count);
    }
}