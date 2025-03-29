using System;
using System.Collections.Generic;


namespace Transpose_Graph {
    public class Graph {
        private static int vertices = 5;
        private static List<int>[] adj = new List<int>[vertices];
        private static List<int>[] tr = new List<int>[vertices];


        protected static void AddEdge(int u, int v, bool choice) {
            if (!choice)
                adj[u].Add(v);
            else
                tr[u].Add(v);
        }

        protected static void printGraph() {
            for (int i=0; i<vertices; i++) {
                Console.Write(i + "--> ");
                for (int j = 0; j < tr[i].Count; j++)
                    Console.Write(tr[i][j] + " ");
                Console.WriteLine();
            }
        }

        protected static void getTranspose() {
            for (int i = 0; i < vertices; i++)
                for (int j = 0; j < adj[i].Count; j++)
                    AddEdge(adj[i][j], i, true);
        }


        // Main method
        static void Main() {
            for (int i=0; i<vertices; i++) {
                adj[i] = new List<int>();
                tr[i] = new List<int>();
            }
            AddEdge(0, 1, false);
            AddEdge(0, 4, false);
            AddEdge(0, 3, false);
            AddEdge(2, 0, false);
            AddEdge(3, 2, false);
            AddEdge(4, 1, false);
            AddEdge(4, 3, false);

            getTranspose();

            printGraph();
        }
    }
}