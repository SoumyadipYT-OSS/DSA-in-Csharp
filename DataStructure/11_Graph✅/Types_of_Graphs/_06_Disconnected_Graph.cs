using System;
using System.Collections.Generic;


namespace _06_Disconnected_Graph {
    public class Graph {
        private int Vertices;
        private List<int>[] AdjList;

        public Graph(int vertices) {
            Vertices = vertices;
            AdjList = new List<int>[vertices];
            for (int i = 0; i < vertices; i++)
                AdjList[i] = new List<int>();
        }

        protected void AddEdge(int v, int w) {
            AdjList[v].Add(w);
            AdjList[w].Add(v);
        }

        private static void FindConnectedComponents() {
            bool[] visited = new bool[Vertices];
            int componentCount = 0;

            for (int i=0; i<Vertices; i++) {
                if (!visited[i]) {
                    Console.WriteLine($"Component {++componentCount}: ");
                    DFS(i, visited);
                    Console.WriteLine();
                }
            }
        }

        private void DFS(int v, bool[] visited) {
            visited[v] = true;
            Console.Write($"{v} ");

            foreach (int neighbor in AdjList[v]) {
                if (!visited[neighbor])
                    DFS(neighbor, visited);
            }
        }

        // Main method
        static void Main() {
            Graph graph = new Graph(7);

            graph.AddEdge(0, 1);
            graph.AddEdge(1, 2);
            graph.AddEdge(3, 4);
            graph.AddEdge(5, 6);

            Console.WriteLine("Connected Components: ");
            graph.FindConnectedComponents();
        }
    }
}