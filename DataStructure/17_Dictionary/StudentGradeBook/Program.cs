using static System.Console;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> grades = new();

        grades.Add("Asmita", 85);
        grades.Add("Bunty", 92);
        grades.Add("Debarna", 78);
        grades.Add("Debjit", 90); // duplicate value can store but not key

        try
        {
            grades.Add("Debjit", 92);   // attempt to add duplicate key
        } 
        catch(ArgumentException)
        {
            WriteLine("Debjit already exists");
        }

        // Access a value by key
        WriteLine("Bunty's marks: {0}", grades["Bunty"]);

        // Update a value using the indexer
        grades["Debarna"] = 82;
        WriteLine("Debarna's updated score: {0}", grades["Debarna"]);

        // Add a new student using indexer
        grades["Subhasis"] = 87;

        // Safe lookup with TryGetValue
        if (grades.TryGetValue("Namita", out int namitaMarks))
            WriteLine("Namita's marks: {0}", namitaMarks);
        else
            WriteLine("Namita is not the gradebook");


        // Check before inserting
        if (!grades.ContainsKey("Oindrilla"))
        {
            grades.Add("Oindrilla", 95);
            WriteLine("Added Oindrilla with score {0}", grades["Oindrilla"]);
        }


        WriteLine("\n--- Marksheet ---");
        foreach (KeyValuePair<string, int> kvp in grades)
            WriteLine("Student: {0}, Marks: {1}", kvp.Key, kvp.Value);

        // Enumerate only marks
        WriteLine("\n--- Marks ---");
        foreach (int m in grades.Values)
            WriteLine("Marks: {0}", m);

        // Enumerate only students
        WriteLine("\n--- Students ---");
        foreach (string s in grades.Keys)
            WriteLine("Student Name: {0}", s);

        // Remove a student
        WriteLine("\nRemove(\"Namita\"");
        grades.Remove("Namita");

        if (!grades.ContainsKey("Namita"))
            WriteLine("Student 'Namita' is not found.");
    }
}