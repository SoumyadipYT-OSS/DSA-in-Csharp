using System;
using System.Collections.Generic;

public class Graph
{
    // Method to add an edge between two vertices
    public static void AddEdge(int[,] mat, int i, int j)
    {
        mat[i, j] = 1;
        mat[j, i] = 1; // Since the graph is undirected
    }

    // Method to display the adjacency matrix
    public static void DisplayMatrix(int[,] mat)
    {
        int V = mat.GetLength(0);
        for (int i = 0; i < V; i++)
        {
            for (int j = 0; j < V; j++)
                Console.Write(mat[i, j] + " ");
            Console.WriteLine();
        }
    }

    // Main method
    public static void Main(string[] args)
    {
        // Create a graph with 4 vertices and no edges
        // Note that all values are initialized as 0
        int V = 4;
        int[,] mat = new int[V, V];

        // Now add edges one by one
        AddEdge(mat, 0, 1);
        AddEdge(mat, 0, 2);
        AddEdge(mat, 1, 2);
        AddEdge(mat, 2, 3);

        /* Alternatively we can also create using below
           code if we know all edges in advance

         int[,] mat = {
             { 0, 1, 0, 0 },
             { 1, 0, 1, 0 },
             { 0, 1, 0, 1 },
             { 0, 0, 1, 0 }
         }; */

        Console.WriteLine("Adjacency Matrix Representation");
        DisplayMatrix(mat);
    }
}