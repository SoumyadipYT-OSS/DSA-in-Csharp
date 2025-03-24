using System;


namespace _08_Complete_Graph {
    public class Graph {
        private int[,] adjMat;
        private int vertices;

        public Graph(int vertices) {
            this.vertices = vertices;
            adjMat = new int[vertices, vertices];

            for (int i = 0; i < vertices; i++) {
                for (int j = 0; j < vertices; j++)
                    if (i != j)
                        adjMat[i, j] = 1;
            }
        }

        protected void DisplayAdjacencyMatrix() {
            Console.WriteLine("Adjacency Matrix of the Complete Graph");
            for (int i = 0; i < vertices; i++) {
                for (int j = 0; j < vertices; j++)
                    Console.Write(adjMat[i, j] + " ");
                Console.WriteLine();
            }
        }

        private void VerifyProperties() {
            int expectedEdges = vertices * (vertices - 1) / 2;
            int actualEdges = 0;

            for (int i = 0; i < vertices; i++) {
                for (int j = i + 1; j < vertices; j++)
                    if (adjMat[i, j] == 1)
                        actualEdges++;
            }

            Console.WriteLine($"\nProperties: ");
            Console.WriteLine($"Vertices: {vertices}");
            Console.WriteLine($"Edges (Expected): {expectedEdges}");
            Console.WriteLine($"Edges (Actual): {actualEdges}");
            Console.WriteLine($"Each vertex has degree: {vertices - 1}");
        }


        // Main method
        static void Main() {
            int vertices = 4;
            Graph completeGraph = new Graph(vertices);

            completeGraph.DisplayAdjacencyMatrix();
            completeGraph.VerifyProperties();
        }
    }
}