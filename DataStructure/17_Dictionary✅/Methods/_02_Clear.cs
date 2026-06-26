using System;
using static System.Console;
using System.Collections.Generic;


class _02_Clear 
{
    static void Main() 
    {
        Dictionary<string, bool> lobby = new Dictionary<string, bool>();

        WriteLine("\tOR GATE Table chart");
        lobby.Add("A -> ", false);
        lobby.Add("B -> ", true);
        lobby.Add("Z -> ", true);

        foreach (var item in lobby) 
        {
            WriteLine($"{item.Key} {item.Value}");
        }

        WriteLine("\nClearing the lobby");
        lobby.Clear();

        WriteLine($"Lobby Cleared, count: {lobby.Count}\n");
        lobby.Add("X -> ", true);
        lobby.Add("Y -> ", false);
        lobby.Add("Result -> ", true);

        foreach (var item in lobby) 
        {
            WriteLine($"{item.Key} {item.Value}");
        }
    }
}