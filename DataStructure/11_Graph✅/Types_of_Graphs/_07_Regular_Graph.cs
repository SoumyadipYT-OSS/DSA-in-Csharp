using System;
using System.Collections.Generic;


namespace _07_Regular_Graph {
    public class Graph {
        private int Vertices;
        private List<int>[] adjList;

        public Graph(int vertices) {
            Vertices = vertices;
            adjList = new List<int>[vertices];
            for (int i = 0; i < vertices; i++)
                adjList[i] = new List<int>();
        }

        protected void AddEdge(int v, int w) {
            adjList[v].Add(w);
            adjList[w].Add(v);
        }

        private bool IsRegular() {
            if (Vertices == 0)
                return true;

            int degree = adjList[0].Count;

            foreach (var neighbors in adjList) {
                if (neighbors.Count != degree)
                    return false;
            }
            return true;
        }


        // Main method
        static void Main() {
            Graph graph = new Graph(5);

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 4);
            graph.AddEdge(3, 4);

            Console.WriteLine("Is the graph regular?");
            Console.WriteLine(graph.IsRegular() ? "Yes, it is connected" : "Not connected");
        }
    }
}