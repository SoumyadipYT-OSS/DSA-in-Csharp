// =================
//  Bipartite Graph
// =================

/*
     A graph in which vertex can be divided into two sets 
     such that vertex in each set does not contain any edge between them.
*/

using System;
using System.Collections.Generic;

class BipartiteGraph {
    private static bool IsBipartite(int[,] graph, int vertices) {
        int[] color = new int[vertices];
        for (int i = 0; i < vertices; i++)
            color[i] = -1;  // Unvisited vertices

        Queue<int> queue = new Queue<int>();

        for (int start=0; start<vertices; start++) {
            if (color[start] == -1) {
                queue.Enqueue(start);
                color[start] = 0;
            }

            while (queue.Count > 0) {
                int u = queue.Dequeue();

                for (int v=0; v<vertices; v++) {
                    if (graph[u, v] == 1) {
                        if (color[v] == -1) {
                            color[v] = 1 - color[u];
                            queue.Enqueue(v);
                        } else if (color[v] == color[u])
                            return false;   // Not Bipartite
                    }
                }
            }
        }

        return true;    // Bipartite
    }


    // Main method
    static void Main() {
        int[,] graph = {
            { 0, 1, 0, 1 },
            { 1, 0, 1, 0 },
            { 0, 1, 0, 1 },
            { 1, 0, 1, 0 }
        };

        int vertices = graph.GetLength(0);
        Console.WriteLine(IsBipartite(graph, vertices) ? "Graph is Bipartite" : "Graph is not Bipartite");
    }
}