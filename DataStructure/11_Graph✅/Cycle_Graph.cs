// ==============
//  Cycle Graph
// ==============

/*
    The graph in which the graph is a cycle in itself, the minimum value of degree of each vertex is 2. 
*/

using System;
using System.Collections.Generic;


class CycleDetection {
    private static bool HasCycle(Dictionary<int, List<int>> graph, int node, bool[] visited, bool[] recStack) {
        if (recStack[node])
            return true;
        if (visited[node])
            return false;

        visited[node] = true;
        recStack[node] = true;

        foreach (var neighbor in graph[node])
            if (HasCycle(graph, neighbor, visited, recStack))
                return true;

        recStack[node] = false;
        return false;
    }

    private static bool DetectCycle(Dictionary<int, List<int>> graph, int totalNodes) {
        var visited = new bool[totalNodes];
        var recStack = new bool[totalNodes];

        for (int i = 0; i < totalNodes; i++)
            if (!visited[i] && HasCycle(graph, i, visited, recStack))
                return true;

        return false;
    }

    // Main method
    static void Main() {
        var graph = new Dictionary<int, List<int>>() {
            { 0, new List<int> { 1, 2 } },
            { 1, new List<int> { 2 } },
            { 2, new List<int> { 0 } },
            { 3, new List<int> { 3 } }
        };

        int totalNodes = 4;
        Console.WriteLine("Does the graph contain a cycle?" + DetectCycle(graph, totalNodes));
    }
}