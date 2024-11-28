using System;


class NodeSingly {
    public int data;
    public NodeSingly Next;

    public NodeSingly(int data) {
        this.data = data;
        Next = null;
    }
}


class NodeDoubly {
    public int data;
    public NodeDoubly Next;
    public NodeDoubly Prev;

    public NodeDoubly(int data) {
        this.data = data;
        Next = null;
        Prev = null;
    }
}



class LinkedList {
    NodeSingly head;
    public bool DetectCycleSingly() {
        if (head == null)
            return false;

        NodeSingly slow = head;
        NodeSingly fast = head;

        while (fast != null  &&  fast.Next != null) {
            slow = slow.Next;
            fast = fast.Next.Next;

            if (slow == fast) {
                return true;
            }
        }
        return false;
    }
}