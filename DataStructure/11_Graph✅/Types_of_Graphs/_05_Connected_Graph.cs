using System;
using System.Collections.Generic;


namespace _05_ConnectedGraph {
    public class Graph {
        private readonly List<int>[] adjList;

        public Graph(int vertices) {
            adjList = new List<int>[vertices];
            for (int i = 0; i < vertices; i++)
                adjList[i] = new List<int>();
        }

        protected void AddEdge(int v, int w) {
            adjList[v].Add(w);
            adjList[w].Add(v);
        }

        private bool IsConnected() {
            bool[] visited = new bool[adjList.Length];
            DFS(0, visited);
            return Array.Exists(visited, v => !v) == false;
        }

        private void DFS(int v, bool[] visited) {
            visited[v] = true;
            foreach (var neighbor in adjList[v])
                if (!visited[neighbor]) DFS(neighbor, visited);
        }


        // Main method
        static void Main() {
            var graph = new Graph(5);
            graph.AddEdge(0, 1);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);

            Console.WriteLine(graph.IsConnected() ? "Yes, it is connected!" : "Not connected");
        }
    }
}