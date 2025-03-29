// ========================
//  Directed Acyclic Graph
// ========================

/*
  A directed graph that does not contain any cycle. 
*/


using System;
using System.Collections.Generic;

class Directed_Acyclic_Graph {
    private Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();

    public void AddVertex(int vertex) {
        if (!adjList.ContainsKey(vertex))
            adjList[vertex] = new List<int>();
    }

    public void AddEdge(int startVertex, int endVertex) {
        if (adjList.ContainsKey(startVertex) && adjList.ContainsKey(endVertex))
            adjList[startVertex].Add(endVertex);
    }

    public void DisplayGraph() {
        foreach (var vertex in adjList.Keys) {
            Console.Write(vertex + " -> ");
            Console.WriteLine(string.Join(", ", adjList[vertex]));
        }
    }


    // Main method
    static void Main() {
        Directed_Acyclic_Graph g = new Directed_Acyclic_Graph();

        g.AddVertex(1);
        g.AddVertex(2);
        g.AddVertex(3);

        g.AddEdge(1, 2);
        g.AddEdge(1, 3);
        g.AddEdge(2, 3);

        g.DisplayGraph();
    }
}