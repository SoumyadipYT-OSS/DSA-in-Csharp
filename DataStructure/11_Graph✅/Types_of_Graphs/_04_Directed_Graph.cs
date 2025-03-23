using System;


namespace _04_Directed_Graph {
    public class Graph {
        protected static void AddEdge(int[,] mat, int i, int j) {
            mat[i, j] = 1;
        }

        protected static void DisplayMatrix(int[,] mat) {
            int V = mat.GetLength(0);
            for (int i=0; i<V; i++) {
                for (int j = 0; j < V; j++)
                    Console.Write(mat[i, j] + " ");
                Console.WriteLine();
            }
        }


        // Main method
        static void Main() {
            int V = 4;
            int[,] mat = new int[V, V];

            AddEdge(mat, 0, 1);
            AddEdge(mat, 1, 2);
            AddEdge(mat, 2, 3);
            AddEdge(mat, 3, 0);

            Console.WriteLine("Adjacency Matrix of the Directed Graph");
            DisplayMatrix(mat);
        }
    }
}