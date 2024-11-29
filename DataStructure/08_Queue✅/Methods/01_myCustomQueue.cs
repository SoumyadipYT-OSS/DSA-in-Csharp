using System;

/*
    Custom implementation of Queue class without
    using any built-in function of 'Collections' namespace
    in C#. (Queue data structure -> FIFO)
*/

class CustomQueue<T> {
    private T[] elements;
    private int front;
    private int rear;
    private int size;
    private int capacity;

    public CustomQueue(int capacity = 10) {
        this.capacity = capacity;
        elements = new T[capacity];
        front = 0;
        rear = -1;
        size = 0;
    }

    // Enqueue: Add an element to the end of the queue
    public void Enqueue(T item) {
        if (size == capacity) {
            Resize();
        }
        rear = (rear + 1) % capacity;
        elements[rear] = item;
        size++;
    }

    // Dequeue: Remove the element from the front of the queue
    public T Dequeue() {
        if (size == 0) {
            throw new InvalidOperationException("Queue underflow");
        }
        T item = elements[front];
        elements[front] = default(T); // Clear the reference
        front = (front + 1) % capacity;
        size--;
        return item;
    }

    // Peek: View the front element without removing it
    public T Peek() {
        if (size == 0) {
            throw new InvalidOperationException("Queue is empty.");
        }
        return elements[front];
    }

    // Contains: Check if the queue contains a specific element
    public bool Contains(T item) {
        for (int i = 0; i < size; i++) {
            int index = (front + i) % capacity;
            if (elements[index].Equals(item)) {
                return true;
            }
        }
        return false;
    }

    // ToArray: Convert the queue to an array
    public T[] ToArray() {
        T[] array = new T[size];
        for (int i = 0; i < size; i++) {
            array[i] = elements[(front + i) % capacity];
        }
        return array;
    }

    // Clear: Remove all elements from the queue
    public void Clear() {
        for (int i = 0; i < size; i++) {
            elements[(front + i) % capacity] = default(T);
        }
        front = 0;
        rear = -1;
        size = 0;
    }

    // Resize: Double the capacity of the queue
    private void Resize() {
        int newCapacity = capacity * 2;
        T[] newElements = new T[newCapacity];
        for (int i = 0; i < size; i++) {
            newElements[i] = elements[(front + i) % capacity];
        }
        elements = newElements;
        front = 0;
        rear = size - 1;
        capacity = newCapacity;
    }

    // Property to get the current size of the queue
    public int Count {
        get { return size; }
    }
}


// Example usage
class Program {
    static void Main() {
        CustomQueue<int> queue = new CustomQueue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine("Front element: " + queue.Peek());
        Console.WriteLine("Dequeued element: " + queue.Dequeue());
        Console.WriteLine("Contains 2? " + queue.Contains(2));
        Console.WriteLine("Contains 4? " + queue.Contains(4));

        int[] array = queue.ToArray();
        Console.WriteLine("Queue as array: " + string.Join(", ", array));

        queue.Clear();
        Console.WriteLine("Queue cleared! \nCount: " + queue.Count);
    }
}