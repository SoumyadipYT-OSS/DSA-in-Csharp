using System;

namespace Adjacency_Matrix_Representation
{
    public class Graph {

        // Add on edge between two vertices
        protected static void AddEdge(int[,] mat, int i, int j) {
            mat[i, j] = 1;  // Since the graph is undirected
            mat[j, i] = 1;
        }

        // Display the adjacency matrix
        protected static void DisplayMatrix(int[,] mat) {
            int V = mat.GetLength(0);
            for (int i=0; i<V; i++) {
                for (int j=0; j<V; j++) {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }



        // Main method
        static void Main() {
            int V = 4;      // Number of vertices
            int[,] mat = new int[V, V];        // Initialize matrix

            // Add edges to the graph
            AddEdge(mat, 0, 1);
            AddEdge(mat, 0, 2);
            AddEdge(mat, 1, 2);
            AddEdge(mat, 2, 3);

            // Optionally, initialize matrix directly
            /*
            int[,] mat = new int[,]
            {
                { 0, 1, 0, 0 },
                { 1, 0, 1, 0 },
                { 0, 1, 0, 1 },
                { 0, 0, 1, 0 }
            };
            */

            Console.WriteLine("Adjacency Matrix:");
            DisplayMatrix(mat);
        }
    }
}