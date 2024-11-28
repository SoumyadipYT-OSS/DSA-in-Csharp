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

    // Insert a new node at the beginning of the doubly linked list
    public void InsertAtBeginning(int data) {
        Node newNode = new Node(data);
        if (head != null) {
            head.Prev = newNode;
        }
        newNode.Next = head;
        head = newNode;
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

    // Insert a new node at a specific positon in the doubly linked list
    public void InsertAtPositon(int data, int pos) {
        if (pos < 1) {
            Console.WriteLine("Positon should be >= 1");
            return;
        }

        if (pos == 1) {
            InsertAtBeginning(data);
            return;
        }


        Node newNode = new Node(data);
        Node current = head;
        for (int i=1; i<pos-1 && current!=null; i++) {
            current = current.Next;
        }

        if (current == null) {
            Console.WriteLine("Position out of range.");
        } else {
            newNode.Next = current.Next;
            if (current.Next != null) {
                current.Next.Prev = newNode;
            }
            current.Next = newNode;
            newNode.Prev = current;
        }
    }


    // Delete a node with a specific value from the doubly linked list
    public void DeleteNode(int data) {
        if (head == null) {
            Console.WriteLine("List is empty.");
            return;
        }

        Node current = new Node(data);
        while (current != null   &&   current.data != data) {
            current = current.Next;
        }

        if (current == null) {
            Console.WriteLine("Value not found in the Linked List");
            return;
        }

        if (current.Prev != null) {
            current.Prev.Next = current.Next;
        } else {
            head = current.Next;
        }

        if (current.Next != null) {
            current.Next.Prev = current.Prev;
        }
    }

    // Search for a node with a specific value in the doubly linked list
    public Node Search(int data) {
        Node current = head;
        while (current != null) {
            if (current.data == data) {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    // Get the lenght of the doubly linked list
    public int GetLength() {
        int length = 0;
        Node current = head;
        while (current != null) {
            length++;
            current = current.Next;
        }
        return length;
    }

    // Reverse the doubly linked list
    public void Reverse() {
        Node current = head;
        Node temp = null;
        while (current != null) {
            temp = current.Prev;
            current.Prev = current.Next;
            current.Next = temp;
            current = current.Prev;
        }

        if (temp != null) {
            head = temp.Prev;
        }
    }

    // Display the doubly linked list
    public void Display() {
        Node current = head;
        while (current != null) {
            Console.Write(current.data + "<-->");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}




class Program {
    static void Main() {
        DoublyLinkedList dll = new DoublyLinkedList();
        dll.InsertAtBeginning(10);
        dll.InsertAtEnd(20);
        dll.InsertAtPositon(15, 2);
        dll.Display();

        dll.DeleteNode(15);
        dll.Display();

        dll.InsertAtEnd(30);
        dll.InsertAtEnd(40);
        dll.Reverse();
        dll.Display();

        Console.WriteLine("Length: " + dll.GetLength());

        Node foundNode = dll.Search(20);
        if (foundNode != null) {
            Console.WriteLine($"Node with value {foundNode} found.");
        } else {
            Console.WriteLine("The value not found");
        }
    }
}