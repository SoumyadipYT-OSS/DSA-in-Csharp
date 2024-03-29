﻿using System;
/*
    Here I've documented that there are many ways to declaration and initialization of a string in C#. 
*/
namespace pr1
{
    class q1
    {
        static void Main(string[] args)
        {
            // Declare without initializing.
            string message1;

            // Initialize to null.
            string? message2 = null;        // The '?' is the syntax of C# to initialize a string variable

            // Initialize as an empty string.
            // Use the empty constant instead of the literal "".
            string message3 = System.String.Empty;


            // Initialize with a regular string literal.
            string oldPath = "C:\\Program Files\\NVIDIA GPU Computing Toolkit\\CUDA";

            // Initialize with a vertatim string literal.
            string newPath = @"C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA";


            // Use System.String if you prefer
            System.String greet = "Welcome to DSA in C# Programming Language";

            // In local variables (i.e. within a method body)
            // you can use implicit typing.
            var temp = "I'm still a strongly-typed System.String!";

            // Use a const string to prevent 'message4' from
            // being used to store another string value.
            const string message4 = "You can't get rid of me!";

            // Use the String constructor only when creating
            // a string from a char*, char[], or sbyte*. See
            // System.String documentation for details.
            char[] letters = { 'A', 'B', 'C' };
            string alphabet = new string(letters);   // You don't use the 'new' operator to create a string object except when initializing the string with an array of chars.
        }
    }
}
