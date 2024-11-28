using System;

class Node {
    public int data;
    public Node Next;
    public Node Prev;

    public Node(int data) {
        this.data = data;
        Next = null;
        Prev = null;
    }
}


class DoublyLinkedList {
    private Node head;

    public DoublyLinkedList() {
        head = null;
    }


    // Insert a new node at the end of the doubly linked list
    public void InsertAtEnd(int data) {
        Node newNode = new Node(data);
        if (head == null) {
            head = newNode;
            return;
        }

        Node current = head;
        while (current.Next != null) {
            current = current.Next;
        }
        current.Next = newNode;
        newNode.Prev = current;
    }


    // Display the doubly linked list
    public void Display() {
        Node current = head;
        while (current != null) {
            Console.Write(current.data + "<-->");
            current = current.Next;
        }
        Console.WriteLine("null\n");
    }
}



class Program {
    static void Main() {
        DoublyLinkedList dll = new DoublyLinkedList();
        dll.InsertAtEnd(10);
        dll.InsertAtEnd(20);
        dll.InsertAtEnd(30);
        dll.Display();
    }
}