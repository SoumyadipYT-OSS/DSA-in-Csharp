// ================
//  Cyclic Graph
// ================

/*
     A graph containing at least one cycle is known as a Cyclic graph.
*/

using System;
using System.Collections.Generic;

class Cyclic_Graph {
    protected class Graph {
        public int Vertices;
        public List<int>[] AdjList;

        public Graph(int vertices) {
            Vertices = vertices;
            AdjList = new List<int>[vertices];
            for (int i = 0; i < vertices; i++)
                AdjList[i] = new List<int>();
        }

        public void AddEdge(int source, int destination) {
            AdjList[source].Add(destination);
        }
    }

    protected static bool HasCycle(Graph graph, int node, bool[] visited, bool[] recStack) {
        if (recStack[node])
            return true;

        if (visited[node])
            return false;

        visited[node] = true;
        recStack[node] = true;

        foreach (var neighbor in graph.AdjList[node])
            if (HasCycle(graph, neighbor, visited, recStack))
                return true;

        recStack[node] = false;
        return false;
    }

    private static bool DetectCycle(Graph graph) {
        var visited = new bool[graph.Vertices];
        var recStack = new bool[graph.Vertices];

        for (int i = 0; i < graph.Vertices; i++)
            if (!visited[i] && HasCycle(graph, i, visited, recStack))
                return true;

        return false;
    }


    // Main method
    static void Main() {
        Graph graph = new Graph(4);
        graph.AddEdge(0, 1);
        graph.AddEdge(1, 2);
        graph.AddEdge(2, 0);
        graph.AddEdge(3, 3);

        bool hasCycle = DetectCycle(graph);
        Console.WriteLine("Does the graph contain a cycle? " + hasCycle);
    }
}