# Trie (Prefix Tree)

## Introduction
A Trie, also known as a Prefix Tree, is a tree-like data structure that is used to store a dynamic set of strings where the keys are usually strings. It is used for efficient retrieval of a key in a large dataset of strings.


![Screenshot 2025-01-18 161734](https://github.com/user-attachments/assets/d5bf0626-bf56-45f0-a374-9722b16f66be)


## Why Use a Trie?
- **Efficient Searching**: Tries provide O(m) time complexity for search operations, where m is the length of the key.
- **Prefix Matching**: Tries are particularly useful for applications that involve prefix matching, such as autocomplete and spell checking.
- **Dynamic Growth**: Tries can grow and shrink dynamically, making them suitable for applications where data changes frequently.

## Terminologies
- **Node**: The fundamental part of a tree, which contains data.
- **Root**: The topmost node of a tree.
- **Edge**: The connection between two nodes.
- **Leaf**: A node with no children.
- **Parent**: A node that has one or more children.
- **Child**: A node that has a parent.
- **Subtree**: A tree consisting of a node and its descendants.
- **Height**: The length of the longest path from the root to a leaf.
- **Depth**: The length of the path from the root to a node.

## Properties of a Trie
- **Character Nodes**: Each node in a Trie represents a character of a string.
- **End of Word**: A boolean flag in each node indicates whether the node represents the end of a word.
- **Children**: Each node contains a dictionary of children nodes, representing the next characters in the strings.

## Example Code Snippet
Here's a simple example of a Trie in C#:

```csharp
using System;
using System.Collections.Generic;

public class TrieNode
{
    public Dictionary<char, TrieNode> Children { get; set; }
    public bool IsEndOfWord { get; set; }

    public TrieNode()
    {
        Children = new Dictionary<char, TrieNode>();
        IsEndOfWord = false;
    }
}

public class Trie
{
    private readonly TrieNode root;

    public Trie()
    {
        root = new TrieNode();
    }

    public void Insert(string word)
    {
        var node = root;
        foreach (var ch in word)
        {
            if (!node.Children.ContainsKey(ch))
            {
                node.Children[ch] = new TrieNode();
            }
            node = node.Children[ch];
        }
        node.IsEndOfWord = true;
    }

    public bool Search(string word)
    {
        var node = root;
        foreach (var ch in word)
        {
            if (!node.Children.ContainsKey(ch))
            {
                return false;
            }
            node = node.Children[ch];
        }
        return node.IsEndOfWord;
    }

    public bool StartsWith(string prefix)
    {
        var node = root;
        foreach (var ch in prefix)
        {
            if (!node.Children.ContainsKey(ch))
            {
                return false;
            }
            node = node.Children[ch];
        }
        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Trie trie = new Trie();
        trie.Insert("apple");
        Console.WriteLine(trie.Search("apple"));   // returns true
        Console.WriteLine(trie.Search("app"));     // returns false
        Console.WriteLine(trie.StartsWith("app")); // returns true
        trie.Insert("app");
        Console.WriteLine(trie.Search("app"));     // returns true
    }
}
```


### Real-World Applications
*• Autocomplete:* Used in search engines and text editors to suggest words based on prefixes.

*• Spell Checking:* Used to quickly find and suggest corrections for misspelled words.

*• IP Routing:* Used in networking to store routing information.

*• DNA Sequencing:* Used in bioinformatics to store and search DNA sequences.

*• Data Compression:* Used in algorithms like LZW (Lempel-Ziv-Welch) for efficient data compression.

This implementation provides a basic structure for a Trie (Prefix Tree) in C#. It includes methods for inserting words, 
searching for words, and checking for prefixes. This can be further extended to include more functionalities as needed.