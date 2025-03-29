// ==================
//  Weighted Graph
// ==================


/*
    • A graph in which the edges are already specified with suitable 
      weight is known as a weighted graph.
    • Weighted graphs can be further classified as directed weighted 
      graphs and undirected weighted graphs.
*/


using System;
using System.Collections.Generic;

class Weighted_Graph {
    private Dictionary<int, List<(int, int)>> adjList = new Dictionary<int, List<(int, int)>>();

    public void AddVertex(int vertex) {
        if (!adjList.ContainsKey(vertex))
            adjList[vertex] = new List<(int, int)>();
    }

    public void AddEdge(int startVertex, int endVertex, int weight) {
        if (adjList.Contains(startVertex) && adjList.Contains(endVertex))
            adjList[startVertex].Add((endVertex, weight));
    }

    protected void DisplayGraph() {
        foreach (var vertex in adjList.Keys) {
            Console.Write(vertex + " -> ");
            foreach (var edge in adjList[vertex])
                Console.WriteLine($"({edge.Item1}, {edge.Item2})");
            Console.WriteLine();
        }
    }


    // Main method
    static void Main() {
        Weighted_Graph g = new Weighted_Graph();

        g.AddVertex(1);
        g.AddVertex(2);
        g.AddVertex(3);

        g.AddEdge(1, 2, 5);
        g.AddEdge(1, 3, 10);
        g.AddEdge(2, 3, 2);

        g.DisplayGraph();
    }
}