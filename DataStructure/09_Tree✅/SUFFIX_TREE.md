# Suffix Tree

## Introduction
A Suffix Tree is a compressed trie of all the suffixes of a given string. It is a powerful data structure that allows for efficient string matching and various other string operations.


![image](https://github.com/user-attachments/assets/ba388422-61a5-4d28-bdcd-070c5305a9d6)


## Why Use a Suffix Tree?
- **Efficient String Matching**: Suffix Trees provide O(m) time complexity for searching a pattern in a text, where m is the length of the pattern.
- **Multiple String Operations**: Suffix Trees can be used for various string operations such as finding the longest repeated substring, longest common substring, and more.
- **Space Efficient**: Suffix Trees are space-efficient as they compress common prefixes of the suffixes.

## Terminologies
- **Node**: The fundamental part of a tree, which contains data.
- **Root**: The topmost node of a tree.
- **Edge**: The connection between two nodes.
- **Leaf**: A node with no children.
- **Parent**: A node that has one or more children.
- **Child**: A node that has a parent.
- **Suffix**: A substring that starts at a given position and extends to the end of the string.

## Properties of a Suffix Tree
- **Compressed Trie**: A Suffix Tree is a compressed trie of all the suffixes of a given string.
- **Linear Time Construction**: Suffix Trees can be constructed in linear time using algorithms like Ukkonen's algorithm.
- **Efficient Operations**: Suffix Trees provide efficient solutions to various string problems.

## Example Code Snippet
Here's a simple example of a Suffix Tree in C#:

```csharp
using System;
using System.Collections.Generic;

public class SuffixTreeNode
{
    public Dictionary<char, SuffixTreeNode> Children { get; set; }
    public int Start { get; set; }
    public int End { get; set; }
    public SuffixTreeNode SuffixLink { get; set; }

    public SuffixTreeNode(int start, int end)
    {
        Children = new Dictionary<char, SuffixTreeNode>();
        Start = start;
        End = end;
        SuffixLink = null;
    }
}

public class SuffixTree
{
    private readonly string text;
    private readonly SuffixTreeNode root;
    private SuffixTreeNode activeNode;
    private int activeEdge;
    private int activeLength;
    private int remainingSuffixCount;
    private int leafEnd;

    public SuffixTree(string text)
    {
        this.text = text;
        root = new SuffixTreeNode(-1, -1);
        activeNode = root;
        activeEdge = -1;
        activeLength = 0;
        remainingSuffixCount = 0;
        leafEnd = -1;
        BuildSuffixTree();
    }

    private void BuildSuffixTree()
    {
        for (int i = 0; i < text.Length; i++)
        {
            ExtendSuffixTree(i);
        }
    }

    private void ExtendSuffixTree(int pos)
    {
        leafEnd = pos;
        remainingSuffixCount++;
        SuffixTreeNode lastNewNode = null;

        while (remainingSuffixCount > 0)
        {
            if (activeLength == 0)
            {
                activeEdge = pos;
            }

            if (!activeNode.Children.ContainsKey(text[activeEdge]))
            {
                activeNode.Children[text[activeEdge]] = new SuffixTreeNode(pos, leafEnd);
                if (lastNewNode != null)
                {
                    lastNewNode.SuffixLink = activeNode;
                    lastNewNode = null;
                }
            }
            else
            {
                SuffixTreeNode next = activeNode.Children[text[activeEdge]];
                int edgeLength = next.End - next.Start + 1;
                if (activeLength >= edgeLength)
                {
                    activeEdge += edgeLength;
                    activeLength -= edgeLength;
                    activeNode = next;
                    continue;
                }

                if (text[next.Start + activeLength] == text[pos])
                {
                    if (lastNewNode != null && activeNode != root)
                    {
                        lastNewNode.SuffixLink = activeNode;
                        lastNewNode = null;
                    }
                    activeLength++;
                    break;
                }

                SuffixTreeNode split = new SuffixTreeNode(next.Start, next.Start + activeLength - 1);
                activeNode.Children[text[activeEdge]] = split;
                split.Children[text[pos]] = new SuffixTreeNode(pos, leafEnd);
                next.Start += activeLength;
                split.Children[text[next.Start]] = next;

                if (lastNewNode != null)
                {
                    lastNewNode.SuffixLink = split;
                }

                lastNewNode = split;
            }

            remainingSuffixCount--;

            if (activeNode == root && activeLength > 0)
            {
                activeLength--;
                activeEdge = pos - remainingSuffixCount + 1;
            }
            else if (activeNode != root)
            {
                activeNode = activeNode.SuffixLink;
            }
        }
    }

    public void Print()
    {
        Print(root, 0);
    }

    private void Print(SuffixTreeNode node, int height)
    {
        if (node.Start != -1)
        {
            Console.WriteLine(text.Substring(node.Start, node.End - node.Start + 1));
        }

        foreach (var child in node.Children.Values)
        {
            Print(child, height + 1);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string text = "banana";
        SuffixTree suffixTree = new SuffixTree(text);
        suffixTree.Print();
    }
}
```


### Real-World Applications
*• String Matching:* Used in scenarios where efficient string matching is required, such as search engines and text editors.

*• Bioinformatics:* Used in bioinformatics to analyze DNA sequences.

*• Data Compression:* Used in data compression algorithms to find repeated substrings.

*• Plagiarism Detection:* Used to detect plagiarism by finding common substrings between documents.


This implementation provides a basic structure for a Suffix Tree in C#. 
It includes methods for building the tree and printing the suffixes. 
This can be further extended to include more functionalities as needed.
