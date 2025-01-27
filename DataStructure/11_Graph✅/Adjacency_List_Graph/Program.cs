using System;
using System.Collections.Generic;

public class Graph
{
    // Method to add an edge between two vertices
    public static void AddEdge(List<List<int>> adj, int i, int j)
    {
        adj[i].Add(j);
        adj[j].Add(i); // Undirected
    }

    // Method to display the adjacency list
    public static void DisplayAdjList(List<List<int>> adj)
    {
        for (int i = 0; i < adj.Count; i++)
        {
            Console.Write(i + ": "); // Print the vertex
            foreach (int j in adj[i])
            {
                Console.Write(j + " "); // Print its adjacent
            }
            Console.WriteLine();
        }
    }


    // Main method
    public static void Main(string[] args)
    {
        // Create a graph with 4 vertices and no edges
        int V = 4;
        List<List<int>> adj = new List<List<int>>(V);
        for (int i = 0; i < V; i++)
        {
            adj.Add(new List<int>());
        }

        // Now add edges one by one
        AddEdge(adj, 0, 1);
        AddEdge(adj, 0, 2);
        AddEdge(adj, 1, 2);
        AddEdge(adj, 2, 3);

        Console.WriteLine("Adjacency List Representation:");
        DisplayAdjList(adj);
    }
}