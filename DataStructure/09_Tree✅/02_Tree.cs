using System;
using System.Collections.Generic;

class TreeNode {
    public int Value;
    public List<TreeNode> Children;

    public TreeNode(int Value) {
        this.Value = Value;
        Children = new List<TreeNode>();
    }

    public void AddChild(TreeNode child) {
        Children.Add(child);
    }
}


class Tree {
    public TreeNode Root;

    public Tree(int rootValue) {
        Root = new TreeNode(rootValue);
    }

    public void Traverse(TreeNode node, Action<int> action) {
        if (node == null) return;

        action(node.Value);
        foreach (var child in node.Children) {
            Traverse(child, action);
        }
    }
}


class Program {
    static void Main() {
        Tree tree = new Tree(1);
        TreeNode child1 = new TreeNode(2);
        TreeNode child2 = new TreeNode(3);

        tree.Root.AddChild(child1);
        tree.Root.AddChild(child2);

        child1.AddChild(new TreeNode(4));
        child1.AddChild(new TreeNode(5));

        child2.AddChild(new TreeNode(6));

        tree.Traverse(tree.Root, value => Console.WriteLine(value));
    }
}
