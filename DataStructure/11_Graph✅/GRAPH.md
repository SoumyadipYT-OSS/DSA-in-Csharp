# Graph Data Structure in C#

## Introduction
A graph is a collection of nodes (vertices) and edges connecting them. 
Graphs are used to represent various real-world problems like social networks, transportation systems, and more. In this guide, we will explore the implementation of a graph data structure in C#.

## Key Concepts
- **Vertex**: A node in the graph.
- **Edge**: A connection between two vertices.
- **Adjacency List**: A way to represent a graph using lists to store adjacent vertices.

## Graph Representation
We will represent the graph using an adjacency list. Each vertex will have a list of adjacent vertices.

## Implementation

### Graph Class
```csharp
using System;
using System.Collections.Generic;

public class Graph
{
    private Dictionary<int, List<int>> adjList;

    public Graph()
    {
        adjList = new Dictionary<int, List<int>>();
    }

    public void AddVertex(int vertex)
    {
        if (!adjList.ContainsKey(vertex))
        {
            adjList[vertex] = new List<int>();
        }
    }

    public void AddEdge(int vertex1, int vertex2)
    {
        if (adjList.ContainsKey(vertex1) && adjList.ContainsKey(vertex2))
        {
            adjList[vertex1].Add(vertex2);
            adjList[vertex2].Add(vertex1);
        }
    }

    public void PrintGraph()
    {
        foreach (var vertex in adjList)
        {
            Console.Write(vertex.Key + ": ");
            foreach (var edge in vertex.Value)
            {
                Console.Write(edge + " ");
            }
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        Graph graph = new Graph();
        graph.AddVertex(1);
        graph.AddVertex(2);
        graph.AddVertex(3);
        graph.AddEdge(1, 2);
        graph.AddEdge(2, 3);
        graph.PrintGraph();
    }
}
```


### Real-World Applications:
*• Social Networks:*
>> Connections: Representing relationships between users (e.g., friends, followers).

>> Recommendations: Suggesting friends or content based on mutual connections and interests.

*• Transportation Networks:*
>> Routes: Mapping out routes and connections between cities, train stations, or bus stops.

>> Navigation: Finding the shortest or fastest path between two locations using algorithms like Dijkstra's or A*.

*• Internet & Web:*
>> Web Pages: Representing web pages as nodes and hyperlinks as edges.

>> Search Engines: Using graph algorithms to rank web pages (e.g., Google's PageRank algorithm).
*• Biology & Medicine:*

*• Telecommunications:*

*• Recommendation Systems:*

*• Game Development:*

*• Electrical Engineering:*

*• Project Management:*

*• Fraud Detection:*