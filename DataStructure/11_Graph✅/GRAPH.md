# Graph Data Sctructure in C#

## What is Graph?
Graph is a collection of data item called node, where nodes are connected to 
each-other by the help of edge.
    -> A graph 'G' can be represent on ordered
        pair i.e. G(V, E).
    -> Where 'V' indicates no. of vertices or nodes
        and 'E' indicates no. of edges.

![Screenshot 2025-01-27 213400](https://github.com/user-attachments/assets/e599366c-7fca-47dc-bf12-0b31e2637367)

>> In Simple, collection of vertices and edges called Graph.

---------------

*__Explanation_*: Here is simple example of complex graph. 
![Screenshot 2025-01-27 215154](https://github.com/user-attachments/assets/ad42989a-55bf-41ca-b454-3249b38f953d)
>> So, G(5,6) in the figure, it is telling that the graph 'G' has 
total number of 5 vertices and 6 edges.

---------------

## Components of a Graph
- **Vertex (Node)**: A fundamental part of a graph that represents an entity. For example, in a social network, each person can be represented as a vertex.
- **Edge**: A connection between two vertices. Edges can be directed (one-way) or undirected (two-way). For example, in a road network, an edge can represent a road connecting two cities.

## Types of Graphs
- **Undirected Graph**: A graph where edges have no direction. The connection between vertices is bidirectional. _It is also called connected graph._
- **Directed Graph (Digraph)**: A graph where edges have a direction, indicating a one-way relationship between vertices. _It is also called unconnected graph_
- **Weighted Graph**: A graph where edges have weights, representing the cost or distance between vertices.
- **Unweighted Graph**: A graph where edges do not have weights.


### Directed Graph
It indicates a specific path from one vertex to another vertex in graph 'G'.
![Screenshot 2025-01-27 220643](https://github.com/user-attachments/assets/f8ec61c2-0212-4a0f-9d19-8d1b65eee38b)

### Undirected Graph
In this graph, edges are not associated with the any directions. For example:
if an edge exists between A & B vertices, then the vertices can be 
traversed from B to A and A to B as well.
![Screenshot 2025-01-27 222428](https://github.com/user-attachments/assets/22e98f42-ad3d-4059-bf1a-7714503940ae)

---------------

## _Terminology of Graph_
 1.  *Path:* A path is nothing but a way to reach from initial node to terminal(*target*) node.
![Screenshot 2025-01-27 225725](https://github.com/user-attachments/assets/a9892d2b-e130-4131-92c1-5c4810cc95ae)

 2. *Adjacent Node:* If two nodes A and B are connected via an edge (E), then
                    the nodes A & B are called as neighbours.
![Screenshot 2025-01-27 231556](https://github.com/user-attachments/assets/5dad1e63-955a-419d-bccf-7b0264f43489)

 3. *Cycle:* A cycle is nothing but path wich has no repeated edges or vertices
            except the first & last vertices.
 ![Screenshot 2025-01-27 232341](https://github.com/user-attachments/assets/1032359d-f6fb-4312-8b4f-d3e7a67c1ffe)
 
 4. *Degree:* The degree of nodes indicates the total number of edges connected 
              with that node in the the graph.
![Screenshot 2025-01-28 001419](https://github.com/user-attachments/assets/17f6860e-dad5-4cb1-86c4-efdd59363e4c)

 5. *Complete Graph:* If all the nodes of a graph connected to each other it is 
                      called complete graph. It is denoted by 'K'.
![Screenshot 2025-01-28 014515](https://github.com/user-attachments/assets/3121c8a5-6593-4130-a53b-e4ce981914b2)


 ---------------

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

>> Protein Interaction Networks: Mapping interactions between proteins in a cell.

>> Epidemiology: Modeling the spread of diseases through populations.

*• Telecommunications:*
>> Network Design: Designing and optimizing communication networks.

>> Routing: Finding efficient paths for data transmission.

*• Recommendation Systems:*
>> Product Recommendations: Suggesting products to users based on their purchase history and preferences.

>> Content Recommendations: Recommending movies, books, or articles based on user behavior and ratings.

*• Game Development:*
>> Pathfinding: Implementing AI for characters to navigate through game environments.

>> Level Design: Creating interconnected levels and worlds.

*• Electrical Engineering:*
>> Circuit Design: Representing electrical circuits with components as nodes and connections as edges.

>> Power Grids: Modeling and optimizing power distribution networks.

*• Project Management:*
>> Task Scheduling: Representing tasks as nodes and dependencies as edges to manage project timelines.

>> Resource Allocation: Optimizing the allocation of resources across tasks

*• Fraud Detection:*
>> Transaction Networks: Analyzing financial transactions to detect fraudulent activities.

>> Anomaly Detection: Identifying unusual patterns in data that may indicate fraud.
