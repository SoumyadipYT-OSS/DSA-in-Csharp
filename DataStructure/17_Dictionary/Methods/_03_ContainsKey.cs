using System;
using static System.Console;
using System.Collections.Generic;


class _03_ContainsKey 
{
    static void Main() 
    {
        Dictionary<string, string> registeredUsers = new Dictionary<string, string>();


        registeredUsers.Add("Subham", "subham@gmail.com");
        registeredUsers.Add("Swarup", "swarup@gmail.com");
        registeredUsers.Add("Abhishek", "abhishek@gmail.com");

        RegisterNewUser(registeredUsers, "Subham", "subham2@gmail.com");
        RegisterNewUser(registeredUsers, "Aditya", "aditya@gmail.com");
    }


    protected static void RegisterNewUser(Dictionary<string, string> users, string username, string email) 
    {
        if (users.ContainsKey(username))
            WriteLine($"[REGISTRATION FAILED] The Username '{username}' is already taken.");
        else
        {
            users.Add(username, email);
            WriteLine($"[SUCCESS]: Account created for '{username}'");
        }
    }
}