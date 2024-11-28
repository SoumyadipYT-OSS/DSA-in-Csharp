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

    // Insert a new node at the beginning of the circular linked list
    public void InsertAtBeginning(int data) {
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
        newNode.Next = head;
        current.Next = newNode;
        head = newNode;
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


    // Insert a new node at a specific position in the circular linked list
    public void InsertAtPosition(int data, int pos) {
        if (pos < 1) {
            Console.WriteLine("Position should be >= 1");
            return;
        }

        if (pos == 1) {
            InsertAtBeginning(data);
            return;
        }

        Node newNode = new Node(data);
        Node current = head;
        for (int i=1; i<pos-1  &&  current.Next!=head; i++) {
            current = current.Next;
        }

        if (current.Next == head) {
            Console.WriteLine("Positon out of range.");
        } else {
            newNode.Next = current.Next;
            current.Next = newNode;
        }
    }


    // Delete an node with a specific value from the circular linked list
    public void DeleteNode(int data) {
        if (head == null) {
            Console.WriteLine("List is empty");
            return;
        }

        Node current = head;
        Node prev = null;
        do {
            if (current.data == data) {
                if (prev != null) {
                    prev.Next = current.Next;
                } else {
                    Node temp = head;
                    while (temp.Next != head) {
                        temp = temp.Next;
                    }
                    head = current.Next;
                    temp.Next = head;
                }
                return;
            }
            prev = current;
            current = current.Next;
        } while (current != head);

        Console.WriteLine("Value not found.");
    }


    // Delete a node at a specific position in the circular linked list
    public void DeleteAtPosition(int pos) {
        if (pos < 1) {
            Console.WriteLine("Position should be >= 1.");
            return;
        }

        if (head == null) {
            Console.WriteLine("List is empty.");
            return;
        }

        Node current = head;
        Node prev = null;
        for (int i=1; i<pos && current.Next!=head; i++) {
            prev = current;
            current = current.Next;
        }

        if (current.Next == head   &&   pos != 1) {
            Console.WriteLine("Position out of range.");
            return;
        }


        if (prev != null) {
            prev.Next = current.Next;
        } else {
            Node temp = head;
            while (temp.Next != head) {
                temp = temp.Next;
            }
            head = current.Next;
            temp.Next = head;
        }
    }


    // Search for a node with a specific value in circular linked list
    public Node Search(int data) {
        if (head == null) {
            return null;
        }

        Node current = head;
        do {
            if (current.data == data) {
                return current;
            }
            current = current.Next;
        } while (current != head);

        return null;
    }


    // Get the length of the circular linked list
    public int GetLength() {
        if (head == null) {
            return 0;
        }

        int length = 0;
        Node current = head;
        do {
            length++;
            current = current.Next;
        } while (current != head);

        return length;
    }


    // Reverse the circular linked list
    public void Reverse() {
        if (head == null || head.Next == head)
            return;

        Node prev = null;
        Node current = head;
        Node next = null;
        Node tail = head;

        do {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        } while (current != head);

        head.Next = prev;
        head = prev;
    }


    // Display the circular linked list
    public void Display() {
        if (head == null) {
            Console.WriteLine("List is empty.");
            return;
        }

        Node current = head;
        do {
            Console.Write(current.data + " -> ");
            current = current.Next;
        } while (current != head);
        Console.WriteLine("(head)");
    }
}




class Program {
    static void Main() {
        CircularLinkedList cll = new CircularLinkedList();
        cll.InsertAtBeginning(10);
        cll.InsertAtEnd(20);
        cll.InsertAtPosition(15, 2);
        cll.Display();

        cll.DeleteNode(15);
        cll.Display();

        cll.InsertAtEnd(30);
        cll.InsertAtEnd(40);
        cll.Reverse();
        cll.Display();

        Console.WriteLine("Length: " + cll.GetLength());

        Node foundNode = cll.Search(20);
        if (foundNode != null) {
            Console.WriteLine("Node with value 20 found.");
        } else {
            Console.WriteLine("Node with value 20 not found.");
        }
    }
}