using System;


namespace _01_Null_Graph {
    public class Graph {
        protected static void DisplayMatrix(int[,] mat) {
            int V = mat.GetLength(0);
            for (int i=0; i<V; i++) {
                for (int j=0; j<V; j++) {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main() {
            int V = 5;
            int[,] mat = new int[V, V];

            Console.WriteLine("Adjacency Matrix of the Null Graph:");
            DisplayMatrix(mat);
        }
    }
}