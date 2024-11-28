using System;

class Node {
    public int data;
    public Node Next;

    public Node (int data) {
        this.data = data;
        Next = null;
    }
}


class CircularLinkedList {
    private Node head;

    public CircularLinkedList() {
        head = null;
    }

    // Insert a new node at the end of the circular linked list
    public void InsertAtEnd(int data) {
        Node newNode = new Node(data);
        if (head == null) {
            head = newNode;
            newNode.Next = head;
            return;
        }

        Node current = head;
        while (current.Next != head) {
            current = current.Next;
        }
        current.Next = newNode;
        newNode.Next = head;
    }

    // Display the circular linked list
    public void Display() {
        if (head == null) {
            Console.WriteLine("List is empty.");
            return;
        }

        Node current = head;
        do {
            Console.Write(current.data + "->");
            current = current.Next;
        } while (current != head);
        Console.WriteLine("(head)");
    }
}



class Program {
    static void Main() {
        CircularLinkedList cll = new CircularLinkedList();
        cll.InsertAtEnd(10);
        cll.InsertAtEnd(20);
        cll.InsertAtEnd(30);
        cll.Display();
    }
}