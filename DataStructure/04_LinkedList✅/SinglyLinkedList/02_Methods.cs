using System;
using System.Threading;
using System.Threading.Tasks;

class Node {
    public int data;
    public Node Next;

    public Node(int data) {
        this.data = data;
        Next = null;
    }
}

class SinglyLinkedList {
    private Node head;

    private async Task AnimateOperation(string operationName, Func<bool> isOperationComplete) {
        while (!isOperationComplete()) {
            for (int i = 0; i < 3; i++) {
                if (isOperationComplete()) break;
                Console.Write($"{operationName}[");
                for (int j = 0; j <= i; j++) {
                    Console.Write(".");
                }
                Console.Write("]\r");
                await Task.Delay(500);
            }
        }
        Console.WriteLine($"{operationName}[...]\n"); // Final state after completion
    }

    // InsertAtBeginning()
    public async Task InsertAtBeginning(int data) {
        bool isInserted = false;
        var animationTask = AnimateOperation("Inserting at the beginning", () => isInserted);

        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
        isInserted = true;
        await animationTask;
    }

    // InsertAtEnd()
    public async Task InsertAtEnd(int data) {
        bool isInserted = false;
        var animationTask = AnimateOperation("Inserting at the end", () => isInserted);

        Node newNode = new Node(data);
        if (head == null) {
            head = newNode;
            isInserted = true;
            await animationTask;
            return;
        }

        Node curr = head;
        while (curr.Next != null) {
            curr = curr.Next;
        }
        curr.Next = newNode;
        isInserted = true;
        await animationTask;
    }

    // Insert At given position
    public async Task InsertAtPosition(int data, int pos) {
        bool isInserted = false;
        var animationTask = AnimateOperation("Inserting at position", () => isInserted);

        if (pos < 1) {
            Console.WriteLine("Position should be >= 1");
            isInserted = true;
            await animationTask;
            return;
        }
        if (pos == 1) {
            await InsertAtBeginning(data);
            return;
        }

        Node newNode = new Node(data);
        Node curr = head;
        for (int i = 0; i < pos - 1 && curr != null; i++) {
            curr = curr.Next;
        }

        if (curr == null) {
            Console.WriteLine("Position out of range.");
        } else {
            newNode.Next = curr.Next;
            curr.Next = newNode;
        }
        isInserted = true;
        await animationTask;
    }

    // Delete a node with a specific value
    public async Task DeleteNode(int deldata) {
        bool isDeleted = false;
        var animationTask = AnimateOperation("Deleting", () => isDeleted);

        if (head == null) {
            Console.WriteLine("List is empty.");
            isDeleted = true;
            await animationTask;
            return;
        }

        if (head.data == deldata) {
            head = head.Next;
            isDeleted = true;
            await animationTask;
            return;
        }

        Node curr = head;
        while (curr.Next != null && curr.Next.data != deldata) {
            curr = curr.Next;
        }

        if (curr.Next == null) {
            Console.WriteLine("Value not found");
        } else {
            curr.Next = curr.Next.Next;
        }
        isDeleted = true;
        await animationTask;
    }

    // Method to display the linked list
    public void Display() {
        Node current = head;
        while (current != null) {
            Console.Write(current.data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}

class Program {
    static async Task Main() {
        SinglyLinkedList sl = new SinglyLinkedList();
        await sl.InsertAtEnd(1);
        await sl.InsertAtEnd(2);
        await sl.InsertAtEnd(3);
        sl.Display();

        await sl.DeleteNode(2);
        sl.Display();
    }
}
