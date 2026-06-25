using System;
using static System.Console;
using System.Collections.Generic;


class _01_Add 
{
    static void Main() 
    {
        Dictionary<int, string> shoppingCart = new Dictionary<int, string>();

        shoppingCart.Add(1, "Wireless Mouse");
        shoppingCart.Add(2, "Keyboard");
        shoppingCart.Add(3, "CPU");
        shoppingCart.Add(4, "Monitor");

        foreach (var item in shoppingCart) 
        {
            WriteLine($"Order Id: {item.Key} => Order Item: {item.Value}");
        }

        WriteLine();

        try {
            WriteLine("Attempting to add 'Wireless Keyboard' again using .Add()...");
            shoppingCart.Add(2, "Wireless Keyboard");
        } catch (ArgumentException ex) {
            WriteLine("\n[ERROR] Add() failed!");
            WriteLine($"Message: {ex.Message}");
        }


        // Indexer
        shoppingCart[2] = "Wireless Keyboard";
        WriteLine($"\nSuccessfully updated order id: {2} quantity to: {shoppingCart[2]}");


        WriteLine("\nUpdated dictionary list");
        foreach (var item in shoppingCart) {
            WriteLine($"Order Id: {item.Key} => Order Item: {item.Value}");
        }

    }
}