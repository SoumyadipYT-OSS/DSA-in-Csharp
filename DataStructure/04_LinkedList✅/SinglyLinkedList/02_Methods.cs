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
                await Task.Delay(900);
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

    // Delete a node at a specific position
    public async Task DeleteAtPosition(int pos) {
        bool isDeleted = false;
        var animationTask = AnimateOperation($"Deleting at position {pos}", () => isDeleted);

        if (pos < 1) {
            Console.WriteLine("Position should be >= 1.");
            return;
        }
        if (head == null) {
            Console.WriteLine("List is empty.");
            return;
        }
        if (pos == 1) {
            head = head.Next;
            return;
        }

        Node curr = head;
        for (int i=1; i<pos-1 && curr != null; i++) {
            curr = curr.Next;
        }
        if (curr == null ||  curr.Next == null) {
            Console.WriteLine("Position out of range.");
        } else {
            curr.Next = curr.Next.Next;
        }
        isDeleted = true;
        await animationTask;
    }

    // Search for a node with a specific value
    public async Task<Node> Search(int val) {
        bool isFound = false;
        var animationTask = AnimateOperation("Searching", () => isFound);

        Node curr = head;
        while (curr != null) {
            if (curr.data ==  val) {
                isFound = true;
                await animationTask;
                return curr;
            }
            curr = curr.Next;
        }

        isFound = true;
        await animationTask;
        Console.WriteLine("Value not found");
        return null;
    }

    // Get the length of the linked list
    public async Task<int> GetLength() {
        bool isCompleted = false;
        var animationTask = AnimateOperation("Calculating length...", () => isCompleted);

        int length = 0;
        Node curr = head;
        while (curr != null) {
            length++;
            curr = curr.Next;
        }
        isCompleted = true;
        await animationTask;
        return length;
    }

    // Reverse the linked list
    public async Task Reverse() {
        bool isReversed = false;
        var animationTask = AnimateOperation("Reversing", () => isReversed);

        Node prev = null;
        Node curr = head;
        Node next = null;
        
        while (curr != null) {
            next = curr.Next;
            curr.Next = prev;
            prev = curr;
            curr = next;
        }
        head = prev;
        isReversed = true;
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

    // Method to check the linkedList empty or not
    public bool IsEmpty() {
        return head == null;
    }

    // Remove all elements from the linked List
    public async Task Clear() {
        bool isCleared = false;
        var animationTask = AnimateOperation("Clearing list", () => isCleared);

        head = null;
        isCleared = true;
        await animationTask;
    }


    // Retrieve the Nth Node from the beginning of the Linked List
    public async Task<Node> GetNthNode(int n) {
        bool isFound = false;
        string nth = "";
        if (n==1) {
            nth = "1st";
        } else if (n == 2) {
            nth = "2nd";
        } else if (n == 3) {
            nth = "3rd";
        } else {
            nth = $"{n}th";
        }
        var animationTask = AnimateOperation($"Getting {nth} node", () => isFound);

        Node curr = head;
        int count = 0;

        while (curr != null) {
            if (count == n) {
                isFound = true;
                await animationTask;
                return curr;
            }
            count++;
            curr = curr.Next;
        }

        isFound = true;
        await animationTask;
        return null;
    }


    // Retrieve the nth node from the end of the Singly LinkedList
    public async Task<Node> GetNthNodeFromEnd(int n) {
        bool isFound = false;
        string nth = "";
        if (n == 1) {
            nth = "1st";
        } else if (n == 2) {
            nth = "2nd";
        } else if (n == 3) {
            nth = "3rd";
        } else {
            nth = $"{n}th";
        }
        var animationTask = AnimateOperation($"Getting {nth} node from end", () => isFound);

        int length = await GetLength();
        if (n > length) {
            isFound = true;
            await animationTask;
            return null;
        }

        Node curr = head;
        for (int i=0; i<length-n; i++) {
            curr = curr.Next;
        }

        isFound = true;
        await animationTask;
        return curr;
    }

    // Get the first node of the linked list
    public Node GetFirst() {
        return head;
    }

    // Get the last node of the linked list
    public async Task<Node> GetLast() {
        bool isFound = false;
        var animationTask = AnimateOperation("Getting last node", () => isFound);

        if (head == null) {
            isFound = true;
            await animationTask;
            return null;
        }

        Node curr = head;
        while (curr.Next != null) {
            curr = curr.Next;
        }

        isFound = true;
        await animationTask;
        return curr;
    }
}





class Program {
    static async Task Main() {
        SinglyLinkedList sl = new SinglyLinkedList();
        bool exit = false;

        while (!exit) {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Insert at the beginning");
            Console.WriteLine("2. Insert at the end");
            Console.WriteLine("3. Insert at a position");
            Console.WriteLine("4. Delete a node with a specific value");
            Console.WriteLine("5. Delete a node at a specific position");
            Console.WriteLine("6. Get the length of the list");
            Console.WriteLine("7. Reverse the list");
            Console.WriteLine("8. Search for a node with a specific value");
            Console.WriteLine("9. Display the list");
            Console.WriteLine("10. Check LinkedList empty or not");
            Console.WriteLine("11. Clear the Linked List");
            Console.WriteLine("12. Get Nth node");
            Console.WriteLine("13. Get Nth node from end");
            Console.WriteLine("14. Get First");
            Console.WriteLine("15. Get Last");
            Console.WriteLine("16. Exit");
            Console.WriteLine("Enter your choice: ");


            try {
                int choice = int.Parse(Console.ReadLine());

                switch (choice) {
                    case 1:
                        Console.Write("Enter value to insert at the beginning: "); 
                        int val1 = int.Parse(Console.ReadLine()); 
                        await sl.InsertAtBeginning(val1); 
                        break;
                    case 2:
                        Console.Write("Enter value to insert at the end: "); 
                        int val2 = int.Parse(Console.ReadLine()); 
                        await sl.InsertAtEnd(val2); 
                        break;
                    case 3:
                        Console.Write("Enter value to insert: "); 
                        int val3 = int.Parse(Console.ReadLine()); 
                        Console.Write("Enter position to insert at: "); 
                        int pos3 = int.Parse(Console.ReadLine()); 
                        await sl.InsertAtPosition(val3, pos3); 
                        break;
                    case 4:
                        Console.Write("Enter value to delete: "); 
                        int delVal = int.Parse(Console.ReadLine()); 
                        await sl.DeleteNode(delVal); 
                        break;
                    case 5:
                        Console.Write("Enter position to delete at: "); 
                        int delPos = int.Parse(Console.ReadLine()); 
                        await sl.DeleteAtPosition(delPos); 
                        break;
                    case 6:
                        int length = await sl.GetLength(); 
                        Console.WriteLine($"Length of the list: {length}"); 
                        break;
                    case 7:
                        await sl.Reverse();
                        break;
                    case 8:
                        Console.Write("Enter value to search for: "); 
                        int searchVal = int.Parse(Console.ReadLine()); 
                        Node foundNode = await sl.Search(searchVal);
                        if (foundNode != null) {
                            Console.WriteLine($"Node with value {foundNode.data} found.");
                        }
                        break;
                    case 9:
                        sl.Display();
                        break;
                    case 10:
                        sl.IsEmpty();
                        break;
                    case 11:
                        await sl.Clear();
                        break;
                    case 12:
                        Console.Write("Enter the nth value to search: ");
                        int Nth = int.Parse(Console.ReadLine());
                        Node foundNthNode = await sl.GetNthNode(Nth);
                        Console.WriteLine($"The value is: ", foundNthNode);
                        break;
                    case 13:
                        Console.Write("Enter the nth value from end to search: ");
                        int Nth_from_end = int.Parse(Console.ReadLine());
                        Node foundNth_from_endNode = await sl.GetNthNodeFromEnd(Nth_from_end);
                        Console.WriteLine($"The value is: ", foundNth_from_endNode);
                        break;
                    case 14:
                        sl.GetFirst();
                        break;
                    case 15:
                        await sl.GetLast();
                        break;
                    case 16:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            } catch (FormatException) {
                Console.WriteLine("Invalid input. Please enter valid number");
            } catch (Exception ex) {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}