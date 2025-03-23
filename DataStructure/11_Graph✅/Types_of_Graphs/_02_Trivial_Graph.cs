using System;


namespace _02_Trivial_Graph {
    public class Graph {
        protected static void DisplayMatrix(int[,] mat) {
            int V = mat.GetLength(0);   // Number of vertices
            for (int i=0; i<V; i++) {
                for (int j = 0; j < V; j++)
                    Console.Write(mat[i, j] + " ");
            }
            Console.WriteLine();
        }


        static void Main() {
            int V = 1;
            int[,] mat = new int[V, V];

            Console.WriteLine("Adjacency Matrix of the Trivial Graph:");
            DisplayMatrix(mat);
        }
    }
}