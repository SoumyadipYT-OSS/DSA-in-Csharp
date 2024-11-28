using System;


class NodeSingly {
    public int data;
    public NodeSingly Next;

    public NodeSingly(int data) {
        this.data = data;
        Next = null;
    }
}



class LinkedList {
    public static NodeSingly MergeTwoLists(NodeSingly l1, NodeSingly l2) {
        if (l1 == null) return l2;
        if (l2 == null) return l1;

        if (l1.data < l2.data) {
            l1.Next = MergeTwoLists(l1.Next, l2);
            return l1;
        } else {
            l2.Next = MergeTwoLists(l1, l2.Next);
            return l2;
        }
    }
}